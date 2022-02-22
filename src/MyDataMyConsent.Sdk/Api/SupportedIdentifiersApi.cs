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
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace MyDataMyConsent.Sdk.Api
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
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <returns>SupportedIdentifiersByCountry</returns>
        SupportedIdentifiersByCountry GetAllSupportedIdentifiers(string countryIso2Code);

        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <returns>ApiResponse of SupportedIdentifiersByCountry</returns>
        ApiResponse<SupportedIdentifiersByCountry> GetAllSupportedIdentifiersWithHttpInfo(string countryIso2Code);
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
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SupportedIdentifiersByCountry</returns>
        System.Threading.Tasks.Task<SupportedIdentifiersByCountry> GetAllSupportedIdentifiersAsync(string countryIso2Code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all supported identifiers by country.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SupportedIdentifiersByCountry)</returns>
        System.Threading.Tasks.Task<ApiResponse<SupportedIdentifiersByCountry>> GetAllSupportedIdentifiersWithHttpInfoAsync(string countryIso2Code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
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
        private MyDataMyConsent.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
            this.Configuration = MyDataMyConsent.Sdk.Client.Configuration.MergeConfigurations(
                MyDataMyConsent.Sdk.Client.GlobalConfiguration.Instance,
                new MyDataMyConsent.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new MyDataMyConsent.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MyDataMyConsent.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = MyDataMyConsent.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SupportedIdentifiersApi(MyDataMyConsent.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = MyDataMyConsent.Sdk.Client.Configuration.MergeConfigurations(
                MyDataMyConsent.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new MyDataMyConsent.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MyDataMyConsent.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = MyDataMyConsent.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedIdentifiersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SupportedIdentifiersApi(MyDataMyConsent.Sdk.Client.ISynchronousClient client, MyDataMyConsent.Sdk.Client.IAsynchronousClient asyncClient, MyDataMyConsent.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = MyDataMyConsent.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public MyDataMyConsent.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public MyDataMyConsent.Sdk.Client.ISynchronousClient Client { get; set; }

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
        public MyDataMyConsent.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MyDataMyConsent.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// Get all supported identifiers by country. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <returns>SupportedIdentifiersByCountry</returns>
        public SupportedIdentifiersByCountry GetAllSupportedIdentifiers(string countryIso2Code)
        {
            MyDataMyConsent.Sdk.Client.ApiResponse<SupportedIdentifiersByCountry> localVarResponse = GetAllSupportedIdentifiersWithHttpInfo(countryIso2Code);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all supported identifiers by country. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <returns>ApiResponse of SupportedIdentifiersByCountry</returns>
        public MyDataMyConsent.Sdk.Client.ApiResponse<SupportedIdentifiersByCountry> GetAllSupportedIdentifiersWithHttpInfo(string countryIso2Code)
        {
            MyDataMyConsent.Sdk.Client.RequestOptions localVarRequestOptions = new MyDataMyConsent.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MyDataMyConsent.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = MyDataMyConsent.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("countryIso2Code", MyDataMyConsent.Sdk.Client.ClientUtils.ParameterToString(countryIso2Code)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<SupportedIdentifiersByCountry>("/v1/supported-identifiers/{countryIso2Code}", localVarRequestOptions, this.Configuration);
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
        /// Get all supported identifiers by country. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SupportedIdentifiersByCountry</returns>
        public async System.Threading.Tasks.Task<SupportedIdentifiersByCountry> GetAllSupportedIdentifiersAsync(string countryIso2Code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MyDataMyConsent.Sdk.Client.ApiResponse<SupportedIdentifiersByCountry> localVarResponse = await GetAllSupportedIdentifiersWithHttpInfoAsync(countryIso2Code, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all supported identifiers by country. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code">Country ISO 2 code.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SupportedIdentifiersByCountry)</returns>
        public async System.Threading.Tasks.Task<MyDataMyConsent.Sdk.Client.ApiResponse<SupportedIdentifiersByCountry>> GetAllSupportedIdentifiersWithHttpInfoAsync(string countryIso2Code, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            MyDataMyConsent.Sdk.Client.RequestOptions localVarRequestOptions = new MyDataMyConsent.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MyDataMyConsent.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = MyDataMyConsent.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("countryIso2Code", MyDataMyConsent.Sdk.Client.ClientUtils.ParameterToString(countryIso2Code)); // path parameter


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SupportedIdentifiersByCountry>("/v1/supported-identifiers/{countryIso2Code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
