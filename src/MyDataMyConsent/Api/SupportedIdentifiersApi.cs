/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@mydatamyconsent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace MyDataMyConsent.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISupportedIdentifiersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// Get all supported identifiers by country.
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SupportedIdentifier</returns>
        SupportedIdentifier GetAllSupportedIdentifiers(string countryIso2Code, int operationIndex = 0);

        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// Get all supported identifiers by country.
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SupportedIdentifier</returns>
        ApiResponse<SupportedIdentifier> GetAllSupportedIdentifiersWithHttpInfo(string countryIso2Code, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISupportedIdentifiersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// Get all supported identifiers by country.
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SupportedIdentifier</returns>
        System.Threading.Tasks.Task<SupportedIdentifier> GetAllSupportedIdentifiersAsync(string countryIso2Code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// Get all supported identifiers by country.
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SupportedIdentifier)</returns>
        System.Threading.Tasks.Task<ApiResponse<SupportedIdentifier>> GetAllSupportedIdentifiersWithHttpInfoAsync(string countryIso2Code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISupportedIdentifiersApi : ISupportedIdentifiersApiSync, ISupportedIdentifiersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SupportedIdentifiersApi : ISupportedIdentifiersApi
    {
        private MyDataMyConsent.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SupportedIdentifiersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SupportedIdentifiersApi(string basePath)
        {
            this.Configuration = MyDataMyConsent.Client.Configuration.MergeConfigurations(
                MyDataMyConsent.Client.GlobalConfiguration.Instance,
                new MyDataMyConsent.Client.Configuration { BasePath = basePath }
            );
            this.Client = new MyDataMyConsent.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MyDataMyConsent.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = MyDataMyConsent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SupportedIdentifiersApi(MyDataMyConsent.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = MyDataMyConsent.Client.Configuration.MergeConfigurations(
                MyDataMyConsent.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new MyDataMyConsent.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MyDataMyConsent.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = MyDataMyConsent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SupportedIdentifiersApi(MyDataMyConsent.Client.ISynchronousClient client, MyDataMyConsent.Client.IAsynchronousClient asyncClient, MyDataMyConsent.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = MyDataMyConsent.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public MyDataMyConsent.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public MyDataMyConsent.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MyDataMyConsent.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MyDataMyConsent.Client.ExceptionFactory ExceptionFactory
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
        /// Get all supported identifiers by country. Get all supported identifiers by country.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SupportedIdentifier</returns>
        public SupportedIdentifier GetAllSupportedIdentifiers(string countryIso2Code, int operationIndex = 0)
        {
            MyDataMyConsent.Client.ApiResponse<SupportedIdentifier> localVarResponse = GetAllSupportedIdentifiersWithHttpInfo(countryIso2Code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all supported identifiers by country. Get all supported identifiers by country.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SupportedIdentifier</returns>
        public MyDataMyConsent.Client.ApiResponse<SupportedIdentifier> GetAllSupportedIdentifiersWithHttpInfo(string countryIso2Code, int operationIndex = 0)
        {
            // verify the required parameter 'countryIso2Code' is set
            if (countryIso2Code == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'countryIso2Code' when calling SupportedIdentifiersApi->GetAllSupportedIdentifiers");
            }

            MyDataMyConsent.Client.RequestOptions localVarRequestOptions = new MyDataMyConsent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MyDataMyConsent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = MyDataMyConsent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("countryIso2Code", MyDataMyConsent.Client.ClientUtils.ParameterToString(countryIso2Code)); // path parameter

            localVarRequestOptions.Operation = "SupportedIdentifiersApi.GetAllSupportedIdentifiers";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<SupportedIdentifier>("/v1/supported-identifiers/{countryIso2Code}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllSupportedIdentifiers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all supported identifiers by country. Get all supported identifiers by country.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SupportedIdentifier</returns>
        public async System.Threading.Tasks.Task<SupportedIdentifier> GetAllSupportedIdentifiersAsync(string countryIso2Code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MyDataMyConsent.Client.ApiResponse<SupportedIdentifier> localVarResponse = await GetAllSupportedIdentifiersWithHttpInfoAsync(countryIso2Code, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all supported identifiers by country. Get all supported identifiers by country.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SupportedIdentifier)</returns>
        public async System.Threading.Tasks.Task<MyDataMyConsent.Client.ApiResponse<SupportedIdentifier>> GetAllSupportedIdentifiersWithHttpInfoAsync(string countryIso2Code, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'countryIso2Code' is set
            if (countryIso2Code == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'countryIso2Code' when calling SupportedIdentifiersApi->GetAllSupportedIdentifiers");
            }


            MyDataMyConsent.Client.RequestOptions localVarRequestOptions = new MyDataMyConsent.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MyDataMyConsent.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = MyDataMyConsent.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("countryIso2Code", MyDataMyConsent.Client.ClientUtils.ParameterToString(countryIso2Code)); // path parameter

            localVarRequestOptions.Operation = "SupportedIdentifiersApi.GetAllSupportedIdentifiers";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SupportedIdentifier>("/v1/supported-identifiers/{countryIso2Code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllSupportedIdentifiers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}