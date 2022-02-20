# MyDataMyConsent.Sdk.Api.DocumentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIssuedDocumentById**](DocumentsApi.md#getissueddocumentbyid) | **GET** /v1/documents/issued/{documentId} | Get issued document.
[**GetIssuedDocuments**](DocumentsApi.md#getissueddocuments) | **GET** /v1/documents/issued | Get issued documents.
[**GetRegisteredDocumentTypes**](DocumentsApi.md#getregistereddocumenttypes) | **GET** /v1/documents/types | Get registered document types.
[**IssueDocument**](DocumentsApi.md#issuedocument) | **POST** /v1/documents/issue | Issue a new document.


<a name="getissueddocumentbyid"></a>
# **GetIssuedDocumentById**
> void GetIssuedDocumentById (Guid documentId)

Get issued document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetIssuedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentId = "documentId_example";  // Guid | Document id.

            try
            {
                // Get issued document.
                apiInstance.GetIssuedDocumentById(documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetIssuedDocumentById: " + e.Message );
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
 **documentId** | **Guid**| Document id. | 

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
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getissueddocuments"></a>
# **GetIssuedDocuments**
> void GetIssuedDocuments (Guid? documentTypeId = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageSize = null, int? pageNo = null)

Get issued documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetIssuedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentTypeId = "documentTypeId_example";  // Guid? |  (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var pageNo = 1;  // int? |  (optional)  (default to 1)

            try
            {
                // Get issued documents.
                apiInstance.GetIssuedDocuments(documentTypeId, fromDateTime, toDateTime, pageSize, pageNo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetIssuedDocuments: " + e.Message );
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
 **documentTypeId** | **Guid?**|  | [optional] 
 **fromDateTime** | **DateTime?**|  | [optional] 
 **toDateTime** | **DateTime?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] [default to 25]
 **pageNo** | **int?**|  | [optional] [default to 1]

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
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistereddocumenttypes"></a>
# **GetRegisteredDocumentTypes**
> void GetRegisteredDocumentTypes (int? pageSize = null, int? pageNo = null)

Get registered document types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetRegisteredDocumentTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var pageNo = 1;  // int? |  (optional)  (default to 1)

            try
            {
                // Get registered document types.
                apiInstance.GetRegisteredDocumentTypes(pageSize, pageNo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetRegisteredDocumentTypes: " + e.Message );
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
 **pageSize** | **int?**|  | [optional] [default to 25]
 **pageNo** | **int?**|  | [optional] [default to 1]

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
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuedocument"></a>
# **IssueDocument**
> bool IssueDocument (DocumentIssueRequest documentIssueRequest)

Issue a new document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class IssueDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentIssueRequest = new DocumentIssueRequest(); // DocumentIssueRequest | MyDataMyConsent.Models.Documents.DocumentIssueRequest.

            try
            {
                // Issue a new document.
                bool result = apiInstance.IssueDocument(documentIssueRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.IssueDocument: " + e.Message );
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
 **documentIssueRequest** | [**DocumentIssueRequest**](DocumentIssueRequest.md)| MyDataMyConsent.Models.Documents.DocumentIssueRequest. | 

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
| **500** | Server Error |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

