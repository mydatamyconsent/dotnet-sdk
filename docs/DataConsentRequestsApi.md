# MyDataMyConsent.Sdk.Api.DataConsentRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelIndividualDataConsentRequest**](DataConsentRequestsApi.md#cancelindividualdataconsentrequest) | **PUT** /v1/consent-requests/individual/{requestId}/cancel | Cancel the individual data consent request based on Id.
[**CancelOrganizationDataConsentRequest**](DataConsentRequestsApi.md#cancelorganizationdataconsentrequest) | **PUT** /v1/consent-requests/organization/{requestId}/cancel | Cancel the Organization data consent request based on Id.
[**CreateIndividualDataConsentRequest**](DataConsentRequestsApi.md#createindividualdataconsentrequest) | **POST** /v1/consent-requests/individual | Create a individual data consent request.
[**CreateOrganizationDataConsentRequest**](DataConsentRequestsApi.md#createorganizationdataconsentrequest) | **POST** /v1/consent-requests/organization | Create a organization data consent request.
[**GetAllConsentRequestsToIndividuals**](DataConsentRequestsApi.md#getallconsentrequeststoindividuals) | **GET** /v1/consent-requests/individuals | Get all Consent Requests sent to Individuals.
[**GetAllConsentRequestsToOrganizations**](DataConsentRequestsApi.md#getallconsentrequeststoorganizations) | **GET** /v1/consent-requests/organizations | Get All Consent Requests sent to Organizations.
[**GetIndividualConsentRequestById**](DataConsentRequestsApi.md#getindividualconsentrequestbyid) | **GET** /v1/consent-requests/individuals/{requestId} | Get a Consent Request by ID.
[**GetOrganizationConsentRequestById**](DataConsentRequestsApi.md#getorganizationconsentrequestbyid) | **GET** /v1/consent-requests/organizations/{requestId} | Get a OrganizationConsent Request by Id.


<a name="cancelindividualdataconsentrequest"></a>
# **CancelIndividualDataConsentRequest**
> IndividualDataConsentRequestResponse CancelIndividualDataConsentRequest (Guid requestId)

Cancel the individual data consent request based on Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class CancelIndividualDataConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Individual consent request id.

            try
            {
                // Cancel the individual data consent request based on Id.
                IndividualDataConsentRequestResponse result = apiInstance.CancelIndividualDataConsentRequest(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CancelIndividualDataConsentRequest: " + e.Message );
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
 **requestId** | **Guid**| Individual consent request id. | 

### Return type

[**IndividualDataConsentRequestResponse**](IndividualDataConsentRequestResponse.md)

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
| **404** | Not Found |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorganizationdataconsentrequest"></a>
# **CancelOrganizationDataConsentRequest**
> OrganizationDataConsentRequestResponse CancelOrganizationDataConsentRequest (Guid requestId)

Cancel the Organization data consent request based on Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class CancelOrganizationDataConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Organization consent request id.

            try
            {
                // Cancel the Organization data consent request based on Id.
                OrganizationDataConsentRequestResponse result = apiInstance.CancelOrganizationDataConsentRequest(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CancelOrganizationDataConsentRequest: " + e.Message );
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
 **requestId** | **Guid**| Organization consent request id. | 

### Return type

[**OrganizationDataConsentRequestResponse**](OrganizationDataConsentRequestResponse.md)

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
| **404** | Not Found |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createindividualdataconsentrequest"></a>
# **CreateIndividualDataConsentRequest**
> IndividualDataConsentRequestResponse CreateIndividualDataConsentRequest (CreateIndividualDataConsentRequest createIndividualDataConsentRequest)

Create a individual data consent request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class CreateIndividualDataConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var createIndividualDataConsentRequest = new CreateIndividualDataConsentRequest(); // CreateIndividualDataConsentRequest | M:MyDataMyConsent.DeveloperApi.Controllers.DataConsentRequestsController.CreateIndividualDataConsentRequest(MyDataMyConsent.DeveloperApi.Models.CreateIndividualDataConsentRequest).

            try
            {
                // Create a individual data consent request.
                IndividualDataConsentRequestResponse result = apiInstance.CreateIndividualDataConsentRequest(createIndividualDataConsentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CreateIndividualDataConsentRequest: " + e.Message );
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
 **createIndividualDataConsentRequest** | [**CreateIndividualDataConsentRequest**](CreateIndividualDataConsentRequest.md)| M:MyDataMyConsent.DeveloperApi.Controllers.DataConsentRequestsController.CreateIndividualDataConsentRequest(MyDataMyConsent.DeveloperApi.Models.CreateIndividualDataConsentRequest). | 

### Return type

[**IndividualDataConsentRequestResponse**](IndividualDataConsentRequestResponse.md)

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
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorganizationdataconsentrequest"></a>
# **CreateOrganizationDataConsentRequest**
> OrganizationDataConsentRequestResponse CreateOrganizationDataConsentRequest (CreateOrganizationDataConsentRequest createOrganizationDataConsentRequest)

Create a organization data consent request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class CreateOrganizationDataConsentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var createOrganizationDataConsentRequest = new CreateOrganizationDataConsentRequest(); // CreateOrganizationDataConsentRequest | M:MyDataMyConsent.DeveloperApi.Controllers.DataConsentRequestsController.CreateOrganizationDataConsentRequest(MyDataMyConsent.DeveloperApi.Models.CreateOrganizationDataConsentRequest).

            try
            {
                // Create a organization data consent request.
                OrganizationDataConsentRequestResponse result = apiInstance.CreateOrganizationDataConsentRequest(createOrganizationDataConsentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CreateOrganizationDataConsentRequest: " + e.Message );
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
 **createOrganizationDataConsentRequest** | [**CreateOrganizationDataConsentRequest**](CreateOrganizationDataConsentRequest.md)| M:MyDataMyConsent.DeveloperApi.Controllers.DataConsentRequestsController.CreateOrganizationDataConsentRequest(MyDataMyConsent.DeveloperApi.Models.CreateOrganizationDataConsentRequest). | 

### Return type

[**OrganizationDataConsentRequestResponse**](OrganizationDataConsentRequestResponse.md)

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
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsentrequeststoindividuals"></a>
# **GetAllConsentRequestsToIndividuals**
> UserDataConsentInfoDtoPaginatedList GetAllConsentRequestsToIndividuals (DataConsentStatus? status = null, DateTime? startDateTime = null, DateTime? endDateTime = null, int? pageNo = null, int? pageSize = null)

Get all Consent Requests sent to Individuals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllConsentRequestsToIndividualsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var startDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start date time. (optional) 
            var endDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End date time. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get all Consent Requests sent to Individuals.
                UserDataConsentInfoDtoPaginatedList result = apiInstance.GetAllConsentRequestsToIndividuals(status, startDateTime, endDateTime, pageNo, pageSize);
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
 **status** | [**DataConsentStatus?**](DataConsentStatus?.md)| Data consent status. | [optional] 
 **startDateTime** | **DateTime?**| Start date time. | [optional] 
 **endDateTime** | **DateTime?**| End date time. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**UserDataConsentInfoDtoPaginatedList**](UserDataConsentInfoDtoPaginatedList.md)

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
> OrganizationDataConsentInfoDtoPaginatedList GetAllConsentRequestsToOrganizations (DataConsentStatus? status = null, DateTime? startDateTime = null, DateTime? endDateTime = null, int? pageNo = null, int? pageSize = null)

Get All Consent Requests sent to Organizations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllConsentRequestsToOrganizationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var startDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start date time. (optional) 
            var endDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End date time. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get All Consent Requests sent to Organizations.
                OrganizationDataConsentInfoDtoPaginatedList result = apiInstance.GetAllConsentRequestsToOrganizations(status, startDateTime, endDateTime, pageNo, pageSize);
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
 **status** | [**DataConsentStatus?**](DataConsentStatus?.md)| Data consent status. | [optional] 
 **startDateTime** | **DateTime?**| Start date time. | [optional] 
 **endDateTime** | **DateTime?**| End date time. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**OrganizationDataConsentInfoDtoPaginatedList**](OrganizationDataConsentInfoDtoPaginatedList.md)

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
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetIndividualConsentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Individual consent request id.

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
 **requestId** | **Guid**| Individual consent request id. | 

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

Get a OrganizationConsent Request by Id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationConsentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Organization consent request id.

            try
            {
                // Get a OrganizationConsent Request by Id.
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
 **requestId** | **Guid**| Organization consent request id. | 

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

