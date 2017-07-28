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
using com.pb.identify.common;
using com.pb.identify.exception;
using com.pb.identify.identifyAddress.Model.ValidateMailingAddress;
using com.pb.identify.oauth;
using com.pb.identify.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace com.pb.identify.utils
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="url">The URL.</param>
    /// <param name="Request">Request.</param>
    /// <param name="contentType">The contentType.</param>
    /// <returns>T</returns>
    internal delegate T processAPIRequestDelegate<T>(String url, String requestString);

    /// <summary>
    /// Utility Class
    /// </summary>
    public class Utility {



        /// <summary>
        /// HttpVerb (GET/POST)
        /// </summary>
        public enum HttpVerb
        {
            /// <summary>
            /// The get
            /// </summary>
            Get,
            /// <summary>
            /// The post
            /// </summary>
            Post
        }

        /// <summary>
        /// contentType (xml/json)
        /// </summary>
        public enum contentType
        {
            /// <summary>
            /// The xml
            /// </summary>
            xml,
            /// <summary>
            /// The json
            /// </summary>
            json
        }

        /// <summary>
        /// OutputCasing
        /// </summary>
        public enum OutputCasing
        {
            /// <summary>
            /// U(Upper)
            /// </summary>
            U,
            /// <summary>
            /// M(Mixed)
            /// </summary>
            M,
        }
       
        
        /// <summary>
        /// Processes the API Request Object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="requestString">RequestString</param>
        /// <returns>T</returns>
        public static T processAPIRequest<T>(String url, String requestString)
        {

            T response;
            string ResponseString = string.Empty;
            
            ResponseString = processAPIRequestInternal<T>(url, requestString);
            response = JsonConvert.DeserializeObject<T>(ResponseString);
            Debug.WriteLine("Got a valid response from API");
            return response;
        }

        /// <summary>
        /// Processes the API Request Object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">The URL.</param>
        /// <param name="inputaddress">inputaddress String</param>
        /// <returns>string</returns>
        public static string processAPIRequestInternal<T>(String url, String inputaddress) 
        {
            String endPoint = String.Empty;
            String contentTypeString = String.Empty;
            SdkException exception = null;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            try
            {
                
                String accessToken = OAuthFactory.getOAuthService().getAuthenticationToken();
                //Add xml API fragment string to complete the endpoint for xml input
                endPoint = url + Constants.API_FRAGMENT_JSON;
                contentTypeString = "application/json;charset=utf-8";

                Uri uri = new Uri(endPoint);
                using (ExtendedWebClient client = new ExtendedWebClient())
                {
                    client.Headers.Add(HttpRequestHeader.ContentType, contentTypeString);
                    client.Headers.Add(Constants.AUTH_HEADER, accessToken);
                    client.Headers.Add(Constants.USER_AGENT, "CSharp-SDK");
                    String resp = (client.UploadString(uri, inputaddress));
                    return resp;
                }
            }
            catch (WebException webException)
            {
                Debug.WriteLine("Got an error response from API" + webException);
                string responseText = string.Empty;
                int statusCode = 0;

                if (webException.Response != null)
                {
                    var responseStream = webException.Response.GetResponseStream();
                    statusCode = (int)((HttpWebResponse)webException.Response).StatusCode;

                    using (var reader = new StreamReader(responseStream))
                    {
                        responseText = reader.ReadToEnd();
                    }
                    try
                    {
                        ErrorInfo apiError;
                        apiError = serializer.Deserialize<ErrorInfo>(responseText);
                        if(apiError != null)
                        { 
                            apiError.HttpStatusCode = statusCode;
                            apiError.Reason = webException.Message;
                            apiError.Response = responseText;
                        }
                        exception = new SdkException(apiError);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("Unexpected Error: " + e);
                        exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, e));
                    }
                }
                else
                {
                    Debug.WriteLine("Unexpected Error: " + webException);
                    exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, webException));
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Unexpected Error: " + e);
                exception = new SdkException(new SdkInternalError(Constants.ERROR_MSG_API_PROCESSING, e));
            }

            throw exception;
        
        }

        /// <summary>
        /// Converts object to json.
        /// </summary>
        /// /// <typeparam name="T">typeparam</typeparam>
        /// <param name="T">The objects.</param>
        public static string ObjectToJson<T>(T Object)
        {
            String ResponseString = JsonConvert.SerializeObject(Object, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return ResponseString;
        }
    }
    
}