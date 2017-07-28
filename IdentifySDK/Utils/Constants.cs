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

namespace com.pb.identify.utils
{

    /// <summary>
    /// Constants Interface
    /// </summary>
    public static class Constants
    {

        /// <summary>
        /// The access_token
        /// </summary>
        public static readonly String ACCESS_TOKEN = "access_token";

        /// <summary>
        /// The bearer
        /// </summary>
        public static readonly String BEARER = "Bearer ";

        /// <summary>
        /// The basic
        /// </summary>
        public static readonly String BASIC = "Basic ";

        /// <summary>
        /// The UserAgent
        /// </summary>
        public static readonly String USER_AGENT = "User-Agent";

        /// <summary>
        /// The client_ credentials
        /// </summary>
        public static readonly String CLIENT_CREDENTIALS = "client_credentials";

        /// <summary>
        /// The grant_ type
        /// </summary>
        public static readonly String GRANT_TYPE = "grant_type";

        /// <summary>
        /// The auth_ header
        /// </summary>
        public static readonly String AUTH_HEADER = "Authorization";

        /// <summary>
        /// The colon
        /// </summary>
        public static readonly String COLON = ":";

        
        /// <summary>
        /// json format
        /// </summary>
        public static readonly String API_FRAGMENT_JSON = "results.json";

        /// <summary>
        /// The error_ msg_ address_ required
        /// </summary>
        public static readonly String ERROR_MSG_ADDRESS_REQUIRED = "Address is a required parameter and cannot be null";

        
        /// <summary>
        /// The error_ msg_ api_ processing
        /// </summary>
        public static readonly String ERROR_MSG_API_PROCESSING = "Unexpected Error while processing the API Request";

        /// <summary>
        /// The error_ msg_ token_ invalid
        /// </summary>
        public static readonly String ERROR_MSG_TOKEN_INVALID = "Token is expired or not set.";

        /// <summary>
        /// The HTTp_ header_ value_ json
        /// </summary>
        public static readonly String HTTP_HEADER_VALUE_JSON = "application/json";
        /// <summary>
        /// The invalid_ custom_ base_ URL
        /// </summary>
        public static readonly String INVALID_CUSTOM_BASE_URL = "Invalid Custom Base Url";

       
        
    }
}