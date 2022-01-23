# MyDataMyConsent.Api.DataProcessingAgreementsApi

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
> DataProcessingAgreementDtoPaginatedList V1DataAgreementsGet (int? pageNo = null, int? pageSize = null)

Get all data processing agreements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

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
                DataProcessingAgreementDtoPaginatedList result = apiInstance.V1DataAgreementsGet(pageNo, pageSize);
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

[**DataProcessingAgreementDtoPaginatedList**](DataProcessingAgreementDtoPaginatedList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


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
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

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
 **id** | **Guid**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


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
> DataProcessingAgreementDto V1DataAgreementsIdGet (Guid id)

Get data processing agreement by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

            try
            {
                // Get data processing agreement by Id.
                DataProcessingAgreementDto result = apiInstance.V1DataAgreementsIdGet(id);
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
 **id** | **Guid**|  | 

### Return type

[**DataProcessingAgreementDto**](DataProcessingAgreementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1dataagreementsidput"></a>
# **V1DataAgreementsIdPut**
> DataProcessingAgreementDto V1DataAgreementsIdPut (Guid id, UpdateDataProcessingAgreementRequestModel updateDataProcessingAgreementRequestModel = null)

Update a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 
            var updateDataProcessingAgreementRequestModel = new UpdateDataProcessingAgreementRequestModel(); // UpdateDataProcessingAgreementRequestModel |  (optional) 

            try
            {
                // Update a data processing agreement.
                DataProcessingAgreementDto result = apiInstance.V1DataAgreementsIdPut(id, updateDataProcessingAgreementRequestModel);
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
 **id** | **Guid**|  | 
 **updateDataProcessingAgreementRequestModel** | [**UpdateDataProcessingAgreementRequestModel**](UpdateDataProcessingAgreementRequestModel.md)|  | [optional] 

### Return type

[**DataProcessingAgreementDto**](DataProcessingAgreementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


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
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdTerminatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

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
 **id** | **Guid**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


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
> DataProcessingAgreementDto V1DataAgreementsPost (CreateDataProcessingAgreementRequestModel createDataProcessingAgreementRequestModel = null)

Create a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var createDataProcessingAgreementRequestModel = new CreateDataProcessingAgreementRequestModel(); // CreateDataProcessingAgreementRequestModel |  (optional) 

            try
            {
                // Create a data processing agreement.
                DataProcessingAgreementDto result = apiInstance.V1DataAgreementsPost(createDataProcessingAgreementRequestModel);
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
 **createDataProcessingAgreementRequestModel** | [**CreateDataProcessingAgreementRequestModel**](CreateDataProcessingAgreementRequestModel.md)|  | [optional] 

### Return type

[**DataProcessingAgreementDto**](DataProcessingAgreementDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

