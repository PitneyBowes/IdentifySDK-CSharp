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

namespace com.pb.identify.identifyAddress.Model.ValidateMailingAddressUSCAN
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
        /// Gets or sets the AddressFormat.
        /// </summary>
        /// <value>
        /// The AddressFormat.
        /// </value>
        [DataMember]
        public string AddressFormat { get; set; }

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
        /// Gets or sets the AddressRecordResult.
        /// </summary>
        /// <value>
        /// The AddressRecordResult.
        /// </value>
        [DataMember(Name = "AddressRecord.Result")]
        public string AddressRecordResult { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentLabel.
        /// </summary>
        /// <value>
        /// The ApartmentLabel.
        /// </value>
        [DataMember]
        public string ApartmentLabel { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentLabelInput.
        /// </summary>
        /// <value>
        /// The ApartmentLabelInput.
        /// </value>
        [DataMember(Name = "ApartmentLabel.Input")]
        public string ApartmentLabelInput { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentLabelResult.
        /// </summary>
        /// <value>
        /// The ApartmentLabelResult.
        /// </value>
        [DataMember(Name = "ApartmentLabel.Result")]
        public string ApartmentLabelResult { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentNumber.
        /// </summary>
        /// <value>
        /// The ApartmentNumber.
        /// </value>
        [DataMember]
        public string ApartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentNumberInput.
        /// </summary>
        /// <value>
        /// The ApartmentNumberInput.
        /// </value>
        [DataMember(Name = "ApartmentNumber.Input")]
        public string ApartmentNumberInput { get; set; }

        /// <summary>
        /// Gets or sets the ApartmentNumberResult.
        /// </summary>
        /// <value>
        /// The ApartmentNumberResult.
        /// </value>
        [DataMember(Name = "ApartmentNumber.Result")]
        public string ApartmentNumberResult { get; set; }

        /// <summary>
        /// Gets or sets the CityInput.
        /// </summary>
        /// <value>
        /// The CityInput.
        /// </value>
        [DataMember(Name = "City.Input")]
        public string CityInput { get; set; }

        /// <summary>
        /// Gets or sets the CityResult.
        /// </summary>
        /// <value>
        /// The CityResult.
        /// </value>
        [DataMember(Name = "City.Result")]
        public string CityResult { get; set; }

        /// <summary>
        /// Gets or sets the Confidence.
        /// </summary>
        /// <value>
        /// The Confidence.
        /// </value>
        [DataMember]
        public string Confidence { get; set; }

        /// <summary>
        /// Gets or sets the CountryInput.
        /// </summary>
        /// <value>
        /// The CountryInput.
        /// </value>
        [DataMember(Name = "Country.Input")]
        public string CountryInput { get; set; }

        /// <summary>
        /// Gets or sets the CountryResult.
        /// </summary>
        /// <value>
        /// The CountryResult.
        /// </value>
        [DataMember(Name = "Country.Result")]
        public string CountryResult { get; set; }

        /// <summary>
        /// Gets or sets the CountryLevel.
        /// </summary>
        /// <value>
        /// The CountryLevel.
        /// </value>
        [DataMember]
        public string CountryLevel { get; set; }

        /// <summary>
        /// Gets or sets the FirmNameInput.
        /// </summary>
        /// <value>
        /// The FirmNameInput.
        /// </value>
        [DataMember(Name = "FirmName.Input")]
        public string FirmNameInput { get; set; }

        /// <summary>
        /// Gets or sets the FirmNameResult.
        /// </summary>
        /// <value>
        /// The FirmNameResult.
        /// </value>
        [DataMember(Name = "FirmName.Result")]
        public string FirmNameResult { get; set; }

        /// <summary>
        /// Gets or sets the HouseNumber.
        /// </summary>
        /// <value>
        /// The HouseNumber.
        /// </value>
        [DataMember]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the HouseNumberInput.
        /// </summary>
        /// <value>
        /// The HouseNumberInput.
        /// </value>
        [DataMember(Name = "HouseNumber.Input")]
        public string HouseNumberInput { get; set; }

        /// <summary>
        /// Gets or sets the HouseNumberResult.
        /// </summary>
        /// <value>
        /// The HouseNumberResult.
        /// </value>
        [DataMember(Name = "HouseNumber.Result")]
        public string HouseNumberResult { get; set; }

        /// <summary>
        /// Gets or sets the LeadingDirectional.
        /// </summary>
        /// <value>
        /// The LeadingDirectional.
        /// </value>
        [DataMember]
        public string LeadingDirectional { get; set; }

        /// <summary>
        /// Gets or sets the LeadingDirectionalInput.
        /// </summary>
        /// <value>
        /// The LeadingDirectionalInput.
        /// </value>
        [DataMember(Name = "LeadingDirectional.Input")]
        public string LeadingDirectionalInput { get; set; }

        /// <summary>
        /// Gets or sets the LeadingDirectionalResult.
        /// </summary>
        /// <value>
        /// The LeadingDirectionalResult.
        /// </value>
        [DataMember(Name = "LeadingDirectional.Result")]
        public string LeadingDirectionalResult { get; set; }

        /// <summary>
        /// Gets or sets the MultipleMatches.
        /// </summary>
        /// <value>
        /// The MultipleMatches.
        /// </value>
        [DataMember]
        public string MultipleMatches { get; set; }

        /// <summary>
        /// Gets or sets the POBox.
        /// </summary>
        /// <value>
        /// The POBox.
        /// </value>
        [DataMember]
        public string POBox { get; set; }

        /// <summary>
        /// Gets or sets the POBoxInput.
        /// </summary>
        /// <value>
        /// The POBoxInput.
        /// </value>
        [DataMember(Name = "POBox.Input")]
        public string POBoxInput { get; set; }

        /// <summary>
        /// Gets or sets the POBoxResult.
        /// </summary>
        /// <value>
        /// The POBoxResult.
        /// </value>
        [DataMember(Name = "POBox.Result")]
        public string POBoxResult { get; set; }

        /// <summary>
        /// Gets or sets the PostalCodeInput.
        /// </summary>
        /// <value>
        /// The PostalCodeInput.
        /// </value>
        [DataMember(Name = "PostalCode.Input")]
        public string PostalCodeInput { get; set; }

        /// <summary>
        /// Gets or sets the PostalCodeResult.
        /// </summary>
        /// <value>
        /// The PostalCodeResult.
        /// </value>
        [DataMember(Name = "PostalCode.Result")]
        public string PostalCodeResult { get; set; }

        /// <summary>
        /// Gets or sets the PostalCodeSource.
        /// </summary>
        /// <value>
        /// The PostalCodeSource.
        /// </value>
        [DataMember(Name = "PostalCode.Source")]
        public string PostalCodeSource { get; set; }

        /// <summary>
        /// Gets or sets the PostalCodeType.
        /// </summary>
        /// <value>
        /// The PostalCodeType.
        /// </value>
        [DataMember(Name = "PostalCode.Type")]
        public string PostalCodeType { get; set; }

        /// <summary>
        /// Gets or sets the PostalCodeCityResult.
        /// </summary>
        /// <value>
        /// The PostalCodeCityResult.
        /// </value>
        [DataMember(Name = "PostalCodeCity.Result")]
        public string PostalCodeCityResult { get; set; }

        /// <summary>
        /// Gets or sets the PrivateMailbox.
        /// </summary>
        /// <value>
        /// The PrivateMailbox.
        /// </value>
        [DataMember]
        public string PrivateMailbox { get; set; }

        /// <summary>
        /// Gets or sets the PrivateMailboxInput.
        /// </summary>
        /// <value>
        /// The PrivateMailboxInput.
        /// </value>
        [DataMember(Name = "PrivateMailbox.Input")]
        public string PrivateMailboxInput { get; set; }

        /// <summary>
        /// Gets or sets the PrivateMailboxType.
        /// </summary>
        /// <value>
        /// The PrivateMailboxType.
        /// </value>
        [DataMember(Name = "PrivateMailbox.Type")]
        public string PrivateMailboxType { get; set; }

        /// <summary>
        /// Gets or sets the PrivateMailboxTypeInput.
        /// </summary>
        /// <value>
        /// The PrivateMailboxTypeInput
        /// </value>
        [DataMember(Name = "PrivateMailbox.Type.Input")]
        public string PrivateMailboxTypeInput { get; set; }

        /// <summary>
        /// Gets or sets the RecordType.
        /// </summary>
        /// <value>
        /// The RecordType.
        /// </value>
        [DataMember]
        public string RecordType { get; set; }

        /// <summary>
        /// Gets or sets the RecordTypeDefault.
        /// </summary>
        /// <value>
        /// The RecordTypeDefault.
        /// </value>
        [DataMember(Name = "RecordType.Default")]
        public string RecordTypeDefault { get; set; }

        /// <summary>
        /// Gets or sets the RRHC.
        /// </summary>
        /// <value>
        /// The RRHC.
        /// </value>
        [DataMember]
        public string RRHC { get; set; }

        /// <summary>
        /// Gets or sets the RRHCInput.
        /// </summary>
        /// <value>
        /// The RRHCInput.
        /// </value>
        [DataMember(Name = "RRHC.Input")]
        public string RRHCInput { get; set; }

        /// <summary>
        /// Gets or sets the RRHCResult.
        /// </summary>
        /// <value>
        /// The RRHCResult.
        /// </value>
        [DataMember(Name = "RRHC.Result")]
        public string RRHCResult { get; set; }

        /// <summary>
        /// Gets or sets the RRHCType.
        /// </summary>
        /// <value>
        /// The RRHCType.
        /// </value>
        [DataMember(Name = "RRHC.Type")]
        public string RRHCType { get; set; }

        /// <summary>
        /// Gets or sets the StateProvinceInput.
        /// </summary>
        /// <value>
        /// The StateProvinceInput.
        /// </value>
        [DataMember(Name = "StateProvince.Input")]
        public string StateProvinceInput { get; set; }

        /// <summary>
        /// Gets or sets the StateProvinceResult.
        /// </summary>
        /// <value>
        /// The StateProvinceResult.
        /// </value>
        [DataMember(Name = "StateProvince.Result")]
        public string StateProvinceResult { get; set; }

        /// <summary>
        /// Gets or sets the StreetResult.
        /// </summary>
        /// <value>
        /// The StreetResult.
        /// </value>
        [DataMember(Name = "Street.Result")]
        public string StreetResult { get; set; }

        /// <summary>
        /// Gets or sets the StreetName.
        /// </summary>
        /// <value>
        /// The StreetName.
        /// </value>
        [DataMember]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets the StreetNameAliasType.
        /// </summary>
        /// <value>
        /// The AliasType.
        /// </value>
        [DataMember(Name = "StreetName.Alias.Type")]
        public string StreetNameAliasType { get; set; }

        /// <summary>
        /// Gets or sets the StreetNameInput.
        /// </summary>
        /// <value>
        /// The StreetNameInput.
        /// </value>
        [DataMember(Name = "StreetName.Input")]
        public string StreetNameInput { get; set; }

        /// <summary>
        /// Gets or sets the StreetNameResult.
        /// </summary>
        /// <value>
        /// The StreetNameResult.
        /// </value>
        [DataMember(Name = "StreetName.Result")]
        public string StreetNameResult { get; set; }

        /// <summary>
        /// Gets or sets the StreetNameAbbreviatedAliasResult.
        /// </summary>
        /// <value>
        /// The StreetNameAbbreviatedAliasResult.
        /// </value>
        [DataMember(Name = "StreetNameAbbreviatedAlias.Result")]
        public string StreetNameAbbreviatedAliasResult { get; set; }

        /// <summary>
        /// Gets or sets the StreetNamePreferredAliasResult.
        /// </summary>
        /// <value>
        /// The StreetNamePreferredAliasResult.
        /// </value>
        [DataMember(Name = "StreetNamePreferredAlias.Result")]
        public string StreetNamePreferredAliasResult { get; set; }

        /// <summary>
        /// Gets or sets the StreetSuffix.
        /// </summary>
        /// <value>
        /// The StreetSuffix.
        /// </value>
        [DataMember]
        public string StreetSuffix { get; set; }

        /// <summary>
        /// Gets or sets the StreetSuffixInput.
        /// </summary>
        /// <value>
        /// The StreetSuffixInput.
        /// </value>
        [DataMember(Name = "StreetSuffix.Input")]
        public string StreetSuffixInput { get; set; }

        /// <summary>
        /// Gets or sets the StreetSuffixResult.
        /// </summary>
        /// <value>
        /// The StreetSuffixResult.
        /// </value>
        [DataMember(Name = "StreetSuffix.Result")]
        public string StreetSuffixResult { get; set; }

        /// <summary>
        /// Gets or sets the TrailingDirectional.
        /// </summary>
        /// <value>
        /// The TrailingDirectional.
        /// </value>
        [DataMember]
        public string TrailingDirectional { get; set; }

        /// <summary>
        /// Gets or sets the TrailingDirectionalInput.
        /// </summary>
        /// <value>
        /// The TrailingDirectionalInput.
        /// </value>
        [DataMember(Name = "TrailingDirectional.Input")]
        public string TrailingDirectionalInput { get; set; }

        /// <summary>
        /// Gets or sets the TrailingDirectionalResult.
        /// </summary>
        /// <value>
        /// The TrailingDirectionalResult.
        /// </value>
        [DataMember(Name = "TrailingDirectional.Result")]
        public string TrailingDirectionalResult { get; set; }

        /// <summary>
        /// Gets or sets the MatchScore.
        /// </summary>
        /// <value>
        /// The MatchScore.
        /// </value>
        [DataMember]
        public string MatchScore { get; set; }

        /// <summary>
        /// Gets or sets the USLACS.
        /// </summary>
        /// <value>
        /// The USLACS.
        /// </value>
        [DataMember]
        public string USLACS { get; set; }

        /// <summary>
        /// Gets or sets the USLACSReturnCode.
        /// </summary>
        /// <value>
        /// The USLACSReturnCode.
        /// </value>
        [DataMember(Name = "USLACSReturnCode")]
        public string USLACSReturnCode { get; set; }

        /// <summary>
        /// Gets or sets the RDI.
        /// </summary>
        /// <value>
        /// The RDI.
        /// </value>
        [DataMember]
        public string RDI { get; set; }

        /// <summary>
        /// Gets or sets the CMRA.
        /// </summary>
        /// <value>
        /// The CMRA.
        /// </value>
        [DataMember]
        public string CMRA { get; set; }

        /// <summary>
        /// Gets or sets the DPV.
        /// </summary>
        /// <value>
        /// The DPV.
        /// </value>
        [DataMember]
        public string DPV { get; set; }

        /// <summary>
        /// Gets or sets the DPVFootnote.
        /// </summary>
        /// <value>
        /// The DPVFootnote.
        /// </value>
        [DataMember]
        public string DPVFootnote { get; set; }

        /// <summary>
        /// Gets or sets the SuiteLinkReturnCode.
        /// </summary>
        /// <value>
        /// The SuiteLinkReturnCode.
        /// </value>
        [DataMember]
        public string SuiteLinkReturnCode { get; set; }

        /// <summary>
        /// Gets or sets the SuiteLinkMatchCode.
        /// </summary>
        /// <value>
        /// The SuiteLinkMatchCode.
        /// </value>
        [DataMember]
        public string SuiteLinkMatchCode { get; set; }

        /// <summary>
        /// Gets or sets the SuiteLinkFidelity.
        /// </summary>
        /// <value>
        /// The SuiteLinkFidelity.
        /// </value>
        [DataMember]
        public string SuiteLinkFidelity { get; set; }

        /// <summary>
        /// Gets or sets the USBCCheckDigit.
        /// </summary>
        /// <value>
        /// The USBCCheckDigit.
        /// </value>
        [DataMember]
        public string USBCCheckDigit { get; set; }

        /// <summary>
        /// Gets or sets the PostalBarCode.
        /// </summary>
        /// <value>
        /// The PostalBarCode.
        /// </value>
        [DataMember]
        public string PostalBarCode { get; set; }

        /// <summary>
        /// Gets or sets the USCarrierRouteCode.
        /// </summary>
        /// <value>
        /// The USCarrierRouteCode.
        /// </value>
        [DataMember]
        public string USCarrierRouteCode { get; set; }

        /// <summary>
        /// Gets or sets the USFIPSCountyNumber.
        /// </summary>
        /// <value>
        /// The USFIPSCountyNumber.
        /// </value>
        [DataMember]
        public string USFIPSCountyNumber { get; set; }
 
        /// <summary>
        /// Gets or sets the USCountyName.
        /// </summary>
        /// <value>
        /// The USCountyName.
        /// </value>
        [DataMember]
        public string USCountyName { get; set; }

        /// <summary>
        /// Gets or sets the USCongressionalDistrict.
        /// </summary>
        /// <value>
        /// The USCongressionalDistrict.
        /// </value>
        [DataMember]
        public string USCongressionalDistrict { get; set; }

        /// <summary>
        /// Gets or sets the USAltAddr.
        /// </summary>
        /// <value>
        /// The USAltAddr.
        /// </value>
        [DataMember]
        public string USAltAddr { get; set; }

        /// <summary>
        /// Gets or sets the USLastLineNumber.
        /// </summary>
        /// <value>
        /// The USLastLineNumber.
        /// </value>
        [DataMember]
        public string USLastLineNumber { get; set; }

        /// <summary>
        /// Gets or sets the USFinanceNumber.
        /// </summary>
        /// <value>
        /// The USFinanceNumber.
        /// </value>
        [DataMember]
        public string USFinanceNumber { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock1.
        /// </summary>
        /// <value>
        /// The AddressBlock1.
        /// </value>
        [DataMember]
        public string AddressBlock1 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock2.
        /// </summary>
        /// <value>
        /// The AddressBlock2.
        /// </value>
        [DataMember]
        public string AddressBlock2 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock3.
        /// </summary>
        /// <value>
        /// The AddressBlock3.
        /// </value>
        [DataMember]
        public string AddressBlock3 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock4.
        /// </summary>
        /// <value>
        /// The AddressBlock4.
        /// </value>
        [DataMember]
        public string AddressBlock4 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock5.
        /// </summary>
        /// <value>
        /// The AddressBlock5.
        /// </value>
        [DataMember]
        public string AddressBlock5 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock6.
        /// </summary>
        /// <value>
        /// The AddressBlock6.
        /// </value>
        [DataMember]
        public string AddressBlock6 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock7.
        /// </summary>
        /// <value>
        /// The AddressBlock7.
        /// </value>
        [DataMember]
        public string AddressBlock7 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock8.
        /// </summary>
        /// <value>
        /// The AddressBlock8.
        /// </value>
        [DataMember]
        public string AddressBlock8 { get; set; }

        /// <summary>
        /// Gets or sets the AddressBlock9.
        /// </summary>
        /// <value>
        /// The AddressBlock9.
        /// </value>
        [DataMember]
        public string AddressBlock9 { get; set; }

        /// <summary>
        /// Gets or sets the CanLanguage.
        /// </summary>
        /// <value>
        /// The CanLanguage.
        /// </value>
        [DataMember]
        public string CanLanguage { get; set; }

        /// <summary>
        /// Gets or sets the DPVNoStat.
        /// </summary>
        /// <value>
        /// The DPVNoStat.
        /// </value>
        [DataMember]
        public string DPVNoStat { get; set; }

        /// <summary>
        /// Gets or sets the DPVVacant.
        /// </summary>
        /// <value>
        /// The DPVVacant.
        /// </value>
        [DataMember]
        public string DPVVacant { get; set; }
                
    }

    /// <summary>
    /// Response of ValidateMailingAddressUSCANAPI
    /// (List of validated addresses)
    /// </summary>
    [DataContract]
    public class ValidateMailingAddressUSCANAPIResponse
    {
        [DataMember(Name = "Output")]
        public List<Output> OutputList { get; set; }
    }
}
