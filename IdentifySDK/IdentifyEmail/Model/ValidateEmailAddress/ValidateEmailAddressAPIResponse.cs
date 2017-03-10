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

namespace com.pb.identify.IdentifyEmail.Model.ValidateEmailAddress
{
    /// <summary>
    /// Response of ValidateEmailAddressAPI
    /// (List of output records)
    /// </summary>
    [DataContract]
    public class ValidateEmailAddressAPIResponse
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
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// Email.
        /// </value>
        [DataMember(Name = "EMAIL")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Finding.
        /// </summary>
        /// <value>
        /// Finding.
        /// </value>
        [DataMember(Name = "FINDING")]
        public string Finding { get; set; }

        /// <summary>
        /// Gets or sets the Comment.
        /// </summary>
        /// <value>
        /// Comment.
        /// </value>
        [DataMember(Name = "COMMENT")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the CommentCode.
        /// </summary>
        /// <value>
        /// CommentCode.
        /// </value>
        [DataMember(Name = "COMMENT_CODE")]
        public string CommentCode { get; set; }

        /// <summary>
        /// Gets or sets the SuggEmail.
        /// </summary>
        /// <value>
        /// SuggEmail.
        /// </value>
        [DataMember(Name = "SUGG_EMAIL")]
        public string SuggEmail { get; set; }

        /// <summary>
        /// Gets or sets the SuggComment.
        /// </summary>
        /// <value>
        /// SuggComment.
        /// </value>
        [DataMember(Name = "SUGG_COMMENT")]
        public string SuggComment { get; set; }

        /// <summary>
        /// Gets or sets the ErrorResponse.
        /// </summary>
        /// <value>
        /// ErrorResponse.
        /// </value>
        [DataMember(Name = "ERROR_RESPONSE")]
        public string ErrorResponse { get; set; }

        /// <summary>
        /// Gets or sets the Error.
        /// </summary>
        /// <value>
        /// Error.
        /// </value>
        [DataMember(Name = "ERROR")]
        public string Error { get; set; }

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
