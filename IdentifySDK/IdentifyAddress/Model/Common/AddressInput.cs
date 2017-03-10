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
    public abstract class AddressInput
    {
        /// <summary>
        /// Gets or sets the addressLine1.
        /// </summary>
        /// <value>
        /// The addressLine1.
        /// </value>
        [DataMember]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the AddressLine2.
        /// </summary>
        /// <value>
        /// The AddressLine2.
        /// </value>
        [DataMember]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>
        /// The City.
        /// </value>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>
        /// The Country.
        /// </value>
        [DataMember]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the StateProvince.
        /// </summary>
        /// <value>
        /// The StateProvince.
        /// </value>
        [DataMember]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or sets the PostalCode.
        /// </summary>
        /// <value>
        /// The PostalCode.
        /// </value>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the FirmName.
        /// </summary>
        /// <value>
        /// The FirmName.
        /// </value>
        [DataMember]
        public string FirmName { get; set; }

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
