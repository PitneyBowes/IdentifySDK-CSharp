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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using com.pb.identify.common.model;

namespace com.pb.identify.identifyAddress.Model.Common
{
    [DataContract]
    public abstract class AddressOutput
    {
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        /// <value>
        /// The Status.
        /// </value>
        [DataMember(Name = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the statuscode.
        /// </summary>
        /// <value>
        /// The statuscode.
        /// </value>
        [DataMember(Name = "Status.Code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the statusDescription.
        /// </summary>
        /// <value>
        /// The statusDescription.
        /// </value>
        [DataMember(Name = "Status.Description")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the addressLine1.
        /// </summary>
        /// <value>
        /// The addressLine1.
        /// </value>
        [DataMember]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the addressLine2.
        /// </summary>
        /// <value>
        /// The addressLine2.
        /// </value>
        [DataMember]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the stateProvince.
        /// </summary>
        /// <value>
        /// The stateProvince.
        /// </value>
        [DataMember]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or sets the postalCode.
        /// </summary>
        /// <value>
        /// The postalCode.
        /// </value>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [DataMember]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the firmName.
        /// </summary>
        /// <value>
        /// The firmName.
        /// </value>
        [DataMember(Name = "firmName")]
        public string FirmName { get; set; }

        /// <summary>
        /// Gets or sets the blockAddress.
        /// </summary>
        /// <value>
        /// The blockAddress.
        /// </value>
        [DataMember]
        public string BlockAddress { get; set; }

        /// <summary>
        /// Gets or sets the postalCodeBase.
        /// </summary>
        /// <value>
        /// The postalCodeBase.
        /// </value>
        [DataMember(Name = "PostalCode.Base")]
        public string PostalCodeBase { get; set; }

        /// <summary>
        /// Gets or sets the postalCodeAddOn.
        /// </summary>
        /// <value>
        /// The postalCodeAddOn.
        /// </value>
        [DataMember(Name = "PostalCode.AddOn")]
        public string PostalCodeAddOn { get; set; }

        /// <summary>
        /// Gets or sets the additionalInputData.
        /// </summary>
        /// <value>
        /// The additionalInputData.
        /// </value>
        [DataMember]
        public string AdditionalInputData { get; set; }

        /// <summary>
        /// Gets or sets the user_fields.
        /// </summary>
        /// <value>
        /// List of user_field.
        /// </value>
        [DataMember]
        public List<user_field> user_fields { get; set; }
    }
}
