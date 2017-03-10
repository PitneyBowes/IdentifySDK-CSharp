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

namespace com.pb.identify.IdentifyEntity.Model.ExtractEntities
{
    /// <summary>
    /// Response of ExtractEntitiesAPI
    /// (List of output records)
    /// </summary>
    [DataContract]
    public class ExtractEntitiesAPIResponse
    {
        /// <summary>
        /// List of output records
        /// </summary>
        [DataMember(Name = "Output")]
        public List<Output> OutputList { get; set; }
    }
    /// <summary>
    /// Output Record
    /// </summary>
    [DataContract]
    public class Output
    {
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        /// <value>
        /// Text.
        /// </value>
        [DataMember(Name = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>
        /// Type.
        /// </value>
        [DataMember(Name = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        /// <value>
        /// Count.
        /// </value>
        [DataMember(Name = "Count")]
        public string Count { get; set; }

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
}
