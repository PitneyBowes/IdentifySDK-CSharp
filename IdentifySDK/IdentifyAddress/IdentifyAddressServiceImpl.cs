#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion
using com.pb.identify.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Messaging;
using com.pb.identify.common;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddress;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddressPro;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddressPremium;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Xml;

using com.pb.identify.exception;
using System.Diagnostics;

namespace com.pb.identify.identifyAddress
{
    ///<summary>
    ///IdentifyAddressServiceImpl
    ///</summary>
    /// <seealso cref="com.pb.identify.identifyAddress.IdentifyAddressService" />
    public class IdentifyAddressServiceImpl : IdentifyAddressService
    {
        /// <summary>
        /// The identifyAddress URL
        /// </summary>
        private static readonly String identifyAddressUrl = "/identifyaddress/v1/rest";
        /// <summary>
        /// The validatemailingaddress URL
        /// </summary>
        private static readonly String validateMailingAddressUrl = "/validatemailingaddress/";
        /// <summary>
        /// The validatemailingaddresspro URL
        /// </summary>
        private static readonly String validateMailingAddressProUrl = "/validatemailingaddresspro/";
        /// <summary>
        /// The validatemailingaddresspremium URL
        /// </summary>
        private static readonly String validateMailingAddressPremiumUrl = "/validatemailingaddresspremium/";
        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<ValidateMailingAddressAPIResponse>> IdentifyAPIRequestFinishedEvent;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<ValidateMailingAddressProAPIResponse>> ValidateAddressProFinishedEvent;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse>> ValidateAddressPremiumFinishedEvent;

        #region ValidateMailingAddress
        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressAPIResponse</returns>
        public ValidateMailingAddressAPIResponse ValidateMailingAddress(ValidateMailingAddressAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressUrl;

           
            String requestString = Utility.ObjectToJson<ValidateMailingAddressAPIRequest>(request);
            return Utility.processAPIRequest<ValidateMailingAddressAPIResponse>(url, requestString);
        }

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event IdentifyAPIRequestFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressAPIRequest request (object filled with input and option) </param>
        public void ValidateMailingAddressAsync(ValidateMailingAddressAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressUrl;

            String requestString = Utility.ObjectToJson<ValidateMailingAddressAPIRequest>(request);
            processAPIRequestDelegate<ValidateMailingAddressAPIResponse> delegateApiRequest = new processAPIRequestDelegate<ValidateMailingAddressAPIResponse>(Utility.processAPIRequest<ValidateMailingAddressAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackValidateAddress), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackValidateAddress(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<ValidateMailingAddressAPIResponse> del = (processAPIRequestDelegate<ValidateMailingAddressAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ValidateMailingAddressAPIResponse> webResponceEventArgs;
            try
            {
                Debug.WriteLine(" ValidateMailingAddress SDK Asynchronous function called ");
                ValidateMailingAddressAPIResponse Response = del.EndInvoke(results);
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressAPIResponse>(Response, null);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressAPIResponse>(null, sdkException);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
                Trace.WriteLine(sdkException.Message);
            }
        }
        #endregion

        #region ValidateMailingAddressPro
        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressProAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressProAPIResponse</returns>
        public ValidateMailingAddressProAPIResponse ValidateMailingAddressPro(ValidateMailingAddressProAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressProUrl;

            String requestString = Utility.ObjectToJson<ValidateMailingAddressProAPIRequest>(request);
            return Utility.processAPIRequest<ValidateMailingAddressProAPIResponse>(url, requestString);
        }

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ValidateAddressProFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressProAPIRequest request (object filled with input and option) </param>
        public void ValidateMailingAddressProAsync(ValidateMailingAddressProAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressProUrl;

            String requestString = Utility.ObjectToJson<ValidateMailingAddressProAPIRequest>(request);
            processAPIRequestDelegate<ValidateMailingAddressProAPIResponse> delegateApiRequest = new processAPIRequestDelegate<ValidateMailingAddressProAPIResponse>(Utility.processAPIRequest<ValidateMailingAddressProAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackValidateAddressPro), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackValidateAddressPro(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<ValidateMailingAddressProAPIResponse> del = (processAPIRequestDelegate<ValidateMailingAddressProAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ValidateMailingAddressProAPIResponse> webResponceEventArgs;
            try
            {
                Debug.WriteLine(" ValidateMailingAddressPro SDK Asynchronous function called ");
                ValidateMailingAddressProAPIResponse Response = del.EndInvoke(results);
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressProAPIResponse>(Response, null);
                ValidateAddressProFinishedEvent.Invoke(this, webResponceEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressProAPIResponse>(null, sdkException);
                ValidateAddressProFinishedEvent.Invoke(this, webResponceEventArgs);
                Trace.WriteLine(sdkException.Message);
            }
        }
        #endregion

        #region ValidateMailingAddressPremium
        /// <summary>
        /// Validates the input address request.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressPremiumAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateMailingAddressPremiumAPIResponse</returns>
        public ValidateMailingAddressPremiumAPIResponse ValidateMailingAddressPremium(ValidateMailingAddressPremiumAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressPremiumUrl;

            String requestString = Utility.ObjectToJson<ValidateMailingAddressPremiumAPIRequest>(request);
            return Utility.processAPIRequest<ValidateMailingAddressPremiumAPIResponse>(url, requestString);
        }

        /// <summary>
        /// Validates the input address request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ValidateAddressProFinishedEvent.
        /// Accepts the address request as input and returns validated addresses 
        /// </summary>
        /// <param name="request">Required - ValidateMailingAddressPremiumAPIRequest request (object filled with input and option) </param>
        public void ValidateMailingAddressPremiumAsync(ValidateMailingAddressPremiumAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyAddressUrl));
            string url = urlBuilder.ToString() + validateMailingAddressPremiumUrl;

            String requestString = Utility.ObjectToJson<ValidateMailingAddressPremiumAPIRequest>(request);
            processAPIRequestDelegate<ValidateMailingAddressPremiumAPIResponse> delegateApiRequest = new processAPIRequestDelegate<ValidateMailingAddressPremiumAPIResponse>(Utility.processAPIRequest<ValidateMailingAddressPremiumAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackValidateAddressPremium), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackValidateAddressPremium(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<ValidateMailingAddressPremiumAPIResponse> del = (processAPIRequestDelegate<ValidateMailingAddressPremiumAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse> webResponceEventArgs;
            try
            {
                Debug.WriteLine(" ValidateMailingAddressPremium SDK Asynchronous function called ");
                ValidateMailingAddressPremiumAPIResponse Response = del.EndInvoke(results);
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse>(Response, null);
                ValidateAddressPremiumFinishedEvent.Invoke(this, webResponceEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponceEventArgs = new WebResponseEventArgs<ValidateMailingAddressPremiumAPIResponse>(null, sdkException);
                ValidateAddressPremiumFinishedEvent.Invoke(this, webResponceEventArgs);
                Trace.WriteLine(sdkException.Message);
            }
        }
        #endregion

    }
}
