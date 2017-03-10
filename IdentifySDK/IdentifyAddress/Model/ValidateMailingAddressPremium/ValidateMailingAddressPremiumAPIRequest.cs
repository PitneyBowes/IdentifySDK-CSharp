#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using com.pb.identify.common.model;
using com.pb.identify.identifyAddress.Model.Common;

namespace com.pb.identify.identifyAddress.Model.ValidateMailingAddressPremium
{
        /// <summary>
        /// options class
        /// </summary>
        [DataContract]
        public class options
        {
            /// <summary>
            /// Gets or sets the OutputAddressBlocks.
            /// </summary>
            /// <value>
            /// The OutputAddressBlocks.
            /// </value>
            [DataMember]
            public string OutputAddressBlocks { get; set; }

            /// <summary>
            /// Gets or sets the OutputCountryFormat.
            /// </summary>
            /// <value>
            /// The OutputCountryFormat.
            /// </value>
            [DataMember]
            public string OutputCountryFormat { get; set; }

            /// <summary>
            /// Gets or sets the KeepMultimatch.
            /// </summary>
            /// <value>
            /// The KeepMultimatch.
            /// </value>
            [DataMember]
            public string KeepMultimatch { get; set; }

            /// <summary>
            /// Gets or sets the OutputScript.
            /// </summary>
            /// <value>
            /// The OutputScript.
            /// </value>
            [DataMember]
            public string OutputScript { get; set; }

            /// <summary>
            /// Gets or sets the OutputCasing.
            /// </summary>
            /// <value>
            /// The OutputCasing.
            /// </value>
            [DataMember]
            public string OutputCasing { get; set; }

            /// <summary>
            /// Gets or sets the MaximumResults.
            /// </summary>
            /// <value>
            /// The MaximumResults.
            /// </value>
            [DataMember]
            public string MaximumResults { get; set; }

            /// <summary>
            /// Gets or sets the OutputRecordType.
            /// </summary>
            /// <value>
            /// The OutputRecordType.
            /// </value>
            [DataMember]
            public string OutputRecordType { get; set; }

            /// <summary>
            /// Gets or sets the OutputFieldLevelReturnCodes.
            /// </summary>
            /// <value>
            /// The OutputFieldLevelReturnCodes.
            /// </value>
            [DataMember]
            public string OutputFieldLevelReturnCodes { get; set; }

            /// <summary>
            /// Constructor sets the default value for options.
            /// </summary>
            public options()
            {
                OutputCasing = "M";
                OutputScript = "InputScript";
                OutputAddressBlocks = "Y";
                KeepMultimatch = "N";
                OutputCountryFormat = "E";
                MaximumResults = "10";
                OutputFieldLevelReturnCodes = "N";
                OutputRecordType = "A";
            }
        }

        /// <summary>
        /// Input Address
        /// </summary>
        [DataContract(Name = "Row")]
        public class Address : AddressInput
        {
            /// <summary>
            /// Gets or sets the AddressLine3.
            /// </summary>
            /// <value>
            /// The AddressLine3.
            /// </value>
            [DataMember]
            public string AddressLine3 { get; set; }

            /// <summary>
            /// Gets or sets the AddressLine4.
            /// </summary>
            /// <value>
            /// The AddressLine4.
            /// </value>
            [DataMember]
            public string AddressLine4 { get; set; }

            /// <summary>
            /// Gets or sets the AddressLine5.
            /// </summary>
            /// <value>
            /// The AddressLine5.
            /// </value>
            [DataMember]
            public string AddressLine5 { get; set; }

            /// <summary>
            /// Address Constructor .
            /// </summary>
            public Address(List<user_field> userfields, string country = "", String addressline1 = "", String addressline2 = "",
                String addressline3 = "", String addressline4 = "", String addressline5 = "", 
                String city = "", String stateorprovince = "", String postalCode = "", String firmname = "")
            {
                AddressLine1 = addressline1;
                AddressLine2 = addressline2;
                AddressLine3 = addressline3;
                AddressLine4 = addressline4;
                AddressLine5 = addressline5;
                City = city;
                StateProvince = stateorprovince;
                Country = country;
                PostalCode = postalCode;
                FirmName = firmname;

                user_fields = userfields;
            }
        }

        /// <summary>
        /// List of Addresses
        /// </summary>
        [DataContract]
        public class input
        {
            /// <summary>
            /// Gets or sets the List of Addresses.
            /// </summary>
            /// <value>
            /// List of Addresses.
            /// </value>
            [DataMember(Name = "Row")]
            public List<Address> AddressList { get; set; }
        }

        /// <summary>
        /// Request of ValidateMailingAddressPremiumAPI
        /// </summary>
        [DataContract]
        public class ValidateMailingAddressPremiumAPIRequest
        {
            /// <summary>
            /// Gets or sets the options.
            /// </summary>
            /// <value>
            /// options
            /// </value>
            [DataMember]
            public options options { get; set; }

            /// <summary>
            /// Gets or sets the Input.
            /// </summary>
            /// <value>
            /// Input
            /// </value>
            [DataMember]
            public input Input { get; set; }

            public ValidateMailingAddressPremiumAPIRequest(input liRow, options optionparam)
            {
                Input = liRow;
                options = optionparam;
            }
        }
}