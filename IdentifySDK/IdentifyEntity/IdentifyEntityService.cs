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

using com.pb.identify.common;
using com.pb.identify.common.model;
using com.pb.identify.utils;
using com.pb.identify.IdentifyEntity.Model.ExtractEntities;

namespace com.pb.identify.IdentifyEntity
{
    /// <summary>
    ///  This service provides functionality that takes plain text and extracts entities from it such as names and addresses.
    /// </summary>
    public interface IdentifyEntityService
    {
        /// <summary>
        ///  This event is Raised Asynchronously when web  response is complete.The event has Argument WebRequestFinishedEvent
        ///  which has information regarding the response object and exception occurred
        /// </summary>
        event EventHandler<WebResponseEventArgs<ExtractEntitiesAPIResponse>> IdentifyEntityRequestFinishedEvent;

        /// <summary>
        /// Matches the input record request in asynchronous mode.
        /// Response can be retrieved by subscribing to event ExtractEntitiesFinishedEvent.
        /// Accepts the record request as input and returns matched records 
        /// </summary>
        /// <param name="request">Required - ExtractEntitiesAPIRequest request (object filled with input and option) </param>
        void ExtractEntitiesAsync(ExtractEntitiesAPIRequest request);

        /// <summary>
        /// Matches the input record request.
        /// Accepts the record request as input and returns matched records  
        /// </summary>
        /// <param name="request">Required - ExtractEntitiesAPIRequest request (object filled with input and option) </param>
        /// <returns>ExtractEntitiesAPIResponse</returns>
        ExtractEntitiesAPIResponse ExtractEntities(ExtractEntitiesAPIRequest request);
    }
}
