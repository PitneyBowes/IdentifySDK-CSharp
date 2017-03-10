#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.identify.common.model;
using com.pb.identify.common;
using com.pb.identify.IdentifyEntity;
using com.pb.identify.IdentifyEntity.Model.ExtractEntities;

using com.pb.identify.manager;
using com.pb.identify.oauth;
using com.pb.identify.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace IdentifySDKTestCases
{
    [TestClass]
    public class ExtractEntitiesTest
    {
        private static IdentifyEntityService identifyEntityService;
        private static String TEST_URL = String.Empty;
        private static String TEST_TOKEN = String.Empty;
        AutoResetEvent TriggerTest;

        [TestInitialize()]
        public void Initialize()
        {
            TEST_URL = ConfigurationManager.AppSettings["TEST_URL"];
            TEST_TOKEN = ConfigurationManager.AppSettings["TEST_TOKEN"];
            //Assert.IsFalse(String.IsNullOrEmpty(TEST_URL), "No App.Config found.");
            IdentifyServiceManager iaServiceManager;
            BasicAuthServiceImpl basicAuthServiceImpl = new BasicAuthServiceImpl(TEST_TOKEN, TEST_URL);
            iaServiceManager = IdentifyServiceManager.getInstance(basicAuthServiceImpl);
            identifyEntityService = iaServiceManager.getIdentifyEntityService();

        }

        [TestMethod]
        public void ExtractEntitiesUnitTest()
        {
            try
            {
                List<Record> rowList = new List<Record>();

                List<user_field> user_fields = new List<user_field>();
                user_field userfield = new user_field { name = "name1", value = "value1" };
                user_fields.Add(userfield);

                rowList.Add(new Record(user_fields, plaintext: "Michael Phelps was a American swimmer. He was born on 30 June 1985 in Towson, Maryland, USA. Visit www.michaelphelps.com"));
               
                Options options = new Options();
                options.OutputEntityCount = "true";
       
                List<String> EntityList = new List<string>();
                EntityList.Add(Entity.Person.ToString());
                EntityList.Add(Entity.Location.ToString());
                options.EntityList = String.Join(",", EntityList.ToArray());
                
                input input = new input();
            
                input.RecordList = rowList;
                ExtractEntitiesAPIRequest request = new ExtractEntitiesAPIRequest(input, options);

                ExtractEntitiesAPIResponse response = identifyEntityService.ExtractEntities(request);

                Assert.IsInstanceOfType(response, typeof(ExtractEntitiesAPIResponse));
                string output = Utility.ObjectToJson<ExtractEntitiesAPIResponse>(response);
                Debug.WriteLine(output);

            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected exception");
            }
        }

        [TestMethod]
        public void ExtractEntitiesAsyncTest()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                identifyEntityService.IdentifyEntityRequestFinishedEvent += (object sender, WebResponseEventArgs<ExtractEntitiesAPIResponse> eventArgs) =>
                {
                    try
                    {
                        Assert.IsTrue(eventArgs.ResponseObject != null);
                        this.TriggerTest.Set();
                    }
                    catch (Exception)
                    {
                        failFlag = true;
                        this.TriggerTest.Set();

                    }
                };

                List<Record> rowList = new List<Record>();

                List<user_field> user_fields = new List<user_field>();
                user_field userfield = new user_field { name = "name1", value = "value1" };
                user_fields.Add(userfield);

                rowList.Add(new Record(user_fields, plaintext: "Michael Phelps was a American swimmer. He was born on 30 June 1985 in Towson, Maryland, USA. Visit www.michaelphelps.com"));

                Options options = new Options();
                
                input input = new input();
   
                input.RecordList = rowList;
                ExtractEntitiesAPIRequest request = new ExtractEntitiesAPIRequest(input, options);

                identifyEntityService.ExtractEntitiesAsync(request);

                this.TriggerTest.WaitOne(10000);
                if (failFlag)
                {
                    Assert.Fail("Test Case Failed");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getAddressjsonTestAndCompareSDKResponseTest()
        {
            try
            {
                String inputjsonText = "{\"options\": {"
                            + "\"EntityList\": \"Person\", \"OutputEntityCount\": \"\"},\"Input\": {" + "\"Row\":[{" + "\"PlainText\": \"Michael Phelps was a American swimmer. He was born on 30 June 1985 in Towson, Maryland, USA. Visit www.michaelphelps.com\"" + "}]}}";

                List<Record> rowList = new List<Record>();

                rowList.Add(new Record(null, plaintext: "Michael Phelps was a American swimmer. He was born on 30 June 1985 in Towson, Maryland, USA. Visit www.michaelphelps.com"));

                Options options = new Options();
                input input = new input();
     
                input.RecordList = rowList;  
                ExtractEntitiesAPIRequest request = new ExtractEntitiesAPIRequest(input, options);

                ExtractEntitiesAPIResponse response = identifyEntityService.ExtractEntities(request);
                string sdkResponse = Utility.ObjectToJson<ExtractEntitiesAPIResponse>(response);

                String apiResponse = TestUtility.ValidateFromAPI(TEST_URL, "/identifyentity/v1/rest/extractentities/", TEST_TOKEN, inputjsonText, com.pb.identify.utils.Utility.contentType.json);
                apiResponse = apiResponse.Replace("\r\n    ", "");
                apiResponse = apiResponse.Replace("{\r\n", "{");
                apiResponse = apiResponse.Replace("\"", "");
                sdkResponse = sdkResponse.Replace("\"", "");

                apiResponse = string.Join("", apiResponse.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                sdkResponse = string.Join("", sdkResponse.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                Assert.AreEqual(sdkResponse, apiResponse);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception: " + e);
            }
        }
    }
}
