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
using com.pb.identify.IdentifyEmail;
using com.pb.identify.IdentifyEmail.Model.ValidateEmailAddress;

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
    public class ValidateEmailAddressTest
    {
        private static IdentifyEmailService identifyEmailService;
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
            identifyEmailService = iaServiceManager.getIdentifyEmailService();

        }

        [TestMethod]
        public void Test()
        {
            try
            {
                List<Record> rowList = new List<Record>();

                List<user_field> user_fields = new List<user_field>();
                user_field userfield = new user_field { name = "name1", value = "value1" };
                user_fields.Add(userfield);

                rowList.Add(new Record(user_fields, emailaddress: "support@pb.com"));

                rowList.Add(new Record(null, bogus: "true", emailaddress: "xyz@abc.com"));

                input input = new input();
                input.RecordList = rowList;

                ValidateEmailAddressAPIRequest request = new ValidateEmailAddressAPIRequest(input);

                ValidateEmailAddressAPIResponse response = identifyEmailService.ValidateEmailAddress(request);

                Assert.IsInstanceOfType(response, typeof(ValidateEmailAddressAPIResponse));
                string output = Utility.ObjectToJson<ValidateEmailAddressAPIResponse>(response);
                Debug.WriteLine(output);

            }
            catch(Exception e)
            {
                Assert.Fail("Unexpected exception");
            }
        }

        [TestMethod]
        public void TestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                identifyEmailService.IdentifyAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<ValidateEmailAddressAPIResponse> eventArgs) =>
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

                rowList.Add(new Record(user_fields, emailaddress: "support@pb.com"));

                List<user_field> user_fieldsample = new List<user_field>();
                rowList.Add(new Record(null, bogus: "true", emailaddress: "xyz@abc.com"));

                input input = new input();
                input.RecordList = rowList;

                ValidateEmailAddressAPIRequest request = new ValidateEmailAddressAPIRequest(input);

                identifyEmailService.ValidateEmailAddressAsync(request);

                this.TriggerTest.WaitOne(10000);
                if (failFlag)
                {
                    Assert.Fail("Test Case Failed");
                }
            }
            catch(Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void getAddressjsonTestAndCompareSDKResponseTest()
        { 
            try
            {
                String inputjsonAddresses = "{\"Input\": {" + "\"Row\":[{" + "\"emailAddress\": \"support@pb.com\"" + "}]}}";

                List<Record> rowList = new List<Record>();

                rowList.Add(new Record(null, emailaddress: "support@pb.com"));

                input input = new input();
                input.RecordList = rowList;

                ValidateEmailAddressAPIRequest request = new ValidateEmailAddressAPIRequest(input);

                ValidateEmailAddressAPIResponse response = identifyEmailService.ValidateEmailAddress(request);
                string sdkResponse = Utility.ObjectToJson<ValidateEmailAddressAPIResponse>(response);
                
                String apiResponse = TestUtility.ValidateFromAPI(TEST_URL, "/identifyemail/v1/rest/validateemailaddress/", TEST_TOKEN, inputjsonAddresses, com.pb.identify.utils.Utility.contentType.json);
                
                apiResponse = apiResponse.Replace("\r\n    ", "");
                apiResponse = apiResponse.Replace("{\r\n", "{");
            
                apiResponse = string.Join("", apiResponse.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                sdkResponse = string.Join("", sdkResponse.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                Assert.AreEqual(sdkResponse, apiResponse);
            }
            catch(Exception e)
            {
                Assert.Fail("Unexpected Exception: "+ e);
            }
        }
    }
}
