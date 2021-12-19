# com.mydatamyconsent.Api.DataProcessingAgreementsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1DataAgreementsGet**](DataProcessingAgreementsApi.md#v1dataagreementsget) | **GET** /v1/data-agreements | Get all data processing agreements.
[**V1DataAgreementsIdDelete**](DataProcessingAgreementsApi.md#v1dataagreementsiddelete) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
[**V1DataAgreementsIdGet**](DataProcessingAgreementsApi.md#v1dataagreementsidget) | **GET** /v1/data-agreements/{id} | Get data processing agreement by Id.
[**V1DataAgreementsIdPut**](DataProcessingAgreementsApi.md#v1dataagreementsidput) | **PUT** /v1/data-agreements/{id} | Update a data processing agreement.
[**V1DataAgreementsIdTerminatePut**](DataProcessingAgreementsApi.md#v1dataagreementsidterminateput) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement.
[**V1DataAgreementsPost**](DataProcessingAgreementsApi.md#v1dataagreementspost) | **POST** /v1/data-agreements | Create a data processing agreement.


<a name="v1dataagreementsget"></a>
# **V1DataAgreementsGet**
> DataProcessingAgreementPaginatedList V1DataAgreementsGet (int? pageNo = null, int? pageSize = null)

Get all data processing agreements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var pageNo = 56;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 56;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get all data processing agreements.
                DataProcessingAgreementPaginatedList result = apiInstance.V1DataAgreementsGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsGet: " + e.Message );
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
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**DataProcessingAgreementPaginatedList**](DataProcessingAgreementPaginatedList.md)

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementsiddelete"></a>
# **V1DataAgreementsIdDelete**
> void V1DataAgreementsIdDelete (Guid id)

Delete a data processing agreement. This will not delete a published or a agreement in use with consents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
                apiInstance.V1DataAgreementsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdDelete: " + e.Message );
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
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementsidget"></a>
# **V1DataAgreementsIdGet**
> DataProcessingAgreement V1DataAgreementsIdGet (Guid id)

Get data processing agreement by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Get data processing agreement by Id.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdGet: " + e.Message );
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
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementsidput"></a>
# **V1DataAgreementsIdPut**
> DataProcessingAgreement V1DataAgreementsIdPut (Guid id, DataProcessingAgreement dataProcessingAgreement = null)

Update a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = new Guid(); // Guid | 
            var dataProcessingAgreement = new DataProcessingAgreement(); // DataProcessingAgreement |  (optional) 

            try
            {
                // Update a data processing agreement.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsIdPut(id, dataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdPut: " + e.Message );
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
 **id** | [**Guid**](Guid.md)|  | 
 **dataProcessingAgreement** | [**DataProcessingAgreement**](DataProcessingAgreement.md)|  | [optional] 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementsidterminateput"></a>
# **V1DataAgreementsIdTerminatePut**
> void V1DataAgreementsIdTerminatePut (Guid id)

Terminate a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsIdTerminatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                // Terminate a data processing agreement.
                apiInstance.V1DataAgreementsIdTerminatePut(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdTerminatePut: " + e.Message );
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
 **id** | [**Guid**](Guid.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementspost"></a>
# **V1DataAgreementsPost**
> DataProcessingAgreement V1DataAgreementsPost (DataProcessingAgreement dataProcessingAgreement = null)

Create a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DataAgreementsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var dataProcessingAgreement = new DataProcessingAgreement(); // DataProcessingAgreement |  (optional) 

            try
            {
                // Create a data processing agreement.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsPost(dataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsPost: " + e.Message );
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
 **dataProcessingAgreement** | [**DataProcessingAgreement**](DataProcessingAgreement.md)|  | [optional] 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

