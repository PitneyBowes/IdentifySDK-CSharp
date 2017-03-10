#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.identify.common;
using com.pb.identify.common.model;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddress;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddressPro;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddressPremium;

using com.pb.identify.utils;
using System;

namespace com.pb.identify.identifyAddress
{
    /// <summary>
    ///  This service provides functionality to validate the input addresss and return validated address with status of validation.
    /// </summary>
    public interface IdentifyAddressService
    {

        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        ///
        /// </summary>
        event EventHandler<WebResponseEventArgs<ValidateMailingAddressAPIResponse>> IdentifyAPIRequestFinishedEvent;

        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        ///
        /// </summary>
        event EventHandler<WebResponseEventArgs<ValidateMailingAddressProAPIResponse>> ValidateAddressProFinishedEvent;

        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        ///
        /// </summary>
        event EventHandler<WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse>> ValidateAddressPremiumFinishedEvent;

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event IdentifyAPIRequestFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressAPIRequest request (object filled with input and option) </param>
        void ValidateMailingAddressAsync(ValidateMailingAddressAPIRequest request);

        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressAPIResponse</returns>
        ValidateMailingAddressAPIResponse ValidateMailingAddress(ValidateMailingAddressAPIRequest request);

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ValidateAddressProFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressProAPIRequest request (object filled with input and option) </param>
        void ValidateMailingAddressProAsync(ValidateMailingAddressProAPIRequest request);

        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressProAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressProAPIResponse</returns>
        ValidateMailingAddressProAPIResponse ValidateMailingAddressPro(ValidateMailingAddressProAPIRequest request);

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ValidateAddressPremiumFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressPremiumAPIRequest request (object filled with input and option) </param>
        void ValidateMailingAddressPremiumAsync(ValidateMailingAddressPremiumAPIRequest request);

        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressPremiumAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressPremiumAPIResponse</returns>
        ValidateMailingAddressPremiumAPIResponse ValidateMailingAddressPremium(ValidateMailingAddressPremiumAPIRequest request);
    }
}