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

namespace com.pb.identify.oauth
{

    
    /// <summary>
    /// This Singleton factory class returns specific OAuth service. 
    /// </summary>
    public class OAuthFactory
    {

        private static OAuthFactory INSTANCE;
        private BaseOAuthService authService;
        private OAuthFactory(BaseOAuthService service)
        {
            this.authService = service;
        }

        /// <summary>
        /// Sets the instance.
        /// </summary>
        /// <param name="service">The service.</param>
        public static void setInstance(BaseOAuthService service)
        {
            INSTANCE = new OAuthFactory(service);
        }

        /// <summary>
        /// Gets the instance of OAuthFactory.
        /// </summary>
        /// <returns>OAuthFactory</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public static OAuthFactory getInstance()
        {
            if (INSTANCE == null)
                throw new InvalidOperationException();
            return INSTANCE;
        }
        
        /// <summary>
        /// Gets the Authentication service.
        /// </summary>
        /// <returns>BaseOAuthService</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public static BaseOAuthService getOAuthService()
        {
            if (INSTANCE == null || INSTANCE.authService == null)
                throw new InvalidOperationException();
            return INSTANCE.authService;
        }

    }
}