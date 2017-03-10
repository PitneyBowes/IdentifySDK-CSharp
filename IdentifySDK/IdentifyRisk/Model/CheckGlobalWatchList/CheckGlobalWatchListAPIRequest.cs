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


namespace com.pb.identify.identifyRisk.Model.CheckGlobalWatchList
    {


       

        /// <summary>
        /// Input Record
        /// </summary>
        [DataContract(Name = "Row")]
        public class Record
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
            /// Gets or sets the AddressLine3.
            /// </summary>
            /// <value>
            /// The AddressLine3.
            /// </value>
            [DataMember]
            public string AddressLine3 { get; set; }
            /// <summary>
            /// Gets or sets the Citizenship.
            /// </summary>
            /// <value>
            /// The Citizenship.
            /// </value>
            [DataMember]
            public string Citizenship { get; set; }
            /// <summary>
            /// Gets or sets the Country.
            /// </summary>
            /// <value>
            /// The Country.
            /// </value>
            [DataMember]
            public string Country { get; set; }
            /// <summary>
            /// Gets or sets the DOB.
            /// </summary>
            /// <value>
            /// The DOB.
            /// </value>
            [DataMember]
            public string DOB { get; set; }
            /// <summary>
            /// Gets or sets the FirstName.
            /// </summary>
            /// <value>
            /// The FirstName.
            /// </value>
            [DataMember]
            public string FirstName { get; set; }
            /// <summary>
            /// Gets or sets the IDNumber.
            /// </summary>
            /// <value>
            /// The IDNumber.
            /// </value>
            [DataMember]
            public string IDNumber { get; set; }
            /// <summary>
            /// Gets or sets the LastName.
            /// </summary>
            /// <value>
            /// The LastName.
            /// </value>
            [DataMember]
            public string LastName { get; set; }
            /// <summary>
            /// Gets or sets the Name.
            /// </summary>
            /// <value>
            /// The Name.
            /// </value>
            [DataMember]
            public string Name { get; set; }
            /// <summary>
            /// Gets or sets the Nationality.
            /// </summary>
            /// <value>
            /// The Nationality.
            /// </value>
            [DataMember]
            public string Nationality { get; set; }
            /// <summary>
            /// Gets or sets the PlaceOfBirth.
            /// </summary>
            /// <value>
            /// The PlaceOfBirth.
            /// </value>
            [DataMember]
            public string PlaceOfBirth { get; set; }

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
            public Record(List<user_field> userfields, string addressline1 = "", String addressline2 = "", String addressline3 = "", String citizenship = "", String country = "", String dob = "", String firstname = "", String idnumber = "", String lastname = "", String name = "", String nationality = "", String placeofbirth = "")
            {
                if (addressline1 != "")
                AddressLine1 = addressline1;

                if (addressline2 != "")
                AddressLine2 = addressline2;

                if (addressline3 != "")
                AddressLine3 = addressline3;

                if (citizenship != "")
                Citizenship = citizenship;

                if (country != "")
                Country = country;

                if (dob != "")
                DOB = dob;

                if (firstname != "")
                FirstName = firstname;

                if (idnumber != "")
                IDNumber = idnumber;

                if (lastname != "")
                LastName = lastname;

                if (name != "")
                Name = name;

                if (nationality != "")
                Nationality = nationality;

                if (placeofbirth != "")
                PlaceOfBirth = placeofbirth;

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
    /// Request of CheckGlobalWatchListAPI
        /// </summary>
        [DataContract]
        public class CheckGlobalWatchListAPIRequest
        {
            
            /// <summary>
            /// Gets or sets the Input.
            /// </summary>
            /// <value>
            /// Input
            /// </value>
            [DataMember]
            public input Input { get; set; }
            public CheckGlobalWatchListAPIRequest(input liRow)
            {
                Input = liRow;
            }

        }
}
