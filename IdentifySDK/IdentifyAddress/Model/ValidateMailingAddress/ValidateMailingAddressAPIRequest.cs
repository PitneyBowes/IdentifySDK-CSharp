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

namespace com.pb.identify.identifyAddress.Model.ValidateMailingAddress
{
    /// <summary>
    /// options class for OutPutCasing
    /// </summary>
    [DataContract]
    public class options
    {
        /// <summary>
        /// Gets or sets the OutputCasing.
        /// </summary>
        /// <value>
        /// The OutputCasing.
        /// </value>
        [DataMember]
        public string OutputCasing { get; set; }

        /// <summary>
        /// Constructor sets the OutputCasing Default value.
        /// </summary>
        public options()
        {
            OutputCasing = "M";
        }
    }

    /// <summary>
    /// Input Address
    /// </summary>
    [DataContract(Name = "Row")]
    public class Address : AddressInput
    {
        /// <summary>
        /// Address Constructor .
        /// </summary>
        public Address(List<user_field> userfields, string country = "", String addressline1 = "", String addressline2 = "", String city = "", String stateorprovince = "", String postalCode = "", String firmname = "")
        {
            AddressLine1 = addressline1;
            AddressLine2 = addressline2;
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
    /// Request of ValidateMailingAddressAPI
    /// </summary>
    [DataContract]
    public class ValidateMailingAddressAPIRequest
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

        public ValidateMailingAddressAPIRequest(input liRow, options optionparam)
        {
            Input = liRow;
            options = optionparam;
        }

    }
}
