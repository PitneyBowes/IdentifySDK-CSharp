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
using com.pb.identify.identifyRisk.Model.CheckGlobalWatchList;


using com.pb.identify.utils;
using System;

namespace com.pb.identify.identifyRisk
{
    /// <summary>
    ///  This service provides functionality to matches transactions against government-provided watch lists that contain data from various countries.
    /// </summary>
    public interface IdentifyRiskService
    {

        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        ///
        /// </summary>
        event EventHandler<WebResponseEventArgs<CheckGlobalWatchListAPIResponse>> IdentifyAPIRequestFinishedEvent;


        /// <summary>
        /// Matches the input record request in asynchronous mode.
        /// Response can be retrieved by subscribing to event IdentifyAPIRequestFinishedEvent.
        /// Accepts the record request as input and returns matched records 
        /// </summary>
        /// <param name="request">Required - CheckGlobalWatchListAPIRequest request (object filled with input and option) </param>
        void CheckGlobalWatchListAsync(CheckGlobalWatchListAPIRequest request);


        /// <summary>
        /// Matches the input record request.
        /// Accepts the record request as input and returns matched records  
        /// </summary>
        /// <param name="request">Required - CheckGlobalWatchListAPIRequest request (object filled with input and option) </param>
        /// <returns>CheckGlobalWatchListAPIResponse</returns>
        CheckGlobalWatchListAPIResponse CheckGlobalWatchList(CheckGlobalWatchListAPIRequest req);

    }
}