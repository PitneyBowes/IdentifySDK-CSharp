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
using com.pb.identify.common.model;
using System.Runtime.Serialization;

namespace com.pb.identify.IdentifyEntity.Model.ExtractEntities
{
    public enum Entity
    {
        Address,
        CreditCard,
        Date,
        Email,
        HashTag,
        ISBN,
        Location,
        Mention,
        Organization,
        Person,
        Phone,
        ProperNouns,
        SSN,
        WebAddress,
        ZipCode
    };
    /// <summary>
    /// Input Record
    /// </summary>
    [DataContract]
    public class Record
    {
        /// <summary>
        /// Gets or sets the PlainText.
        /// </summary>
        /// <value>
        /// PlainText.
        /// </value>
        [DataMember(Name = "PlainText")]
        public string PlainText { get; set; }

        [DataMember]
        public List<user_field> user_fields { get; set; }

        public Record(List<user_field> userfields, string plaintext = "")
        {
            if (plaintext != "")
                PlainText = plaintext;

            user_fields = userfields;
        }
    }

    /// <summary>
    /// options class for EntityList and OutputEntitiyCount
    /// </summary>
    [DataContract(Name = "options")]
    public class Options 
    {
        /// <summary>
        /// Gets or sets the EntityList
        /// </summary>
        /// <value>
        /// EntityList.
        /// </value>
        [DataMember(Name = "EntityList")]
        public String EntityList { get; set; }

        /// <summary>
        /// Gets or sets the OutputEntityCount
        /// </summary>
        /// <value>
        /// OutputEntityCount.
        /// </value>
        [DataMember(Name = "OutputEntityCount")]
        public String OutputEntityCount { get; set; }

        public Options()
        {
            List<String> Entities = new List<string>();
            Entities.Add(Entity.Person.ToString());
            Entities.Add(Entity.Address.ToString());
            EntityList = String.Join(",", Entities.ToArray());
            OutputEntityCount = "";
        }
    }

    /// <summary>
    /// List of Records
    /// </summary>
    [DataContract(Name = "Input")]
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
    /// Request of ExtractEntitiesAPI
    /// </summary>
    [DataContract]
    public class ExtractEntitiesAPIRequest
    {
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        /// <value>
        /// Options
        /// </value>
        [DataMember]
        public Options options { get; set; }

        /// <summary>
        /// Gets or sets the Input.
        /// </summary>
        /// <value>
        /// Input
        /// </value>
        [DataMember]
        public input Input { get; set; }

        public ExtractEntitiesAPIRequest(input lirow, Options op)
        {
            Input = lirow;
            options = op;
        }
    }
}
