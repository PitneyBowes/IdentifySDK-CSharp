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

namespace com.pb.identify.identifyAddress.Model.GetCityStateProvince
{
    /// <summary>
    /// options class for GetCityStateProvince Input
    /// </summary>
    [DataContract]
    public class options
    {
        /// <summary>
        /// Gets or sets the PerformUSProcessing.
        /// </summary>
        /// <value>
        /// The PerformUSProcessing.
        /// </value>
        [DataMember]
        public string PerformUSProcessing { get; set; }

        /// <summary>
        /// Gets or sets the PerformCanadianProcessing.
        /// </summary>
        /// <value>
        /// The PerformCanadianProcessing.
        /// </value>
        [DataMember]
        public string PerformCanadianProcessing { get; set; }

        /// <summary>
        /// Gets or sets the OutputVanityCity.
        /// </summary>
        /// <value>
        /// The OutputVanityCity.
        /// </value>
        [DataMember]
        public string OutputVanityCity { get; set; }

        /// <summary>
        /// Gets or sets the MaximumResults.
        /// </summary>
        /// <value>
        /// The MaximumResults.
        /// </value>
        [DataMember]
        public string MaximumResults { get; set; }

        /// <summary>
        /// Constructor sets the Options Default value.
        /// </summary>
        public options()
        {
            PerformUSProcessing = "Y";
            PerformCanadianProcessing = "Y";
            OutputVanityCity = "N";
            MaximumResults = "10";
        }
    }

    /// <summary>
    /// Input Record
    /// </summary>
    [DataContract(Name = "Row")]
    public class Record
    {
        /// <summary>
        /// Gets or sets the PostalCode.
        /// </summary>
        /// <value>
        /// The PostalCode.
        /// </value>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the user_fields.
        /// </summary>
        /// <value>
        /// List of user_field.
        /// </value>
        [DataMember]
        public List<user_field> user_fields { get; set; }

        /// <summary>
        /// Record Constructor .
        /// </summary>
        public Record(List<user_field> userfields, String postalCode = "")
        {
            PostalCode = postalCode;
            
            user_fields = userfields;
        }
    }

    /// <summary>
    /// List of Records
    /// </summary>
    [DataContract]
    public class input
    {
        /// <summary>
        /// Gets or sets the List of Records.
        /// </summary>
        /// <value>
        /// List of Records.
        /// </value>
        [DataMember(Name = "Row")]
        public List<Record> RecordList { get; set; }
    }

    /// <summary>
    /// Request of GetCityStateProvinceAPIRequest
    /// </summary>
    [DataContract]
    public class GetCityStateProvinceAPIRequest
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

        public GetCityStateProvinceAPIRequest(input liRow, options optionparam)
        {
            Input = liRow;
            options = optionparam;
        }
    }
}
