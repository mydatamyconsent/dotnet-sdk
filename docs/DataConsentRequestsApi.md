# MyDataMyConsent.Sdk.Api.DataConsentRequestsApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelIndividualDataConsentRequest**](DataConsentRequestsApi.md#cancelindividualdataconsentrequest) | **PUT** /v1/consent-requests/individual/{requestId}/cancel | Cancel the individual data consent request by Id.
[**CancelOrganizationDataConsentRequest**](DataConsentRequestsApi.md#cancelorganizationdataconsentrequest) | **PUT** /v1/consent-requests/organization/{requestId}/cancel | Cancel the organization data consent request by Id.
[**CreateIndividualDataConsentRequest**](DataConsentRequestsApi.md#createindividualdataconsentrequest) | **POST** /v1/consent-requests/individual | Create data consent request for an individual.
[**CreateOrganizationDataConsentRequest**](DataConsentRequestsApi.md#createorganizationdataconsentrequest) | **POST** /v1/consent-requests/organization | Create data consent request for an organization.
[**GetAllConsentRequestsToIndividuals**](DataConsentRequestsApi.md#getallconsentrequeststoindividuals) | **GET** /v1/consent-requests/individuals | Get all Consent Requests sent to individuals.
[**GetAllConsentRequestsToOrganizations**](DataConsentRequestsApi.md#getallconsentrequeststoorganizations) | **GET** /v1/consent-requests/organizations | Get all Consent Requests sent to organizations.
[**GetIndividualConsentRequestById**](DataConsentRequestsApi.md#getindividualconsentrequestbyid) | **GET** /v1/consent-requests/individuals/{requestId} | Get individual data consent request by id.
[**GetOrganizationConsentRequestById**](DataConsentRequestsApi.md#getorganizationconsentrequestbyid) | **GET** /v1/consent-requests/organizations/{requestId} | Get a OrganizationConsent Request by Id.


<a name="cancelindividualdataconsentrequest"></a>
# **CancelIndividualDataConsentRequest**
> void CancelIndividualDataConsentRequest (Guid requestId)

Cancel the individual data consent request by Id.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Individual consent request id.

            try
            {
                // Cancel the individual data consent request by Id.
                apiInstance.CancelIndividualDataConsentRequest(requestId);
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

void (empty response body)

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
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelorganizationdataconsentrequest"></a>
# **CancelOrganizationDataConsentRequest**
> void CancelOrganizationDataConsentRequest (Guid requestId)

Cancel the organization data consent request by Id.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Organization consent request id.

            try
            {
                // Cancel the organization data consent request by Id.
                apiInstance.CancelOrganizationDataConsentRequest(requestId);
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

void (empty response body)

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
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createindividualdataconsentrequest"></a>
# **CreateIndividualDataConsentRequest**
> IndividualDataConsentRequestDetails CreateIndividualDataConsentRequest (CreateDataConsentRequest createDataConsentRequest)

Create data consent request for an individual.

Create data consent request for an individual.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var createDataConsentRequest = new CreateDataConsentRequest(); // CreateDataConsentRequest | The Individual data consent request payload

            try
            {
                // Create data consent request for an individual.
                IndividualDataConsentRequestDetails result = apiInstance.CreateIndividualDataConsentRequest(createDataConsentRequest);
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
 **createDataConsentRequest** | [**CreateDataConsentRequest**](CreateDataConsentRequest.md)| The Individual data consent request payload | 

### Return type

[**IndividualDataConsentRequestDetails**](IndividualDataConsentRequestDetails.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorganizationdataconsentrequest"></a>
# **CreateOrganizationDataConsentRequest**
> OrganizationDataConsentRequestDetails CreateOrganizationDataConsentRequest (CreateDataConsentRequest createDataConsentRequest)

Create data consent request for an organization.

Create data consent request for an organization.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var createDataConsentRequest = new CreateDataConsentRequest(); // CreateDataConsentRequest | The Organization data consent request payload

            try
            {
                // Create data consent request for an organization.
                OrganizationDataConsentRequestDetails result = apiInstance.CreateOrganizationDataConsentRequest(createDataConsentRequest);
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
 **createDataConsentRequest** | [**CreateDataConsentRequest**](CreateDataConsentRequest.md)| The Organization data consent request payload | 

### Return type

[**OrganizationDataConsentRequestDetails**](OrganizationDataConsentRequestDetails.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsentrequeststoindividuals"></a>
# **GetAllConsentRequestsToIndividuals**
> IndividualDataConsentRequestDetailsPaginatedList GetAllConsentRequestsToIndividuals (DataConsentStatus? status = null, DateTime? startDateTime = null, DateTime? endDateTime = null, int? pageNo = null, int? pageSize = null)

Get all Consent Requests sent to individuals.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var startDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start datetime in UTC timezone. (optional) 
            var endDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End datetime in UTC timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get all Consent Requests sent to individuals.
                IndividualDataConsentRequestDetailsPaginatedList result = apiInstance.GetAllConsentRequestsToIndividuals(status, startDateTime, endDateTime, pageNo, pageSize);
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
 **startDateTime** | **DateTime?**| Start datetime in UTC timezone. | [optional] 
 **endDateTime** | **DateTime?**| End datetime in UTC timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**IndividualDataConsentRequestDetailsPaginatedList**](IndividualDataConsentRequestDetailsPaginatedList.md)

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsentrequeststoorganizations"></a>
# **GetAllConsentRequestsToOrganizations**
> OrganizationDataConsentRequestDetailsPaginatedList GetAllConsentRequestsToOrganizations (DataConsentStatus? status = null, DateTime? startDateTime = null, DateTime? endDateTime = null, int? pageNo = null, int? pageSize = null)

Get all Consent Requests sent to organizations.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var startDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Start datetime in UTC timezone. (optional) 
            var endDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | End datetime in UTC timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get all Consent Requests sent to organizations.
                OrganizationDataConsentRequestDetailsPaginatedList result = apiInstance.GetAllConsentRequestsToOrganizations(status, startDateTime, endDateTime, pageNo, pageSize);
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
 **startDateTime** | **DateTime?**| Start datetime in UTC timezone. | [optional] 
 **endDateTime** | **DateTime?**| End datetime in UTC timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**OrganizationDataConsentRequestDetailsPaginatedList**](OrganizationDataConsentRequestDetailsPaginatedList.md)

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindividualconsentrequestbyid"></a>
# **GetIndividualConsentRequestById**
> DataConsentRequest GetIndividualConsentRequestById (Guid requestId)

Get individual data consent request by id.

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Individual data consent request id.

            try
            {
                // Get individual data consent request by id.
                DataConsentRequest result = apiInstance.GetIndividualConsentRequestById(requestId);
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
 **requestId** | **Guid**| Individual data consent request id. | 

### Return type

[**DataConsentRequest**](DataConsentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationconsentrequestbyid"></a>
# **GetOrganizationConsentRequestById**
> DataConsentRequest GetOrganizationConsentRequestById (Guid requestId)

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
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = "requestId_example";  // Guid | Organization consent request id.

            try
            {
                // Get a OrganizationConsent Request by Id.
                DataConsentRequest result = apiInstance.GetOrganizationConsentRequestById(requestId);
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

[**DataConsentRequest**](DataConsentRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

