#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion


using com.pb.identify.common.model;
using System;
namespace  com.pb.identify.exception
{


    /// <summary>
    /// Represents Error Response of CSharp SDK. There can be two types of error, one propagating from API
    /// and other which is occurring in the SDK implementation.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class SdkException : Exception
    {

        // Error Response type
        /// <summary>
        /// 
        /// </summary>
        public enum ErrorResponseType
        {
            /// <summary>
            /// The identify
            /// </summary>
            IDENTIFY,
            /// <summary>
            /// The internal
            /// </summary>
            INTERNAL
        };

        /// <summary>
        /// Gets or sets the error response types.
        /// </summary>
        /// <value>
        /// The error response types.
        /// </value>
        public ErrorResponseType ErrorResponseTypes{get;set;}
        /// <summary>
        /// Gets or sets the SDK internal errors.
        /// </summary>
        /// <value>
        /// The SDK internal errors.
        /// </value>
        public SdkInternalError SdkInternalErrors{get;set;}
        /// <summary>
        /// Gets or sets the Identify API errors.
        /// </summary>
        /// <value>
        /// The Identify API errors.
        /// </value>
        public ErrorInfo IdentifyApiErrors { get;set;}

        /// <summary>
        /// Initializes a new instance of the <see cref="SdkException" /> class.
        /// </summary>
        /// <param name="internalErrorResponse">The internal error response.</param>
        public SdkException(SdkInternalError internalErrorResponse)
        {
            this.SdkInternalErrors = internalErrorResponse;
            ErrorResponseTypes = ErrorResponseType.INTERNAL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SdkException" /> class.
        /// </summary>
        /// <param name="errors">The errors.</param>
        public SdkException(ErrorInfo errors)
        {
            this.IdentifyApiErrors = errors;
            ErrorResponseTypes = ErrorResponseType.IDENTIFY;

        }

        /// <summary>
        /// Returns http status code of the Identify API.
        /// </summary>
        /// <returns></returns>
        public int getHttpStatusCode()
        {
            int httpStatusCode = 0;
            if (this.IdentifyApiErrors != null)
            {
                return this.IdentifyApiErrors.HttpStatusCode;
            }
            return httpStatusCode;
        }

       
        

       
    }
}