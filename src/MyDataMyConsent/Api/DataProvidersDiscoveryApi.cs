/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: 1.0
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
using MyDataMyConsent.Client.Auth;
using MyDataMyConsent.Models;

namespace MyDataMyConsent.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataProvidersDiscoveryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Discover all data providers in my data my consent by country and filters.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaginatedListOfDataProviders</returns>
        PaginatedListOfDataProviders V1DataProvidersGet(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0);

        /// <summary>
        /// Discover all data providers in my data my consent by country and filters.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaginatedListOfDataProviders</returns>
        ApiResponse<PaginatedListOfDataProviders> V1DataProvidersGetWithHttpInfo(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0);
        /// <summary>
        /// Get a data provider details by provider id.
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DataProviderDetails</returns>
        DataProviderDetails V1DataProvidersIdGet(string id, int operationIndex = 0);

        /// <summary>
        /// Get a data provider details by provider id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DataProviderDetails</returns>
        ApiResponse<DataProviderDetails> V1DataProvidersIdGetWithHttpInfo(string id, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataProvidersDiscoveryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Discover all data providers in my data my consent by country and filters.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedListOfDataProviders</returns>
        System.Threading.Tasks.Task<PaginatedListOfDataProviders> V1DataProvidersGetAsync(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Discover all data providers in my data my consent by country and filters.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedListOfDataProviders)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedListOfDataProviders>> V1DataProvidersGetWithHttpInfoAsync(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a data provider details by provider id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataProviderDetails</returns>
        System.Threading.Tasks.Task<DataProviderDetails> V1DataProvidersIdGetAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a data provider details by provider id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataProviderDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataProviderDetails>> V1DataProvidersIdGetWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataProvidersDiscoveryApi : IDataProvidersDiscoveryApiSync, IDataProvidersDiscoveryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataProvidersDiscoveryApi : IDataProvidersDiscoveryApi
    {
        private MyDataMyConsent.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataProvidersDiscoveryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataProvidersDiscoveryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataProvidersDiscoveryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataProvidersDiscoveryApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DataProvidersDiscoveryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataProvidersDiscoveryApi(MyDataMyConsent.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DataProvidersDiscoveryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DataProvidersDiscoveryApi(MyDataMyConsent.Client.ISynchronousClient client, MyDataMyConsent.Client.IAsynchronousClient asyncClient, MyDataMyConsent.Client.IReadableConfiguration configuration)
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
        /// Discover all data providers in my data my consent by country and filters. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PaginatedListOfDataProviders</returns>
        public PaginatedListOfDataProviders V1DataProvidersGet(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0)
        {
            MyDataMyConsent.Client.ApiResponse<PaginatedListOfDataProviders> localVarResponse = V1DataProvidersGetWithHttpInfo(countryIso2Code, pageNo, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Discover all data providers in my data my consent by country and filters. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PaginatedListOfDataProviders</returns>
        public MyDataMyConsent.Client.ApiResponse<PaginatedListOfDataProviders> V1DataProvidersGetWithHttpInfo(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'countryIso2Code' is set
            if (countryIso2Code == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'countryIso2Code' when calling DataProvidersDiscoveryApi->V1DataProvidersGet");
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

            localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "country_iso2_code", countryIso2Code));
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "DataProvidersDiscoveryApi.V1DataProvidersGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2ClientCredentials) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedListOfDataProviders>("/v1/data-providers", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DataProvidersGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Discover all data providers in my data my consent by country and filters. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedListOfDataProviders</returns>
        public async System.Threading.Tasks.Task<PaginatedListOfDataProviders> V1DataProvidersGetAsync(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MyDataMyConsent.Client.ApiResponse<PaginatedListOfDataProviders> localVarResponse = await V1DataProvidersGetWithHttpInfoAsync(countryIso2Code, pageNo, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Discover all data providers in my data my consent by country and filters. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryIso2Code"></param>
        /// <param name="pageNo"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedListOfDataProviders)</returns>
        public async System.Threading.Tasks.Task<MyDataMyConsent.Client.ApiResponse<PaginatedListOfDataProviders>> V1DataProvidersGetWithHttpInfoAsync(string countryIso2Code, int? pageNo = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'countryIso2Code' is set
            if (countryIso2Code == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'countryIso2Code' when calling DataProvidersDiscoveryApi->V1DataProvidersGet");
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

            localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "country_iso2_code", countryIso2Code));
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(MyDataMyConsent.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "DataProvidersDiscoveryApi.V1DataProvidersGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2ClientCredentials) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PaginatedListOfDataProviders>("/v1/data-providers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DataProvidersGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a data provider details by provider id. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DataProviderDetails</returns>
        public DataProviderDetails V1DataProvidersIdGet(string id, int operationIndex = 0)
        {
            MyDataMyConsent.Client.ApiResponse<DataProviderDetails> localVarResponse = V1DataProvidersIdGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a data provider details by provider id. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DataProviderDetails</returns>
        public MyDataMyConsent.Client.ApiResponse<DataProviderDetails> V1DataProvidersIdGetWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'id' when calling DataProvidersDiscoveryApi->V1DataProvidersIdGet");
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

            localVarRequestOptions.PathParameters.Add("id", MyDataMyConsent.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "DataProvidersDiscoveryApi.V1DataProvidersIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2ClientCredentials) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DataProviderDetails>("/v1/data-providers/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DataProvidersIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a data provider details by provider id. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataProviderDetails</returns>
        public async System.Threading.Tasks.Task<DataProviderDetails> V1DataProvidersIdGetAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MyDataMyConsent.Client.ApiResponse<DataProviderDetails> localVarResponse = await V1DataProvidersIdGetWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a data provider details by provider id. 
        /// </summary>
        /// <exception cref="MyDataMyConsent.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataProviderDetails)</returns>
        public async System.Threading.Tasks.Task<MyDataMyConsent.Client.ApiResponse<DataProviderDetails>> V1DataProvidersIdGetWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new MyDataMyConsent.Client.ApiException(400, "Missing required parameter 'id' when calling DataProvidersDiscoveryApi->V1DataProvidersIdGet");
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

            localVarRequestOptions.PathParameters.Add("id", MyDataMyConsent.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "DataProvidersDiscoveryApi.V1DataProvidersIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2ClientCredentials) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DataProviderDetails>("/v1/data-providers/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1DataProvidersIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}