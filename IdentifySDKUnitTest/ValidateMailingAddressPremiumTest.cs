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
using com.pb.identify.identifyAddress;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddressPremium;
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
    public class ValidateMailingAddressPremiumTest
    {
        private static IdentifyAddressService identifyAddressService;
        private static String TEST_URL = String.Empty;
        private static String TEST_TOKEN = String.Empty;
        AutoResetEvent TriggerTest;

        [TestInitialize()]
        public void Initialize()
        {
            TEST_URL = ConfigurationManager.AppSettings["TEST_URL"];
            TEST_TOKEN = ConfigurationManager.AppSettings["TEST_TOKEN"];
            Assert.IsFalse(String.IsNullOrEmpty(TEST_URL), "No App.Config found.");
            IdentifyServiceManager iaServiceManager;
            BasicAuthServiceImpl basicAuthServiceImpl = new BasicAuthServiceImpl(TEST_TOKEN, TEST_URL);
            iaServiceManager = IdentifyServiceManager.getInstance(basicAuthServiceImpl);
            identifyAddressService = iaServiceManager.getIdentifyAddressService();
        }

        [TestMethod]
        public void Test()
        {
            try
            {
                List<Address> rowList = new List<Address>();

                user_field userfield = new user_field{name = "email", value ="xyz@pb.com"};
                List<user_field> user_fields = new List<user_field>();
                user_fields.Add(userfield);

                rowList.Add(new Address(user_fields,addressline1: "101 cherry st"));

                List<user_field> user_fieldsample = new List<user_field>();
                rowList.Add(new Address(null, addressline1: "12 yonge st", country: "ca", stateorprovince: "on"));
                options op = new options();

                input input = new input();
                input.AddressList = rowList;

                ValidateMailingAddressPremiumAPIRequest request = new ValidateMailingAddressPremiumAPIRequest(input, op);
                ValidateMailingAddressPremiumAPIResponse response = identifyAddressService.ValidateMailingAddressPremium(request);

                Assert.IsInstanceOfType(response, typeof(ValidateMailingAddressPremiumAPIResponse));
                string output = Utility.ObjectToJson<ValidateMailingAddressPremiumAPIResponse>(response);
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
                identifyAddressService.ValidateAddressPremiumFinishedEvent += (object sender, WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse> eventArgs) =>
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

                List<Address> rowList = new List<Address>();

                List<user_field> user_fieldsample = new List<user_field>();

                rowList.Add(new Address(user_fieldsample, addressline1: "101 cherry st"));
                rowList.Add(new Address(user_fieldsample, addressline1: "12 yonge st", country: "ca", stateorprovince: "on"));
                options op = new options();

                input input = new input();
                input.AddressList = rowList;

                ValidateMailingAddressPremiumAPIRequest request = new ValidateMailingAddressPremiumAPIRequest(input, op);
                identifyAddressService.ValidateMailingAddressPremiumAsync(request);
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
        public void getAddressProjsonTestAndCompareSDKResponseTest()
        {
            try
            {
                String inputjsonAddresses = "{\"Input\": {"
                              + "\"Row\":[{"
                               + "\"AddressLine1\": \"101 cherry st\","
                               + "\"Country\": \"us\","
                               + "\"PostalCode\": \"\""
                      + "},"
                      +"{"
                      + "\"AddressLine1\": \"12 yonge st\","
                      + "\"City\": \"toronto\","
                      + "\"Country\": \"ca\","
                      + "\"StateProvince\": \"on\","
                      + "\"PostalCode\": \"\""
                      + "}]}}";

                List<Address> rowList = new List<Address>();

                user_field userfield = new user_field { name = "email", value = "xyz@pb.com" };
                List<user_field> user_fields = new List<user_field>();
                user_fields.Add(userfield);

                rowList.Add(new Address(null, addressline1: "101 cherry st", country:"us"));

                List<user_field> user_fieldsample = new List<user_field>();
                rowList.Add(new Address(null, addressline1: "12 yonge st", country: "ca", stateorprovince: "on", city: "toronto"));
                options op = new options();

                input input = new input();
                input.AddressList = rowList;

                ValidateMailingAddressPremiumAPIRequest request = new ValidateMailingAddressPremiumAPIRequest(input, op);
                ValidateMailingAddressPremiumAPIResponse response = identifyAddressService.ValidateMailingAddressPremium(request);
                string sdkResponse = Utility.ObjectToJson<ValidateMailingAddressPremiumAPIResponse>(response);

                String apiResponse = TestUtility.ValidateFromAPI(TEST_URL, "/identifyaddress/v1/rest/validatemailingaddresspremium/", TEST_TOKEN, inputjsonAddresses, com.pb.identify.utils.Utility.contentType.json);

                Assert.AreEqual(sdkResponse, apiResponse);

            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected Exception");
            }
        }
    }
}
