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

namespace com.pb.identify.identifyAddress.Model.GetPostalCodes
{
    /// <summary>
    /// options class for GetPostalCodes Input
    /// </summary>
    [DataContract]
    public class options
    {
        /// <summary>
        /// Gets or sets the OutputVanityCity.
        /// </summary>
        /// <value>
        /// The OutputVanityCity.
        /// </value>
        [DataMember]
        public string OutputVanityCity { get; set; }

        /// <summary>
        /// Gets or sets the OutputCityType.
        /// </summary>
        /// <value>
        /// The OutputCityType.
        /// </value>
        [DataMember]
        public string OutputCityType { get; set; }

        
        /// <summary>
        /// Constructor sets the Default value.
        /// </summary>
        public options()
        {
            OutputVanityCity = "N";
            OutputCityType = "N";
        }
    }

    /// <summary>
    /// Input Record
    /// </summary>
    [DataContract(Name = "Row")]
    public class Record
    {
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        /// <value>
        /// The City.
        /// </value>
        [DataMember]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the StateProvince.
        /// </summary>
        /// <value>
        /// The StateProvince.
        /// </value>
        [DataMember]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or sets the user_fields.
        /// </summary>
        /// <value>
        /// List of user_field.
        /// </value>
        [DataMember]
        public List<user_field> user_fields { get; set; }

        /// <summary>
        /// Address Constructor .
        /// </summary>
        public Record(List<user_field> userfields, String city = "", String stateprovince = "")
        {
            City = city;
            StateProvince = stateprovince;
                       
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
        /// List of Addresses.
        /// </value>
        [DataMember(Name = "Row")]
        public List<Record> RecordList { get; set; }
    }

    /// <summary>
    /// Request of GetPostalCodesAPIRequest
    /// </summary>
    [DataContract]
    public class GetPostalCodesAPIRequest
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

        public GetPostalCodesAPIRequest(input liRow, options optionparam)
        {
            Input = liRow;
            options = optionparam;
        }
    }
}
