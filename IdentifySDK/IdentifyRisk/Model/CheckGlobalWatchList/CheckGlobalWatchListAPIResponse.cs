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

namespace com.pb.identify.identifyRisk.Model.CheckGlobalWatchList
{

    /// <summary>
    /// Response of CheckGlobalWatchListAPI
    /// (List of output records)
    /// </summary>
    [DataContract]
    public class CheckGlobalWatchListAPIResponse
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
        /// Gets or sets the OverAllRiskLevel.
        /// </summary>
        /// <value>
        /// The OverAllRiskLevel.
        /// </value>
        [DataMember]

        public string OverAllRiskLevel { get; set; }

        /// <summary>
        /// Gets or sets the SanctionCountryIdentified.
        /// </summary>
        /// <value>
        /// The SanctionCountryIdentified.
        /// </value>
        [DataMember]

        public string SanctionedCountryIdentified { get; set; }

        /// <summary>
        /// Gets or sets the AddressLine1.
        /// </summary>
        /// <value>
        /// The AddressLine1.
        /// </value>
        [DataMember]

        public string AddressLine1 { get; set; }
        
        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        /// <value>
        /// The Country.
        /// </value>
        [DataMember]

        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        /// <value>
        /// The FirstName.
        /// </value>
        [DataMember]

        public string FirstName { get; set; }

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
        /// Gets or sets the EntryID.
        /// </summary>
        /// <value>
        /// The EntryID.
        /// </value>
        [DataMember]

        public string EntryID { get; set; }

        /// <summary>
        /// Gets or sets the InputFilteredFirstName.
        /// </summary>
        /// <value>
        /// The InputFilteredFirstName.
        /// </value>
        [DataMember]

        public string InputFilteredFirstName { get; set; }

        /// <summary>
        /// Gets or sets the InputFilteredLastName.
        /// </summary>
        /// <value>
        /// The InputFilteredLastName.
        /// </value>
        [DataMember]

        public string InputFilteredLastName { get; set; }

        /// <summary>
        /// Gets or sets the InputFilteredName.
        /// </summary>
        /// <value>
        /// The InputFilteredName.
        /// </value>
        [DataMember]

        public string InputFilteredName { get; set; }

        /// <summary>
        /// Gets or sets the InputFirstName.
        /// </summary>
        /// <value>
        /// The InputFirstName.
        /// </value>
        [DataMember]

        public string InputFirstName { get; set; }
        
        /// <summary>
        /// Gets or sets the InputLastName.
        /// </summary>
        /// <value>
        /// The InputLastName.
        /// </value>
        [DataMember]

        public string InputLastName { get; set; }

        /// <summary>
        /// Gets or sets the InputName.
        /// </summary>
        /// <value>
        /// The InputName.
        /// </value>
        [DataMember]

        public string InputName { get; set; }

        /// <summary>
        /// Gets or sets the ListType.
        /// </summary>
        /// <value>
        /// The ListType.
        /// </value>
        [DataMember]

        public string ListType { get; set; }

        /// <summary>
        /// Gets or sets the NameMatchIdentified.
        /// </summary>
        /// <value>
        /// The NameMatchIdentified.
        /// </value>
        [DataMember]

        public string NameMatchIdentified { get; set; }

        /// <summary>
        /// Gets or sets the NameProvided.
        /// </summary>
        /// <value>
        /// The NameProvided.
        /// </value>
        [DataMember]

        public string NameProvided { get; set; }

        /// <summary>
        /// Gets or sets the NameScore.
        /// </summary>
        /// <value>
        /// The NameScore.
        /// </value>
        [DataMember]

        public string NameScore { get; set; }


        /// <summary>
        /// Gets or sets the AddressProvided.
        /// </summary>
        /// <value>
        /// The AddressProvided.
        /// </value>
        [DataMember]

        public string AddressProvided { get; set; }

        /// <summary>
        /// Gets or sets the IDNumberProvided.
        /// </summary>
        /// <value>
        /// The IDNumberProvided.
        /// </value>
        [DataMember]

        public string IDNumberProvided { get; set; }

                
         /// <summary>
         /// Gets or sets the InputAddressLine1.
         /// </summary>
         /// <value>
         /// The InputAddressLine1.
         /// </value>
         [DataMember]

         public string InputAddressLine1 { get; set; }

        
         /// <summary>
         /// Gets or sets the InputAddressLine2.
         /// </summary>
         /// <value>
         /// The InputAddressLine2.
         /// </value>
         [DataMember]

         public string InputAddressLine2 { get; set; }

         /// <summary>
         /// Gets or sets the InputAddressLine3.
         /// </summary>
         /// <value>
         /// The InputAddressLine3.
         /// </value>
         [DataMember]

         public string InputAddressLine3 { get; set; }


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
         /// Gets or sets the AddressScore.
         /// </summary>
         /// <value>
         /// The AddressScore.
         /// </value>
         [DataMember]

         public string AddressScore { get; set; }

         /// <summary>
         /// Gets or sets the AddressMatchIdentified.
         /// </summary>
         /// <value>
         /// The AddressMatchIdentified.
         /// </value>
         [DataMember]

         public string AddressMatchIdentified { get; set; }

         
         /// <summary>
         /// Gets or sets the InputCountry.
         /// </summary>
         /// <value>
         /// The InputCountry.
         /// </value>
         [DataMember]

         public string InputCountry { get; set; }

         

         /// <summary>
         /// Gets or sets the InputIDNumber.
         /// </summary>
         /// <value>
         /// The InputIDNumber.
         /// </value>
         [DataMember]

         public string InputIDNumber { get; set; }

         /// <summary>
         /// Gets or sets the IDNumber.
         /// </summary>
         /// <value>
         /// The IDNumber.
         /// </value>
         [DataMember]

