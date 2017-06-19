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

namespace com.pb.identify.identifyAddress.Model.GetPostalCodes
{
    /// <summary>
    /// GetPostalCodes
    /// </summary>
    [DataContract]
    public class Output
    {
        /// <summary>
        /// Gets or sets the postalCode.
        /// </summary>
        /// <value>
        /// The postalCode.
        /// </value>
        [DataMember(Name = "PostalCode")]
        public string PostalCode { get; set; }

     
        /// <summary>
        /// Gets or sets the cityType.
        /// </summary>
        /// <value>
        /// The cityType.
        /// </value>
        [DataMember(Name = "City.Type")]
        public string CityType { get; set; }

        
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
        /// Gets or sets the user_fields.
        /// </summary>
        /// <value>
        /// List of user_field.
        /// </value>
        [DataMember]

        public List<user_field> user_fields { get; set; }

    }

    /// <summary>
    /// Response of GetPostalCodesAPI
    /// (List of postal codes)
    /// </summary>
    [DataContract]
    public class GetPostalCodesAPIResponse
    {
        [DataMember(Name = "Output")]
        public List<Output> OutputList { get; set; }
    }
}
