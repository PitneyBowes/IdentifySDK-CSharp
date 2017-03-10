#region copyright

/*Copyright 2016 Pitney Bowes Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
except in compliance with the License.  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the 
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.  
See the License for the specific language governing permissions and limitations under the License. */

#endregion

using com.pb.identify.identifyAddress;
using com.pb.identify.identifyRisk;
using com.pb.identify.IdentifyEmail;
using com.pb.identify.IdentifyEntity;
using com.pb.identify.oauth;

using com.pb.identify.utils;
using System.Configuration;
using System;
using System.Diagnostics;
using System.Security.Policy;
using com.pb.identify.exception;

namespace com.pb.identify.manager

{
    /// <summary>
    /// IdentifyServiceManager class is responsible for providing entry point all Identify specific
    /// interfaces.It provides singleton object for this class
    /// </summary>
    public class IdentifyServiceManager {


        /// <summary>
        /// The IdentifyServiceManager
        /// </summary>
        private static IdentifyServiceManager serviceManager = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="IdentifyServiceManager" /> class from being created.
        /// </summary>
        private IdentifyServiceManager() {
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["BASE_URL"]))
            {

                String url = ConfigurationManager.AppSettings["BASE_URL"];

               if(!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    SdkException sdkException = new SdkException(new common.model.SdkInternalError( Constants.INVALID_CUSTOM_BASE_URL));
                    throw sdkException;
                }


                UrlMaker.UrlStrategy.BASE_URL = ConfigurationManager.AppSettings["BASE_URL"];
            }
           
	}


        /// <summary>
        /// Gets the instance of IdentifyServiceManager.
        /// </summary>
        /// <param name="baseOAuthService">The base oAuth service.</param>
        /// <returns>
        /// IdentifyServiceManager
        /// </returns>
        public static  IdentifyServiceManager getInstance(BaseOAuthService baseOAuthService) {
		if (serviceManager == null) {
			 OAuthFactory.setInstance(baseOAuthService);
			serviceManager = new IdentifyServiceManager();
            Debug.WriteLine("Identify Service instance has been created");
		}
        Debug.WriteLine("Identify Service instance has been already created");
		return serviceManager;
	}


        /// <summary>
        /// Method to initialize IdentifyServiceManager interfaces with user login credentials.
        /// </summary>
        /// <param name="consumerKey">The consumer key.</param>
        /// <param name="consumerSecretKey">The consumer secret key.</param>
        /// <returns>
        /// IdentifyServiceManager
        /// </returns>
        public static  IdentifyServiceManager getInstance(String consumerKey, String consumerSecretKey ) {
		if (serviceManager == null) {
			 OAuthFactory.setInstance(new BaseOAuthServiceImpl(consumerKey, consumerSecretKey));
			serviceManager = new IdentifyServiceManager();
            Debug.WriteLine("Identify Service instance has been created");
		}
        Debug.WriteLine("Identify Service instance has been already created");
		return serviceManager;

	}


        /// <summary>
        /// Method to initialize IdentifyServiceManager services with a user supplied token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>
        /// IdentifyServiceManager
        /// </returns>
        public static  IdentifyServiceManager getInstance(String token) {
		if (serviceManager == null) {
			 OAuthFactory.setInstance(new BaseOAuthServiceImpl(token));
			serviceManager = new IdentifyServiceManager();
            Debug.WriteLine("Identify Service instance has been created");
		}
        Debug.WriteLine("Identify Service instance has been already created");
		return serviceManager;

	}


        /// <summary>
        /// OAuth Service APIs Handler.
        /// </summary>
        /// <returns>
        /// an instance of BaseOAuthService
        /// </returns>
        public BaseOAuthService getBaseAuthService() {
		return new OAuthService();
	}

    
        /// <summary>
        /// Gets the IdentifyAddress service.
        /// </summary>
        /// <returns></returns>
        public IdentifyAddressService getIdentifyAddressService()
        {
            return new IdentifyAddressServiceImpl();
        }


        /// <summary>
        /// Gets the IdentifyRisk service.
        /// </summary>
        /// <returns></returns>
        public IdentifyRiskService getIdentifyRiskService()
        {
            return new identifyRiskServiceImpl();
        }

        /// <summary>
        /// Gets the IdentifyEmail service.
        /// </summary>
        /// <returns></returns>
        public IdentifyEmailService getIdentifyEmailService()
        {
            return new IdentifyEmailServiceImpl();
        }

        /// <summary>
        /// Gets the IdentifyExtract service.
        /// </summary>
        /// <returns></returns>
        public IdentifyEntityService getIdentifyEntityService()
        {
            return new IdentifyEntityServiceImpl();
        }

        /**
         * To invalidate the Identify static reference
         */
        /// <summary>
        /// Invalidates the Identify service manager instance.
        /// </summary>
        public void invalidateIdentifyServiceManagerInstance() {
		if (serviceManager != null) {
			serviceManager = null;
            Debug.WriteLine("Identify instance has been invalidated");
		}
	}

}
}