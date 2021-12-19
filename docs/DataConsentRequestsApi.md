# com.mydatamyconsent.Api.DataConsentRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelConsentRequest**](DataConsentRequestsApi.md#cancelconsentrequest) | **DELETE** /v1/consent-requests/{requestId}/cancel | Cancel a Consent Request by ID.
[**CreateRequest**](DataConsentRequestsApi.md#createrequest) | **POST** /v1/consent-requests | Create a consent request.
[**GetAllConsentRequests**](DataConsentRequestsApi.md#getallconsentrequests) | **GET** /v1/consent-requests | Get all Consent Requests.
[**GetConsentRequestById**](DataConsentRequestsApi.md#getconsentrequestbyid) | **GET** /v1/consent-requests/{requestId} | Get a Consent Request by ID.


<a name="cancelconsentrequest"></a>
# **CancelConsentRequest**
> void CancelConsentRequest (Guid requestId)

Cancel a Consent Request by ID.

.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class CancelConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = new Guid(); // Guid | consent request id.

            try
            {
                // Cancel a Consent Request by ID.
                apiInstance.CancelConsentRequest(requestId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CancelConsentRequest: " + e.Message );
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
 **requestId** | [**Guid**](Guid.md)| consent request id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrequest"></a>
# **CreateRequest**
> DataConsent CreateRequest (DataConsentRequestModel dataConsentRequestModel = null)

Create a consent request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class CreateRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var dataConsentRequestModel = new DataConsentRequestModel(); // DataConsentRequestModel | MyDataMyConsent.Models.Consents.DataConsentRequestModel. (optional) 

            try
            {
                // Create a consent request.
                DataConsent result = apiInstance.CreateRequest(dataConsentRequestModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CreateRequest: " + e.Message );
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
 **dataConsentRequestModel** | [**DataConsentRequestModel**](DataConsentRequestModel.md)| MyDataMyConsent.Models.Consents.DataConsentRequestModel. | [optional] 

### Return type

[**DataConsent**](DataConsent.md)

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

<a name="getallconsentrequests"></a>
# **GetAllConsentRequests**
> Object GetAllConsentRequests (DataConsentStatus? status = null)

Get all Consent Requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class GetAllConsentRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var status = ;  // DataConsentStatus? |  (optional) 

            try
            {
                // Get all Consent Requests.
                Object result = apiInstance.GetAllConsentRequests(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetAllConsentRequests: " + e.Message );
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
 **status** | **DataConsentStatus?**|  | [optional] 

### Return type

**Object**

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

<a name="getconsentrequestbyid"></a>
# **GetConsentRequestById**
> DataConsentDetailsDto GetConsentRequestById (Guid requestId)

Get a Consent Request by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class GetConsentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = new Guid(); // Guid | 

            try
            {
                // Get a Consent Request by ID.
                DataConsentDetailsDto result = apiInstance.GetConsentRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetConsentRequestById: " + e.Message );
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
 **requestId** | [**Guid**](Guid.md)|  | 

### Return type

[**DataConsentDetailsDto**](DataConsentDetailsDto.md)

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

