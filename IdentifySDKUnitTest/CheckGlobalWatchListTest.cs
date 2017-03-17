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
using com.pb.identify.identifyRisk;
using com.pb.identify.identifyRisk.Model.CheckGlobalWatchList;

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
    public class CheckGlobalWatchListTest
    {

        private static IdentifyRiskService identifyRiskService;
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
            identifyRiskService = iaServiceManager.getIdentifyRiskService();

        }

        [TestMethod]
        public void Test()
        {
            try
            {
                List<Record> rowList = new List<Record>();

                List<user_field> user_fields = new List<user_field>();
                user_field userfield = new user_field { name = "email", value = "xyz@test.com" };
                user_fields.Add(userfield);

                rowList.Add(new Record(user_fields, firstname: "migual", lastname: "batista"));
                List<user_field> user_fieldsample = new List<user_field>();
                rowList.Add(new Record(null, addressline1: "701 Pine Drift Dr", name: "John Smith", country: "usa"));

                input input = new input();
                input.RecordList = rowList;

                CheckGlobalWatchListAPIRequest request = new CheckGlobalWatchListAPIRequest(input);
                CheckGlobalWatchListAPIResponse response = identifyRiskService.CheckGlobalWatchList(request);

                Assert.IsInstanceOfType(response, typeof(CheckGlobalWatchListAPIResponse));
                string output = Utility.ObjectToJson<CheckGlobalWatchListAPIResponse>(response);
                Debug.WriteLine(output);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [TestMethod]
        public void TestAsync()
        {
            try
            {
                Boolean failFlag = false;
                this.TriggerTest = new AutoResetEvent(false);
                identifyRiskService.IdentifyAPIRequestFinishedEvent += (object sender, WebResponseEventArgs<CheckGlobalWatchListAPIResponse> eventArgs) =>
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
                user_field userfield = new user_field { name = "email", value = "xyz@test.com" };
                user_fields.Add(userfield);

                rowList.Add(new Record(user_fields, firstname: "migual", lastname: "batista"));

                List<user_field> user_fieldsample = new List<user_field>();
                rowList.Add(new Record(null, addressline1: "701 Pine Drift Dr", name: "John Smith", country: "usa"));

                input input = new input();
                input.RecordList = rowList;

                CheckGlobalWatchListAPIRequest request = new CheckGlobalWatchListAPIRequest(input);
               identifyRiskService.CheckGlobalWatchListAsync(request);

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

    }
}