         public string IDNumber { get; set; }

         /// <summary>
         /// Gets or sets the IDNumberScore.
         /// </summary>
         /// <value>
         /// The IDNumberScore.
         /// </value>
         [DataMember]

         public string IDNumberScore { get; set; }

         /// <summary>
         /// Gets or sets the IDNumberMatchIdentified.
         /// </summary>
         /// <value>
         /// The IDNumberMatchIdentified.
         /// </value>
         [DataMember]

         public string IDNumberMatchIdentified { get; set; }
         
         /// <summary>
         /// Gets or sets the InputPlaceOfBirth.
         /// </summary>
         /// <value>
         /// The InputPlaceOfBirth.
         /// </value>
         [DataMember]

         public string InputPlaceOfBirth { get; set; }
         
         /// <summary>
         /// Gets or sets the PlaceOfBirth.
         /// </summary>
         /// <value>
         /// The PlaceOfBirth.
         /// </value>
         [DataMember]

         public string PlaceOfBirth { get; set; }

        /// <summary>
         /// Gets or sets the PlaceOfBirthScore.
         /// </summary>
         /// <value>
         /// The PlaceOfBirthScore.
         /// </value>
         [DataMember]

         public string PlaceOfBirthScore { get; set; }

        /// <summary>
         /// Gets or sets the PlaceOfBirthMatchIdentified.
         /// </summary>
         /// <value>
         /// The PlaceOfBirthMatchIdentified.
         /// </value>
         [DataMember]

         public string PlaceOfBirthMatchIdentified { get; set; }

        /// <summary>
         /// Gets or sets the PlaceOfBirthProvided.
         /// </summary> 
         /// <value>
         /// The PlaceOfBirthProvided.
         /// </value>
         [DataMember]

         public string PlaceOfBirthProvided { get; set; }

         /// <summary>
         /// Gets or sets the InputDOB.
         /// </summary>
         /// <value>
         /// The InputDOB.
         /// </value>
         [DataMember]

         public string InputDOB { get; set; }

         /// <summary>
         /// Gets or sets the DOB.
         /// </summary>
         /// <value>
         /// The DOB.
         /// </value>
         [DataMember]

         public string DOB { get; set; }

         /// <summary>
         /// Gets or sets the DOBScore.
         /// </summary>
         /// <value>
         /// The DOBScore.
         /// </value>
         [DataMember]

         public string DOBScore { get; set; }


         /// <summary>
         /// Gets or sets the DOBMatchIdentified.
         /// </summary>
         /// <value>
         /// The DOBMatchIdentified.
         /// </value>
         [DataMember]

         public string DOBMatchIdentified { get; set; }


         /// <summary>
         /// Gets or sets the DOBProvided.
         /// </summary>
         /// <value>
         /// The DOBProvided.
         /// </value>
         [DataMember]

         public string DOBProvided { get; set; }
        
        
         /// <summary>
         /// Gets or sets the InputCitizenship.
         /// </summary>
         /// <value>
         /// The InputCitizenship.
         /// </value>
         [DataMember]

         public string InputCitizenship { get; set; }

         /// <summary>
         /// Gets or sets the Citizenship.
         /// </summary>
         /// <value>
         /// The Citizenship.
         /// </value>
         [DataMember]

         public string Citizenship { get; set; }
         /// <summary>
         /// Gets or sets the CitizenshipScore.
         /// </summary>
         /// <value>
         /// The CitizenshipScore.
         /// </value>
         [DataMember]

         public string CitizenshipScore { get; set; }
         /// <summary>
         /// Gets or sets the CitizenshipMatchIdentified.
         /// </summary>
         /// <value>
         /// The CitizenshipMatchIdentified.
         /// </value>
         [DataMember]

         public string CitizenshipMatchIdentified { get; set; }
         /// <summary>
         /// Gets or sets the CitizenshipProvided.
         /// </summary>
         /// <value>
         /// The CitizenshipProvided.
         /// </value>
         [DataMember]

         public string CitizenshipProvided { get; set; }

         /// <summary>
         /// Gets or sets the InputNationality.
         /// </summary>
         /// <value>
         /// The InputNationality.
         /// </value>
         [DataMember]

         public string InputNationality { get; set; }
         /// <summary>
         /// Gets or sets the Nationality.
         /// </summary>
         /// <value>
         /// The Nationality.
         /// </value>
         [DataMember]

         public string Nationality { get; set; }
         /// <summary>
         /// Gets or sets the NationalityScore.
         /// </summary>
         /// <value>
         /// The NationalityScore.
         /// </value>
         [DataMember]

         public string NationalityScore { get; set; }
         /// <summary>
         /// Gets or sets the NationalityMatchIdentified.
         /// </summary>
         /// <value>
         /// The NationalityMatchIdentified.
         /// </value>
         [DataMember]

         public string NationalityMatchIdentified { get; set; }

         /// <summary>
         /// Gets or sets the NationalityProvided.
         /// </summary>
         /// <value>
         /// The NationalityProvided.
         /// </value>
         [DataMember]

         public string NationalityProvided { get; set; }

         
        

         /// <summary>
         /// Gets or sets the City.
         /// </summary>
         /// <value>
         /// The City.
         /// </value>
         [DataMember]

         public string City { get; set; }

         /// <summary>
         /// Gets or sets the FirmName.
         /// </summary>
         /// <value>
         /// The FirmName.
         /// </value>
         [DataMember]

         public string FirmName { get; set; }

         /// <summary>
         /// Gets or sets the MatchStatus.
         /// </summary>
         /// <value>
         /// The MatchStatus.
         /// </value>

         [DataMember(Name = "MatchStatus")]
         public string MatchStatus { get; set; }
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
