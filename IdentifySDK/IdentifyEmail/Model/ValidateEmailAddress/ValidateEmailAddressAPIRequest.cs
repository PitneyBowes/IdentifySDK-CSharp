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

namespace com.pb.identify.IdentifyEmail.Model.ValidateEmailAddress
{

    /// <summary>
    /// Input Record
    /// </summary>
    [DataContract(Name = "Row")]
    public class Record
    {
        /// <summary>
        /// Gets or sets the Bogus.
        /// </summary>
        /// <value>
        /// Bogus.
        /// </value>
        [DataMember(Name = "bogus")]
        public string Bogus { get; set; }
        /// <summary>
        /// Gets or sets the Complain.
        /// </summary>
        /// <value>
        /// Complain.
        /// </value>
        [DataMember(Name = "complain")]
        public string Complain { get; set; }
        /// <summary>
        /// Gets or sets the Disposable.
        /// </summary>
        /// <value>
        /// Disposable.
        /// </value>
        [DataMember(Name = "disposable")]
        public string Disposable { get; set; }
        /// <summary>
        /// Gets or sets the ATC.
        /// </summary>
        /// <value>
        /// ATC.
        /// </value>
        [DataMember(Name = "atc")]
        public string ATC { get; set; }
        /// <summary>
        /// Gets or sets the EmailAddress.
        /// </summary>
        /// <value>
        /// EmailAddress.
        /// </value>
        [DataMember(Name = "emailAddress")]
        public string EmailAddress { get; set; }
        /// <summary>
        /// Gets or sets the Emps.
        /// </summary>
        /// <value>
        /// Emps.
        /// </value>
        [DataMember(Name = "emps")]
        public string Emps { get; set; }
        /// <summary>
        /// Gets or sets the FCCWireless.
        /// </summary>
        /// <value>
        /// FCCWireless.
        /// </value>
        [DataMember(Name = "fccwireless")]
        public string FCCWireless { get; set; }
        /// <summary>
        /// Gets or sets the Language.
        /// </summary>
        /// <value>
        /// Language.
        /// </value>
        [DataMember(Name = "language")]
        public string Language { get; set; }
        /// <summary>
        /// Gets or sets the Role.
        /// </summary>
        /// <value>
        /// Role.
        /// </value>
        [DataMember(Name = "role")]
        public string Role { get; set; }
        /// <summary>
        /// Gets or sets the Rtc.
        /// </summary>
        /// <value>
        /// Rtc.
        /// </value>
        [DataMember(Name = "rtc")]
        public string RTC { get; set; }
        /// <summary>
        /// Gets or sets the RtcTimeOut.
        /// </summary>
        /// <value>
        /// RtcTimeOut.
        /// </value>
        [DataMember(Name = "rtc_timeout")]
        public string RTCTimeOut { get; set; }

        [DataMember]
        public List<user_field> user_fields { get; set; }

        /// <summary>
        /// Record Constructor .
        /// </summary>
        public Record(List<user_field> userfields, string bogus = "", string complain = "", string disposable = "", string atc = "", string emailaddress = "", string emps = "", string fccwireless = "", string language = "", string role = "", string rtc = "", string rtctimeout = "")
        {
            if (bogus != "")
                Bogus = bogus;

            if (complain != "")
                Complain = complain;

            if (disposable != "")
                Disposable = disposable;

            if (atc != "")
                ATC = atc;

            if (emailaddress != "")
                EmailAddress = emailaddress;

            if (emps != "")
                Emps = emps;

            if (fccwireless != "")
                FCCWireless = fccwireless;

            if (language != "")
                Language = language;

            if (role != "")
                Role = role;

            if (rtc != "")
                RTC = rtc;

            if (rtctimeout != "")
                RTCTimeOut = rtctimeout;

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
    /// Request of ValidateEmailAddressAPI
    /// </summary>
    [DataContract(Name = "Row")]
    public class ValidateEmailAddressAPIRequest
    {
        /// <summary>
        /// Gets or sets the Input.
        /// </summary>
        /// <value>
        /// Input
        /// </value>
        [DataMember]
        public input Input { get; set; }
        public ValidateEmailAddressAPIRequest(input liRow)
        {
            Input = liRow;
        }
    }
}
