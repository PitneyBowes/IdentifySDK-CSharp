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
using com.pb.identify.identifyRisk.Model.CheckGlobalWatchList;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Xml;

using com.pb.identify.exception;
using System.Diagnostics;

namespace com.pb.identify.identifyRisk
{
   
    
    ///<summary>
    ///identifyRiskServiceImpl
    ///</summary>
    /// <seealso cref="com.pb.identify.identifyRisk.IdentifyRiskService" />
    public class identifyRiskServiceImpl : IdentifyRiskService
    {

        /// <summary>
        /// The identifyRisk URL
        /// </summary>
        private static readonly String identifyRiskUrl = "/identifyrisk/v1/rest";
        /// <summary>
        /// The checkglobalwatchlist URL
        /// </summary>
        private static readonly String checkGlobalWatchListUrl = "/checkglobalwatchlist/";
        /// <summary>
        /// The URL maker
        /// </summary>
        private UrlMaker urlMaker;

        /// <summary>
        /// This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        /// which has information regarding the response object and exception occurred
        /// </summary>
        public event EventHandler<common.WebResponseEventArgs<CheckGlobalWatchListAPIResponse>> IdentifyAPIRequestFinishedEvent;



        /// <summary>
        /// Matches the input record request.
        /// Accepts the record request as input and returns matched records  
        /// </summary>
        /// <param name="request">Required - CheckGlobalWatchListAPIRequest request (object filled with input and option) </param>
        /// <returns>CheckGlobalWatchListAPIResponse</returns>
        public CheckGlobalWatchListAPIResponse CheckGlobalWatchList(CheckGlobalWatchListAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyRiskUrl));
            string url = urlBuilder.ToString() + checkGlobalWatchListUrl;

           
            String requestString = Utility.ObjectToJson<CheckGlobalWatchListAPIRequest>(request);
            return Utility.processAPIRequest<CheckGlobalWatchListAPIResponse>(url, requestString);
        }





        /// <summary>
        /// Matches the input record request in asynchronous mode.
        /// Response can be retrieved by subscribing to event IdentifyAPIRequestFinishedEvent.
        /// Accepts the record request as input and returns matched records 
        /// </summary>
        /// <param name="request">Required - CheckGlobalWatchListAPIRequest request (object filled with input and option) </param>
        public void CheckGlobalWatchListAsync(CheckGlobalWatchListAPIRequest request)
        {
            UrlMaker urlMaker = UrlMaker.getInstance();
            StringBuilder urlBuilder = new StringBuilder(urlMaker.getAbsoluteUrl(identifyRiskUrl));
            string url = urlBuilder.ToString() + checkGlobalWatchListUrl;

            String requestString = Utility.ObjectToJson<CheckGlobalWatchListAPIRequest>(request);
            processAPIRequestDelegate<CheckGlobalWatchListAPIResponse> delegateApiRequest = new processAPIRequestDelegate<CheckGlobalWatchListAPIResponse>(Utility.processAPIRequest<CheckGlobalWatchListAPIResponse>);
            delegateApiRequest.BeginInvoke(url, requestString, new AsyncCallback(WorkflowCompletedCallbackCheckGlobalWatchList), null);
        }

        /// <summary>
        /// Workflows the completed callback.
        /// </summary>
        /// <param name="results">The results.</param>
        void WorkflowCompletedCallbackCheckGlobalWatchList(IAsyncResult results)
        {
            AsyncResult result = (AsyncResult)results;
            processAPIRequestDelegate<CheckGlobalWatchListAPIResponse> del = (processAPIRequestDelegate<CheckGlobalWatchListAPIResponse>)result.AsyncDelegate;
            WebResponseEventArgs<CheckGlobalWatchListAPIResponse> webResponceEventArgs;
            try
            {
                Debug.WriteLine(" CheckGlobalWatchList SDK Asynchronous function called ");
                CheckGlobalWatchListAPIResponse Response = del.EndInvoke(results);
                webResponceEventArgs = new WebResponseEventArgs<CheckGlobalWatchListAPIResponse>(Response, null);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
            }
            catch (SdkException sdkException)
            {
                webResponceEventArgs = new WebResponseEventArgs<CheckGlobalWatchListAPIResponse>(null, sdkException);
                IdentifyAPIRequestFinishedEvent.Invoke(this, webResponceEventArgs);
                Trace.WriteLine(sdkException.Message);
            }

        }

          
    }
}
