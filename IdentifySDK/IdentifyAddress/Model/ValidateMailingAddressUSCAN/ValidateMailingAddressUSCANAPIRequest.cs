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
using com.pb.identify.identifyAddress.Model.Common;

namespace com.pb.identify.identifyAddress.Model.ValidateMailingAddressUSCAN
{
        /// <summary>
        /// options class
        /// </summary>
        [DataContract]
        public class options
        {
            /// <summary>
            /// Gets or sets the OutputAddressBlocks.
            /// </summary>
            /// <value>
            /// The OutputAddressBlocks.
            /// </value>
            [DataMember]
            public string OutputAddressBlocks { get; set; }

            /// <summary>
            /// Gets or sets the OutputCountryFormat.
            /// </summary>
            /// <value>
            /// The OutputCountryFormat.
            /// </value>
            [DataMember]
            public string OutputCountryFormat { get; set; }

            /// <summary>
            /// Gets or sets the KeepMultimatch.
            /// </summary>
            /// <value>
            /// The KeepMultimatch.
            /// </value>
            [DataMember]
            public string KeepMultimatch { get; set; }

            /// <summary>
            /// Gets or sets the OutputCasing.
            /// </summary>
            /// <value>
            /// The OutputCasing.
            /// </value>
            [DataMember]
            public string OutputCasing { get; set; }

            /// <summary>
            /// Gets or sets the MaximumResults.
            /// </summary>
            /// <value>
            /// The MaximumResults.
            /// </value>
            [DataMember]
            public string MaximumResults { get; set; }

            /// <summary>
            /// Gets or sets the OutputRecordType.
            /// </summary>
            /// <value>
            /// The OutputRecordType.
            /// </value>
            [DataMember]
            public string OutputRecordType { get; set; }

            /// <summary>
            /// Gets or sets the OutputFieldLevelReturnCodes.
            /// </summary>
            /// <value>
            /// The OutputFieldLevelReturnCodes.
            /// </value>
            [DataMember]
            public string OutputFieldLevelReturnCodes { get; set; }

            /// <summary>
            /// Gets or sets the DPVDetermineNoStat.
            /// </summary>
            /// <value>
            /// The DPVDetermineNoStat.
            /// </value>
            [DataMember]
            public string DPVDetermineNoStat { get; set; }

            /// <summary>
            /// Gets or sets the StreetMatchingStrictness.
            /// </summary>
            /// <value>
            /// The StreetMatchingStrictness.
            /// </value>
            [DataMember]
            public string StreetMatchingStrictness { get; set; }

            /// <summary>
            /// Gets or sets the CanFrenchApartmentLabel.
            /// </summary>
            /// <value>
            /// The CanFrenchApartmentLabel.
            /// </value>
            [DataMember]
            public string CanFrenchApartmentLabel { get; set; }

            /// <summary>
            /// Gets or sets the OutputAbbreviatedAlias.
            /// </summary>
            /// <value>
            /// The OutputAbbreviatedAlias.
            /// </value>
            [DataMember]
            public string OutputAbbreviatedAlias { get; set; }

            /// <summary>
            /// Gets or sets the DPVSuccessfulStatusCondition.
            /// </summary>
            /// <value>
            /// The DPVSuccessfulStatusCondition.
            /// </value>
            [DataMember]
            public string DPVSuccessfulStatusCondition { get; set; }

            /// <summary>
            /// Gets or sets the StandardAddressPMBLine.
            /// </summary>
            /// <value>
            /// The StandardAddressPMBLine.
            /// </value>
            [DataMember]
            public string StandardAddressPMBLine { get; set; }

            /// <summary>
            /// Gets or sets the FirmMatchingStrictness.
            /// </summary>
            /// <value>
            /// The FirmMatchingStrictness.
            /// </value>
            [DataMember]
            public string FirmMatchingStrictness { get; set; }

            /// <summary>
            /// Gets or sets the CanRuralRouteFormat.
            /// </summary>
            /// <value>
            /// The CanRuralRouteFormat.
            /// </value>
            [DataMember]
            public string CanRuralRouteFormat { get; set; }

            /// <summary>
            /// Gets or sets the CanPreferHouseNum.
            /// </summary>
            /// <value>
            /// The CanPreferHouseNum.
            /// </value>
            [DataMember]
            public string CanPreferHouseNum { get; set; }

            /// <summary>
            /// Gets or sets the OutputPreferredAlias.
            /// </summary>
            /// <value>
            /// The OutputPreferredAlias.
            /// </value>
            [DataMember]
            public string OutputPreferredAlias { get; set; }

            /// <summary>
            /// Gets or sets the DirectionalMatchingStrictness.
            /// </summary>
            /// <value>
            /// The DirectionalMatchingStrictness.
            /// </value>
            [DataMember]
            public string DirectionalMatchingStrictness { get; set; }

