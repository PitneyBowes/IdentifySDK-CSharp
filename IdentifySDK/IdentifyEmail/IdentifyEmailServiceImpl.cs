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
using com.pb.identify.IdentifyEmail.Model.ValidateEmailAddress;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Xml;

using com.pb.identify.exception;
using System.Diagnostics;

namespace com.pb.identify.IdentifyEmail
{
    ///<summary>
    ///IdentifyEmailServiceImpl
    ///</summary>
    /// <seealso cref="com.pb.identify.IdentifyEmail.IdentifyEmailService" />
    class IdentifyEmailServiceImpl : IdentifyEmailService
    {
        /// <summary>
        /// The IdentifyEmail URL
        /// </summary>
        private static readonly String IdentifyEmailUrl = "/identifyemail/v1/rest";
        /// <summary>
        /// The ValidateEmailAddress URL
        /// </summary>
        private static readonly String ValidateEmailAddressUrl = "/validateemailaddress/";
        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<ValidateEmailAddressAPIResponse>> IdentifyAPIRequestFinishedEvent;

        /// <summary>
        /// Matches the input record request.
        /// Accepts the record request as input and returns matched records  
        /// </summary>
        /// <param name="request">Required - ValidateEmailAddressAPIRequest request (object filled with input and option) </param>
        /// <returns>ValidateEmailAddressAPIResponse</returns>
        public ValidateEmailAddressAPIResponse ValidateEmailAddress(ValidateEmailAddressAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(IdentifyEmailUrl));
            string url = urlBuilder.ToString() + ValidateEmailAddressUrl;

            String requestString = Utility.ObjectToJson <ValidateEmailAddressAPIRequest>(request);
            return Utility.processAPIRequest<ValidateEmailAddressAPIResponse>(url, requestString);
        }

        /// <summary>
        /// Matches the input record request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ValidateEmailAddressFinishedEvent.
        /// Accepts the record request as input and returns matched records 
        /// </summary>
        /// <param name="request">Required - ValidateEmailAddressAPIRequest request (object filled with input and option) </param>
        public void ValidateEmailAddressAsync(ValidateEmailAddressAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(IdentifyEmailUrl));
            string url = urlBuilder.ToString() + ValidateEmailAddressUrl;

            String requestString = Utility.ObjectToJson<ValidateEmailAddressAPIRequest>(request);
            processAPIRequestDelegate<ValidateEmailAddressAPIResponse> delegateApiRequest = new processAPIRequestDelegate<ValidateEmailAddressAPIResponse>(Utility.processAPIRequest<ValidateEmailAddressAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackValidateEmailAddress), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackValidateEmailAddress(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<ValidateEmailAddressAPIResponse> del = (processAPIRequestDelegate<ValidateEmailAddressAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ValidateEmailAddressAPIResponse> webResponseEventArgs;
            try
            {
                Debug.WriteLine(" ValidateEmailAddress SDK Asynchronous function called ");
                ValidateEmailAddressAPIResponse Response = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<ValidateEmailAddressAPIResponse>(Response, null);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<ValidateEmailAddressAPIResponse>(null, sdkException);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }
        }

    }
}
