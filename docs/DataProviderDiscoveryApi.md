# MyDataMyConsent.Sdk.Api.DataProviderDiscoveryApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataProviderById**](DataProviderDiscoveryApi.md#getdataproviderbyid) | **GET** /v1/data-providers/{providerId} | Get a Data Provider details based on provider id.
[**GetDataProviders**](DataProviderDiscoveryApi.md#getdataproviders) | **GET** /v1/data-providers | Discover all data providers in My Data My Consent by country and filters.


<a name="getdataproviderbyid"></a>
# **GetDataProviderById**
> DataProvider GetDataProviderById (string providerId)

Get a Data Provider details based on provider id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetDataProviderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProviderDiscoveryApi(config);
            var providerId = "providerId_example";  // string | Provider id.

            try
            {
                // Get a Data Provider details based on provider id.
                DataProvider result = apiInstance.GetDataProviderById(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProviderDiscoveryApi.GetDataProviderById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **providerId** | **string**| Provider id. | 

### Return type

[**DataProvider**](DataProvider.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataproviders"></a>
# **GetDataProviders**
> DataProviderPaginatedList GetDataProviders (string accountType = null, string documentType = null, string organizationCategory = null, int? pageNo = null, int? pageSize = null, string country = null)

Discover all data providers in My Data My Consent by country and filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetDataProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProviderDiscoveryApi(config);
            var accountType = "accountType_example";  // string | Account type. (optional) 
            var documentType = "documentType_example";  // string | Document type. (optional) 
            var organizationCategory = "organizationCategory_example";  // string | Organization category. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)
            var country = "\"IN\"";  // string | ISO2 Country code. (optional)  (default to "IN")

            try
            {
                // Discover all data providers in My Data My Consent by country and filters.
                DataProviderPaginatedList result = apiInstance.GetDataProviders(accountType, documentType, organizationCategory, pageNo, pageSize, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProviderDiscoveryApi.GetDataProviders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountType** | **string**| Account type. | [optional] 
 **documentType** | **string**| Document type. | [optional] 
 **organizationCategory** | **string**| Organization category. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]
 **country** | **string**| ISO2 Country code. | [optional] [default to &quot;IN&quot;]

### Return type

[**DataProviderPaginatedList**](DataProviderPaginatedList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