            /// <summary>
            /// Gets or sets the ExtractFirm.
            /// </summary>
            /// <value>
            /// The ExtractFirm.
            /// </value>
            [DataMember]
            public string ExtractFirm { get; set; }

            /// <summary>
            /// Gets or sets the FailOnCMRAMatch.
            /// </summary>
            /// <value>
            /// The FailOnCMRAMatch.
            /// </value>
            [DataMember]
            public string FailOnCMRAMatch { get; set; }

            /// <summary>
            /// Gets or sets the CanNonCivicFormat.
            /// </summary>
            /// <value>
            /// The CanNonCivicFormat.
            /// </value>
            [DataMember]
            public string CanNonCivicFormat { get; set; }

            /// <summary>
            /// Gets or sets the CanSSLVRFlg.
            /// </summary>
            /// <value>
            /// The CanSSLVRFlg.
            /// </value>
            [DataMember]
            public string CanSSLVRFlg { get; set; }

            /// <summary>
            /// Gets or sets the OutputStreetNameAlias.
            /// </summary>
            /// <value>
            /// The OutputStreetNameAlias.
            /// </value>
            [DataMember]
            public string OutputStreetNameAlias { get; set; }

            /// <summary>
            /// Gets or sets the PerformEWS.
            /// </summary>
            /// <value>
            /// The PerformEWS.
            /// </value>
            [DataMember]
            public string PerformEWS { get; set; }

            /// <summary>
            /// Gets or sets the CanOutputCityFormat.
            /// </summary>
            /// <value>
            /// The CanOutputCityFormat.
            /// </value>
            [DataMember]
            public string CanOutputCityFormat { get; set; }

            /// <summary>
            /// Gets or sets the DualAddressLogic.
            /// </summary>
            /// <value>
            /// The DualAddressLogic.
            /// </value>
            [DataMember]
            public string DualAddressLogic { get; set; }

            /// <summary>
            /// Gets or sets the PerformSuiteLink.
            /// </summary>
            /// <value>
            /// The PerformSuiteLink.
            /// </value>
            [DataMember]
            public string PerformSuiteLink { get; set; }

            /// <summary>
            /// Gets or sets the CanStandardAddressFormat.
            /// </summary>
            /// <value>
            /// The CanStandardAddressFormat.
            /// </value>
            [DataMember]
            public string CanStandardAddressFormat { get; set; }

            /// <summary>
            /// Gets or sets the OutputPreferredCity.
            /// </summary>
            /// <value>
            /// The OutputPreferredCity.
            /// </value>
            [DataMember]
            public string OutputPreferredCity { get; set; }

            /// <summary>
            /// Gets or sets the OutputMultinationalCharacters.
            /// </summary>
            /// <value>
            /// The OutputMultinationalCharacters.
            /// </value>
            [DataMember]
            public string OutputMultinationalCharacters { get; set; }

            /// <summary>
            /// Gets or sets the CanDeliveryOfficeFormat.
            /// </summary>
            /// <value>
            /// The CanDeliveryOfficeFormat.
            /// </value>
            [DataMember]
            public string CanDeliveryOfficeFormat { get; set; }

            /// <summary>
            /// Gets or sets the PerformLACSLink.
            /// </summary>
            /// <value>
            /// The PerformLACSLink.
            /// </value>
            [DataMember]
            public string PerformLACSLink { get; set; }

            /// <summary>
            /// Gets or sets the CanDualAddressLogic.
            /// </summary>
            /// <value>
            /// The CanDualAddressLogic.
            /// </value>
            [DataMember]
            public string CanDualAddressLogic { get; set; }

            /// <summary>
            /// Gets or sets the ExtractUrb.
            /// </summary>
            /// <value>
            /// The ExtractUrb.
            /// </value>
            [DataMember]
            public string ExtractUrb { get; set; }

            /// <summary>
            /// Gets or sets the StandardAddressFormat.
            /// </summary>
            /// <value>
            /// The StandardAddressFormat.
            /// </value>
            [DataMember]
            public string StandardAddressFormat { get; set; }


            /// <summary>
            /// Gets or sets the CanFrenchFormat.
            /// </summary>
            /// <value>
            /// The CanFrenchFormat.
            /// </value>
            [DataMember]
            public string CanFrenchFormat { get; set; }


            /// <summary>
            /// Gets or sets the DPVDetermineVacancy.
            /// </summary>
            /// <value>
            /// The DPVDetermineVacancy.
            /// </value>
            [DataMember]
            public string DPVDetermineVacancy { get; set; }


            /// <summary>
            /// Gets or sets the CanEnglishApartmentLabel.
            /// </summary>
            /// <value>
            /// The CanEnglishApartmentLabel.
            /// </value>
            [DataMember]
            public string CanEnglishApartmentLabel { get; set; }


