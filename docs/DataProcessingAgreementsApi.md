# MyDataMyConsent.Api.DataProcessingAgreementsApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDataProcessingAgreement**](DataProcessingAgreementsApi.md#createdataprocessingagreement) | **POST** /v1/data-agreements | Create a data processing agreement.
[**DeleteDataProcessingAgreementById**](DataProcessingAgreementsApi.md#deletedataprocessingagreementbyid) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
[**GetDataProcessingAgreementById**](DataProcessingAgreementsApi.md#getdataprocessingagreementbyid) | **GET** /v1/data-agreements/{id} | Get data processing agreement by id.
[**GetDataProcessingAgreements**](DataProcessingAgreementsApi.md#getdataprocessingagreements) | **GET** /v1/data-agreements | Get paginated data processing agreements.
[**TerminateDataProcessingAgreementById**](DataProcessingAgreementsApi.md#terminatedataprocessingagreementbyid) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement.
[**UpdateDataProcessingAgreement**](DataProcessingAgreementsApi.md#updatedataprocessingagreement) | **PUT** /v1/data-agreements/{id} | Update a data processing agreement.


<a name="createdataprocessingagreement"></a>
# **CreateDataProcessingAgreement**
> DataProcessingAgreement CreateDataProcessingAgreement (CreateDataProcessingAgreement createDataProcessingAgreement)

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
    public class CreateDataProcessingAgreementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var createDataProcessingAgreement = new CreateDataProcessingAgreement(); // CreateDataProcessingAgreement | Create data processing agreement payload

            try
            {
                // Create a data processing agreement.
                DataProcessingAgreement result = apiInstance.CreateDataProcessingAgreement(createDataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.CreateDataProcessingAgreement: " + e.Message );
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
 **createDataProcessingAgreement** | [**CreateDataProcessingAgreement**](CreateDataProcessingAgreement.md)| Create data processing agreement payload | 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedataprocessingagreementbyid"></a>
# **DeleteDataProcessingAgreementById**
> void DeleteDataProcessingAgreementById (Guid id)

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
    public class DeleteDataProcessingAgreementByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // Guid | Agreement id.

            try
            {
                // Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
                apiInstance.DeleteDataProcessingAgreementById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.DeleteDataProcessingAgreementById: " + e.Message );
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
 **id** | **Guid**| Agreement id. | 

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataprocessingagreementbyid"></a>
# **GetDataProcessingAgreementById**
> DataProcessingAgreement GetDataProcessingAgreementById (Guid id)

Get data processing agreement by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetDataProcessingAgreementByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // Guid | Agreement id.

            try
            {
                // Get data processing agreement by id.
                DataProcessingAgreement result = apiInstance.GetDataProcessingAgreementById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.GetDataProcessingAgreementById: " + e.Message );
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
 **id** | **Guid**| Agreement id. | 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataprocessingagreements"></a>
# **GetDataProcessingAgreements**
> DataProcessingAgreementPaginatedList GetDataProcessingAgreements (int? pageNo = null, int? pageSize = null)

Get paginated data processing agreements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetDataProcessingAgreementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get paginated data processing agreements.
                DataProcessingAgreementPaginatedList result = apiInstance.GetDataProcessingAgreements(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.GetDataProcessingAgreements: " + e.Message );
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terminatedataprocessingagreementbyid"></a>
# **TerminateDataProcessingAgreementById**
> void TerminateDataProcessingAgreementById (Guid id)

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
    public class TerminateDataProcessingAgreementByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // Guid | Agreement id.

            try
            {
                // Terminate a data processing agreement.
                apiInstance.TerminateDataProcessingAgreementById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.TerminateDataProcessingAgreementById: " + e.Message );
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
 **id** | **Guid**| Agreement id. | 

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedataprocessingagreement"></a>
# **UpdateDataProcessingAgreement**
> DataProcessingAgreement UpdateDataProcessingAgreement (Guid id, UpdateDataProcessingAgreement updateDataProcessingAgreement)

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
    public class UpdateDataProcessingAgreementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // Guid | Agreement id.
            var updateDataProcessingAgreement = new UpdateDataProcessingAgreement(); // UpdateDataProcessingAgreement | Update data processing agreement payload

            try
            {
                // Update a data processing agreement.
                DataProcessingAgreement result = apiInstance.UpdateDataProcessingAgreement(id, updateDataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.UpdateDataProcessingAgreement: " + e.Message );
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
 **id** | **Guid**| Agreement id. | 
 **updateDataProcessingAgreement** | [**UpdateDataProcessingAgreement**](UpdateDataProcessingAgreement.md)| Update data processing agreement payload | 

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

