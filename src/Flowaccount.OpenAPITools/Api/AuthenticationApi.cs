/* 
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2-oas3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Flowaccount.OpenAPITools.Client;
using Flowaccount.OpenAPITools.Model;

namespace Flowaccount.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate Access Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>AuthenResponse</returns>
        AuthenResponse TokenPost (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string));

        /// <summary>
        /// Generate Access Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>ApiResponse of AuthenResponse</returns>
        ApiResponse<AuthenResponse> TokenPostWithHttpInfo (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generate Access Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of AuthenResponse</returns>
        System.Threading.Tasks.Task<AuthenResponse> TokenPostAsync (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string));

        /// <summary>
        /// Generate Access Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenResponse>> TokenPostAsyncWithHttpInfo (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private Flowaccount.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Flowaccount.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Flowaccount.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi()
        {
            this.Configuration = Flowaccount.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Flowaccount.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Flowaccount.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Flowaccount.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Flowaccount.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Flowaccount.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Flowaccount.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Generate Access Token 
        /// </summary>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>AuthenResponse</returns>
        public AuthenResponse TokenPost (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string))
        {
             ApiResponse<AuthenResponse> localVarResponse = TokenPostWithHttpInfo(contentType, grantType, scope, clientId, clientSecret);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Access Token 
        /// </summary>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>ApiResponse of AuthenResponse</returns>
        public ApiResponse<AuthenResponse> TokenPostWithHttpInfo (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling AuthenticationApi->TokenPost");

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (grantType != null) localVarFormParams.Add("grant_type", this.Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (scope != null) localVarFormParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", this.Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AuthenResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenResponse)));
        }

        /// <summary>
        /// Generate Access Token 
        /// </summary>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of AuthenResponse</returns>
        public async System.Threading.Tasks.Task<AuthenResponse> TokenPostAsync (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string))
        {
             ApiResponse<AuthenResponse> localVarResponse = await TokenPostAsyncWithHttpInfo(contentType, grantType, scope, clientId, clientSecret);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate Access Token 
        /// </summary>
        /// <exception cref="Flowaccount.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contentType"></param>
        /// <param name="grantType"> (optional)</param>
        /// <param name="scope"> (optional)</param>
        /// <param name="clientId"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (AuthenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenResponse>> TokenPostAsyncWithHttpInfo (string contentType, string grantType = default(string), string scope = default(string), string clientId = default(string), string clientSecret = default(string))
        {
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling AuthenticationApi->TokenPost");

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (grantType != null) localVarFormParams.Add("grant_type", this.Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (scope != null) localVarFormParams.Add("scope", this.Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", this.Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AuthenResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenResponse)));
        }

    }
}
