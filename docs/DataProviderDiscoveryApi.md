# MyDataMyConsent.Api.DataProviderDiscoveryApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1DataProvidersGet**](DataProviderDiscoveryApi.md#v1dataprovidersget) | **GET** /v1/data-providers | Discover all data providers in My Data My Consent by country and filters.
[**V1DataProvidersProviderIdGet**](DataProviderDiscoveryApi.md#v1dataprovidersprovideridget) | **GET** /v1/data-providers/{providerId} | Get a Data Provider details.


<a name="v1dataprovidersget"></a>
# **V1DataProvidersGet**
> DataProviderPaginatedList V1DataProvidersGet (string accountType = null, string documentType = null, string organizationCategory = null, int? pageNo = null, int? pageSize = null, string country = null)

Discover all data providers in My Data My Consent by country and filters.

.

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
            config.BasePath = "http://localhost";
            var apiInstance = new DataProviderDiscoveryApi(config);
            var accountType = accountType_example;  // string | Account type. (optional) 
            var documentType = documentType_example;  // string | Document type. (optional) 
            var organizationCategory = organizationCategory_example;  // string | Organization category. (optional) 
            var pageNo = 56;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size. (optional)  (default to 25)
            var country = country_example;  // string | ISO2 Country code. (optional)  (default to "IN")

            try
            {
                // Discover all data providers in My Data My Consent by country and filters.
                DataProviderPaginatedList result = apiInstance.V1DataProvidersGet(accountType, documentType, organizationCategory, pageNo, pageSize, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProviderDiscoveryApi.V1DataProvidersGet: " + e.Message );
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
 **pageSize** | **int?**| Page size. | [optional] [default to 25]
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
| **200** | OK. |  -  |
| **401** | Unauthorized. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataprovidersprovideridget"></a>
# **V1DataProvidersProviderIdGet**
> DataProvider V1DataProvidersProviderIdGet (string providerId)

Get a Data Provider details.

.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataProvidersProviderIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProviderDiscoveryApi(config);
            var providerId = providerId_example;  // string | Provider Id.

            try
            {
                // Get a Data Provider details.
                DataProvider result = apiInstance.V1DataProvidersProviderIdGet(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProviderDiscoveryApi.V1DataProvidersProviderIdGet: " + e.Message );
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
 **providerId** | **string**| Provider Id. | 

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
| **200** | OK. |  -  |
| **401** | Unauthorized. |  -  |
| **500** | Internal Server Error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

