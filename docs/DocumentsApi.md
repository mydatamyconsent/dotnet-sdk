# com.mydatamyconsent.Api.DocumentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IssueDocument**](DocumentsApi.md#issuedocument) | **POST** /v1/documents/issue | Issue a new document.
[**V1DocumentsIssuedDocumentIdGet**](DocumentsApi.md#v1documentsissueddocumentidget) | **GET** /v1/documents/issued/{documentId} | Get issued document.
[**V1DocumentsIssuedGet**](DocumentsApi.md#v1documentsissuedget) | **GET** /v1/documents/issued | Get issued documents.
[**V1DocumentsTypesGet**](DocumentsApi.md#v1documentstypesget) | **GET** /v1/documents/types | Get registered document types.


<a name="issuedocument"></a>
# **IssueDocument**
> bool IssueDocument (DocumentIssueRequest documentIssueRequest = null)

Issue a new document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class IssueDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentIssueRequest = new DocumentIssueRequest(); // DocumentIssueRequest |  (optional) 

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
 **documentIssueRequest** | [**DocumentIssueRequest**](DocumentIssueRequest.md)|  | [optional] 

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

<a name="v1documentsissueddocumentidget"></a>
# **V1DocumentsIssuedDocumentIdGet**
> void V1DocumentsIssuedDocumentIdGet (Guid documentId)

Get issued document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DocumentsIssuedDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentId = new Guid(); // Guid | Document id.

            try
            {
                // Get issued document.
                apiInstance.V1DocumentsIssuedDocumentIdGet(documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.V1DocumentsIssuedDocumentIdGet: " + e.Message );
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
 **documentId** | [**Guid**](Guid.md)| Document id. | 

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

<a name="v1documentsissuedget"></a>
# **V1DocumentsIssuedGet**
> void V1DocumentsIssuedGet (Guid? documentTypeId = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageSize = null, int? pageNo = null)

Get issued documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DocumentsIssuedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentTypeId = new Guid?(); // Guid? |  (optional) 
            var fromDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var toDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var pageNo = 56;  // int? |  (optional)  (default to 1)

            try
            {
                // Get issued documents.
                apiInstance.V1DocumentsIssuedGet(documentTypeId, fromDateTime, toDateTime, pageSize, pageNo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.V1DocumentsIssuedGet: " + e.Message );
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
 **documentTypeId** | [**Guid?**](Guid?.md)|  | [optional] 
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

<a name="v1documentstypesget"></a>
# **V1DocumentsTypesGet**
> void V1DocumentsTypesGet (int? pageSize = null, int? pageNo = null)

Get registered document types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class V1DocumentsTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var pageSize = 56;  // int? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 

            try
            {
                // Get registered document types.
                apiInstance.V1DocumentsTypesGet(pageSize, pageNo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.V1DocumentsTypesGet: " + e.Message );
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
 **pageSize** | **int?**|  | [optional] 
 **pageNo** | **int?**|  | [optional] 

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

