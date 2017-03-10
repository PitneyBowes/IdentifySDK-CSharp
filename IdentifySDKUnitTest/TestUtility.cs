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
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using System.Configuration;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using com.pb.identify.utils;

namespace IdentifySDKTestCases
{
    public class TestUtility
    {

        private static String AUTH_HEADER = "Authorization";
        //private static String DEFAULT_MEDIA_TYPE = "application/json";

        //xml format
        private static String API_FRAGMENT_XML = "results.xml";
        //json format
        private static String API_FRAGMENT_JSON = "results.json";

        public static String ValidateFromAPI(String baseURL, String endpoint, String access_token, String inputAddress, Utility.contentType contType)
        {
            string URL;
            string contentTypeString;

            if (contType.Equals(Utility.contentType.xml))
            {
                URL = baseURL + endpoint + API_FRAGMENT_XML;
                 contentTypeString = "application/xml;charset=utf-8";
            }
            else
            {
                URL = baseURL + endpoint + API_FRAGMENT_JSON;
                 contentTypeString = "application/json;charset=utf-8";
            }
            return processRequest(contentTypeString, access_token, URL, inputAddress);
     }

    /**
		 * Generic client for HTTP Web Request execution.This method returns response of the web request submitted to it.
		 * @param ContentType
		 * @param EndPoint
		 * @param parameters
		 * @param accesstoken
		 * @param HttpMethod
		 * @param PostData
		 */
		
        /*
         * Method to send rest request and receive response
         * */
        private static string processRequest(string contentTypeString, string accessToken, string endPoint, string inputString)
        {
            string responseValue = "";
            string access_token = "Bearer " + accessToken;
            try
            {
                using (var client = new WebClient())
                {

                    client.Headers.Add(HttpRequestHeader.ContentType, contentTypeString);

                    client.Headers.Add(AUTH_HEADER, access_token);

                    responseValue = client.UploadString(new Uri(endPoint), "POST", inputString);

                    return responseValue;

                }
            }catch (WebException e)
            {               
                
                if (e.Response != null)
                {
                    var resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();
                    Console.WriteLine(resp);
                    return resp;
                }
               
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return responseValue;
        }
   

    }
}
 