            /// <summary>
            /// Gets or sets the SuppressZplusPhantomCarrierR777.
            /// </summary>
            /// <value>
            /// The SuppressZplusPhantomCarrierR777.
            /// </value>
            [DataMember]
            public string SuppressZplusPhantomCarrierR777 { get; set; }


            /// <summary>
            /// Gets or sets the CanOutputCityAlias.
            /// </summary>
            /// <value>
            /// The CanOutputCityAlias.
            /// </value>
            [DataMember]
            public string CanOutputCityAlias { get; set; }


            /// <summary>
            /// Gets or sets the OutputShortCityName.
            /// </summary>
            /// <value>
            /// The OutputShortCityName.
            /// </value>
            [DataMember]
            public string OutputShortCityName { get; set; }

            /// <summary>
            /// Constructor sets the default value for options.
            /// </summary>
            public options()
            {
                DPVDetermineNoStat = "N";
                StreetMatchingStrictness = "M";
                CanFrenchApartmentLabel = "Appartement";
                OutputAbbreviatedAlias = "N";
                DPVSuccessfulStatusCondition = "A";
                StandardAddressPMBLine = "N";
                FirmMatchingStrictness = "M";
                CanRuralRouteFormat = "A";
                CanPreferHouseNum = "N";
                OutputPreferredAlias = "N";
                OutputAddressBlocks = "Y";
                DirectionalMatchingStrictness = "M";
                ExtractFirm = "N";
                FailOnCMRAMatch = "N";
                CanNonCivicFormat = "A";
                CanSSLVRFlg = "N";
                OutputStreetNameAlias = "Y";
                PerformEWS = "N";
                CanOutputCityFormat = "D";
                DualAddressLogic = "N";
                PerformSuiteLink = "N";
                CanStandardAddressFormat = "D";
                OutputPreferredCity = "Z";
                KeepMultimatch = "N";
                OutputMultinationalCharacters = "N";
                CanDeliveryOfficeFormat = "I";
                PerformLACSLink = "Y";
                CanDualAddressLogic = "D";
                ExtractUrb = "N";
                OutputCasing = "M";
                StandardAddressFormat = "C";
                MaximumResults = "10";
                CanFrenchFormat = "C";
                DPVDetermineVacancy = "N";
                CanEnglishApartmentLabel = "Apt";
                OutputCountryFormat = "E";
                SuppressZplusPhantomCarrierR777 = "N";
                OutputFieldLevelReturnCodes = "N";
                CanOutputCityAlias = "N";
                OutputRecordType = "A";
                OutputShortCityName = "N";
            }
        }

        /// <summary>
        /// Input Address
        /// </summary>
        [DataContract(Name = "Row")]
        public class Address : AddressInput
        {
            /// <summary>
            /// Gets or sets the AddressLine3.
            /// </summary>
            /// <value>
            /// The AddressLine3.
            /// </value>
            [DataMember]
            public string AddressLine3 { get; set; }

            /// <summary>
            /// Gets or sets the AddressLine4.
            /// </summary>
            /// <value>
            /// The AddressLine4.
            /// </value>
            [DataMember]
            public string AddressLine4 { get; set; }

            /// <summary>
            /// Gets or sets the CanLanguage.
            /// </summary>
            /// <value>
            /// The CanLanguage.
            /// </value>
            [DataMember]
            public string CanLanguage { get; set; }

            /// <summary>
            /// Address Constructor .
            /// </summary>
            public Address(List<user_field> userfields, string country = "", String addressline1 = "", String addressline2 = "",
                String addressline3 = "", String addressline4 = "", String canlanguage = "", 
                String city = "", String stateorprovince = "", String postalCode = "", String firmname = "")
            {
                AddressLine1 = addressline1;
                AddressLine2 = addressline2;
                AddressLine3 = addressline3;
                AddressLine4 = addressline4;
                CanLanguage  = canlanguage;
                City = city;
                StateProvince = stateorprovince;
                Country = country;
                PostalCode = postalCode;
                FirmName = firmname;

                user_fields = userfields;
            }
        }

        /// <summary>
        /// List of Addresses
        /// </summary>
        [DataContract]
        public class input
        {
            /// <summary>
            /// Gets or sets the List of Addresses.
            /// </summary>
            /// <value>
            /// List of Addresses.
            /// </value>
            [DataMember(Name = "Row")]
            public List<Address> AddressList { get; set; }
        }

        /// <summary>
        /// Request of ValidateMailingAddressUSCANAPI
        /// </summary>
        [DataContract]
        public class ValidateMailingAddressUSCANAPIRequest
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

            public ValidateMailingAddressUSCANAPIRequest(input liRow, options optionparam)
            {
                Input = liRow;
                options = optionparam;
            }
        }
}