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
using com.pb.identify.IdentifyEntity.Model.ExtractEntities;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Xml;

using com.pb.identify.exception;
using System.Diagnostics;

namespace com.pb.identify.IdentifyEntity
{
    ///<summary>
    ///IdentifyEntityServiceImpl
    ///</summary>
    /// <seealso cref="com.pb.identify.IdentifyEntity.IdentifyEntityService" />
    class IdentifyEntityServiceImpl:IdentifyEntityService
    {
        /// <summary>
        /// The IdentifyExtract URL
        /// </summary>
        private static readonly String IdentifyExtractUrl = "/identifyentity/v1/rest";
        /// <summary>
        /// The ExtractEntities URL
        /// </summary>
        private static readonly String ExtractEntitiesUrl = "/extractentities/";
        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<ExtractEntitiesAPIResponse>> IdentifyEntityRequestFinishedEvent;

        /// <summary>
        /// Matches the input record request.
        /// Accepts the record request as input and returns matched records  
        /// </summary>
        /// <param name="request">Required - ExtractEntitiesAPIRequest request (object filled with input and option) </param>
        /// <returns>ExtractEntitiesAPIResponse</returns>
        public ExtractEntitiesAPIResponse ExtractEntities(ExtractEntitiesAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(IdentifyExtractUrl));
            string url = urlBuilder.ToString() + ExtractEntitiesUrl;

            String requestString = Utility.ObjectToJson<ExtractEntitiesAPIRequest>(request);
            return Utility.processAPIRequest<ExtractEntitiesAPIResponse>(url, requestString);
        }

        /// <summary>
        /// Matches the input record request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ExtractEntitiesFinishedEvent.
        /// Accepts the record request as input and returns matched records 
        /// </summary>
        /// <param name="request">Required - ExtractEntitiesAPIRequest request (object filled with input and option) </param>
        public void ExtractEntitiesAsync(ExtractEntitiesAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(IdentifyExtractUrl));
            string url = urlBuilder.ToString() + ExtractEntitiesUrl;

            String requestString = Utility.ObjectToJson<ExtractEntitiesAPIRequest>(request);
            processAPIRequestDelegate<ExtractEntitiesAPIResponse> delegateApiRequest = new processAPIRequestDelegate<ExtractEntitiesAPIResponse>(Utility.processAPIRequest<ExtractEntitiesAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackExtractEntities), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackExtractEntities(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<ExtractEntitiesAPIResponse> del = (processAPIRequestDelegate<ExtractEntitiesAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<ExtractEntitiesAPIResponse> webResponseEventArgs;
            try
            {
                Debug.WriteLine(" ExtractEntities SDK Asynchronous function called ");
                ExtractEntitiesAPIResponse Response = del.EndInvoke(results);
                webResponseEventArgs = new WebResponseEventArgs<ExtractEntitiesAPIResponse>(Response, null);
                IdentifyEntityRequestFinishedEvent.Invoke(this, webResponseEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponseEventArgs = new WebResponseEventArgs<ExtractEntitiesAPIResponse>(null, sdkException);
                IdentifyEntityRequestFinishedEvent.Invoke(this, webResponseEventArgs);
                Trace.WriteLine(sdkException.Message);
            }
        }
    }
}
