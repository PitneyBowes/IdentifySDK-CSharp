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
using com.pb.identify.common.model;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using com.pb.identify.identifyAddress.Model.Common;

namespace com.pb.identify.identifyAddress.Model.ValidateMailingAddressPro
{
    /// <summary>
    /// Validated Address
    /// </summary>
    [DataContract]
    public class Output : AddressOutput
    {
        /// <summary>
        /// Gets or sets the CouldNotValidate.
        /// </summary>
        /// <value>
        /// The CouldNotValidate.
        /// </value>
        [DataMember]
        public string CouldNotValidate { get; set; }

        /// <summary>
        /// Gets or sets the AddressQuality.
        /// </summary>
        /// <value>
        /// The AddressQuality.
        /// </value>
        [DataMember]
        public string AddressQuality { get; set; }

        /// <summary>
        /// Gets or sets the Deliverability.
        /// </summary>
        /// <value>
        /// The Deliverability.
        /// </value>
        [DataMember]
        public string Deliverability { get; set; }

        /// <summary>
        /// Gets or sets the AddressType.
        /// </summary>
        /// <value>
        /// The AddressType.
        /// </value>
        [DataMember]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or sets the Locality.
        /// </summary>
        /// <value>
        /// The Locality.
        /// </value>
        [DataMember]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the ChangeScore.
        /// </summary>
        /// <value>
        /// The ChangeScore.
        /// </value>
        [DataMember]
        public string ChangeScore { get; set; }

        /// <summary>
        /// Gets or sets the Suburb.
        /// </summary>
        /// <value>
        /// The Suburb.
        /// </value>
        [DataMember]
        public string Suburb { get; set; }
    }

    /// <summary>
    /// Response of ValidateMailingAddressProAPI
    /// (List of validated addresses)
    /// </summary>
    [DataContract]
    public class ValidateMailingAddressProAPIResponse
    {
        [DataMember(Name = "Output")]
        public List<Output> OutputList { get; set; }
    }

}
