# MyDataMyConsent.Api.DataProvidersDiscoveryApi

All URIs are relative to *https://api.mydatamyconsent.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1DataProvidersGet**](DataProvidersDiscoveryApi.md#v1dataprovidersget) | **GET** /v1/data-providers | Discover all data providers in my data my consent by country and filters. |
| [**V1DataProvidersIdGet**](DataProvidersDiscoveryApi.md#v1dataprovidersidget) | **GET** /v1/data-providers/{id} | Get a data provider details by provider id. |

<a name="v1dataprovidersget"></a>
# **V1DataProvidersGet**
> PaginatedListOfDataProviders V1DataProvidersGet (string countryIso2Code, int? pageNo = null, int? pageSize = null)

Discover all data providers in my data my consent by country and filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataProvidersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProvidersDiscoveryApi(config);
            var countryIso2Code = "countryIso2Code_example";  // string | 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Discover all data providers in my data my consent by country and filters.
                PaginatedListOfDataProviders result = apiInstance.V1DataProvidersGet(countryIso2Code, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProvidersDiscoveryApi.V1DataProvidersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataProvidersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Discover all data providers in my data my consent by country and filters.
    ApiResponse<PaginatedListOfDataProviders> response = apiInstance.V1DataProvidersGetWithHttpInfo(countryIso2Code, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProvidersDiscoveryApi.V1DataProvidersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **countryIso2Code** | **string** |  |  |
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfDataProviders**](PaginatedListOfDataProviders.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataprovidersidget"></a>
# **V1DataProvidersIdGet**
> DataProviderDetails V1DataProvidersIdGet (string id)

Get a data provider details by provider id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataProvidersIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProvidersDiscoveryApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Get a data provider details by provider id.
                DataProviderDetails result = apiInstance.V1DataProvidersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProvidersDiscoveryApi.V1DataProvidersIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataProvidersIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a data provider details by provider id.
    ApiResponse<DataProviderDetails> response = apiInstance.V1DataProvidersIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProvidersDiscoveryApi.V1DataProvidersIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**DataProviderDetails**](DataProviderDetails.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

