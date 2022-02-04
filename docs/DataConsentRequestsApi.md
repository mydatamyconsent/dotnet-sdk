# MyDataMyConsent.Api.DataConsentRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelConsentRequest**](DataConsentRequestsApi.md#cancelconsentrequest) | **DELETE** /v1/consent-requests/{requestId}/cancel | Revoke / Cancel the ConsentRequest based on Id.
[**CreateRequest**](DataConsentRequestsApi.md#createrequest) | **POST** /v1/consent-requests | Create a consent request.
[**GetAllConsentRequestsToIndividuals**](DataConsentRequestsApi.md#getallconsentrequeststoindividuals) | **GET** /v1/consent-requests/individuals | Get all Consent Requests sent to Individuals.
[**GetAllConsentRequestsToOrganizations**](DataConsentRequestsApi.md#getallconsentrequeststoorganizations) | **GET** /v1/consent-requests/organizations | Get All Consent Requests sent to Organizations
[**GetIndividualConsentRequestById**](DataConsentRequestsApi.md#getindividualconsentrequestbyid) | **GET** /v1/consent-requests/individuals/{requestId} | Get a Consent Request by ID.
[**GetOrganizationConsentRequestById**](DataConsentRequestsApi.md#getorganizationconsentrequestbyid) | **GET** /v1/consent-requests/organizations/{requestId} | Get a OrganizationConsent Request by Id


<a name="cancelconsentrequest"></a>
# **CancelConsentRequest**
> bool CancelConsentRequest (Guid requestId)

Revoke / Cancel the ConsentRequest based on Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class CancelConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

            try
            {
                // Revoke / Cancel the ConsentRequest based on Id.
                bool result = apiInstance.CancelConsentRequest(requestId);
                Debug.WriteLine(result);
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
 **requestId** | **Guid**|  | 

### Return type

**bool**

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

<a name="createrequest"></a>
# **CreateRequest**
> bool CreateRequest (DataConsentRequestModel dataConsentRequestModel = null)

Create a consent request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

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
                bool result = apiInstance.CreateRequest(dataConsentRequestModel);
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

**bool**

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

<a name="getallconsentrequeststoindividuals"></a>
# **GetAllConsentRequestsToIndividuals**
> Object GetAllConsentRequestsToIndividuals (int? pageNo = null, int? pageSize = null, DataConsentStatus? status = null)

Get all Consent Requests sent to Individuals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetAllConsentRequestsToIndividualsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var status = ;  // DataConsentStatus? |  (optional) 

            try
            {
                // Get all Consent Requests sent to Individuals.
                Object result = apiInstance.GetAllConsentRequestsToIndividuals(pageNo, pageSize, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetAllConsentRequestsToIndividuals: " + e.Message );
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
 **pageNo** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **status** | **DataConsentStatus?**|  | [optional] 

### Return type

**Object**

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

<a name="getallconsentrequeststoorganizations"></a>
# **GetAllConsentRequestsToOrganizations**
> Object GetAllConsentRequestsToOrganizations (int? pageNo = null, int? pageSize = null, DataConsentStatus? status = null)

Get All Consent Requests sent to Organizations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetAllConsentRequestsToOrganizationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var status = ;  // DataConsentStatus? |  (optional) 

            try
            {
                // Get All Consent Requests sent to Organizations
                Object result = apiInstance.GetAllConsentRequestsToOrganizations(pageNo, pageSize, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetAllConsentRequestsToOrganizations: " + e.Message );
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
 **pageNo** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **status** | **DataConsentStatus?**|  | [optional] 

### Return type

**Object**

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

<a name="getindividualconsentrequestbyid"></a>
# **GetIndividualConsentRequestById**
> DataConsentDetailsDto GetIndividualConsentRequestById (Guid requestId)

Get a Consent Request by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetIndividualConsentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

            try
            {
                // Get a Consent Request by ID.
                DataConsentDetailsDto result = apiInstance.GetIndividualConsentRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetIndividualConsentRequestById: " + e.Message );
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
 **requestId** | **Guid**|  | 

### Return type

[**DataConsentDetailsDto**](DataConsentDetailsDto.md)

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

<a name="getorganizationconsentrequestbyid"></a>
# **GetOrganizationConsentRequestById**
> DataConsentDetailsDto GetOrganizationConsentRequestById (Guid requestId)

Get a OrganizationConsent Request by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class GetOrganizationConsentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = 38400000-8cf0-11bd-b23e-10b96e4ef00d;  // Guid | 

            try
            {
                // Get a OrganizationConsent Request by Id
                DataConsentDetailsDto result = apiInstance.GetOrganizationConsentRequestById(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.GetOrganizationConsentRequestById: " + e.Message );
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
 **requestId** | **Guid**|  | 

### Return type

[**DataConsentDetailsDto**](DataConsentDetailsDto.md)

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

