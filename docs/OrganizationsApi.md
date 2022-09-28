# MyDataMyConsent.Api.OrganizationsApi

All URIs are relative to *https://api.mydatamyconsent.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1OrganizationsConsentRequestsGet**](OrganizationsApi.md#v1organizationsconsentrequestsget) | **GET** /v1/organizations/consent-requests | Get all consent requests sent to Organizations. |
| [**V1OrganizationsConsentRequestsPost**](OrganizationsApi.md#v1organizationsconsentrequestspost) | **POST** /v1/organizations/consent-requests | Create consent request for an Organization. |
| [**V1OrganizationsConsentRequestsRequestIdCancelPut**](OrganizationsApi.md#v1organizationsconsentrequestsrequestidcancelput) | **PUT** /v1/organizations/consent-requests/{request_id}/cancel | Cancel the  Organization data request by id. |
| [**V1OrganizationsConsentRequestsRequestIdGet**](OrganizationsApi.md#v1organizationsconsentrequestsrequestidget) | **GET** /v1/organizations/consent-requests/{request_id} | Get Organization data request by id. |
| [**V1OrganizationsConsentTemplatesGet**](OrganizationsApi.md#v1organizationsconsenttemplatesget) | **GET** /v1/organizations/consent-templates | Get the paginated list of organization consent templates. |
| [**V1OrganizationsConsentTemplatesTemplateIdGet**](OrganizationsApi.md#v1organizationsconsenttemplatestemplateidget) | **GET** /v1/organizations/consent-templates/{template_id} | Get Organization consent template details by consent id. |
| [**V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet**](OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/organizations/consents/{consent_id}/documents/{document_id}/download | Download Organization consent document by document id. |
| [**V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet**](OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsdocumentidget) | **GET** /v1/organizations/consents/{consent_id}/documents/{document_id} | Get Organization consent document based on document id and consent id. |
| [**V1OrganizationsConsentsConsentIdDocumentsGet**](OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsget) | **GET** /v1/organizations/consents/{consent_id}/documents | Get Organization consent document by consent id. |
| [**V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet**](OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsaccountidget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts/{account_id} | Get organization consented financial account details. |
| [**V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**](OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsaccountidtransactionsget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts/{account_id}/transactions | Get organization consented financial account transactions. |
| [**V1OrganizationsConsentsConsentIdFinancialAccountsGet**](OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts | Get all organization consented financial accounts. |
| [**V1OrganizationsConsentsConsentIdGet**](OrganizationsApi.md#v1organizationsconsentsconsentidget) | **GET** /v1/organizations/consents/{consent_id} | Get Organization consent request details by consent id. |
| [**V1OrganizationsConsentsGet**](OrganizationsApi.md#v1organizationsconsentsget) | **GET** /v1/organizations/consents | Get the paginated list of Organization consents. |
| [**V1OrganizationsDocumentsIssuePost**](OrganizationsApi.md#v1organizationsdocumentsissuepost) | **POST** /v1/organizations/documents/issue | Issue a new document to an organization. |
| [**V1OrganizationsDocumentsIssueUploadIssueRequestIdPost**](OrganizationsApi.md#v1organizationsdocumentsissueuploadissuerequestidpost) | **POST** /v1/organizations/documents/issue/upload/{issue_request_id} | Upload a document for issuance request of Organization. |
| [**V1OrganizationsDocumentsIssuedDocumentIdGet**](OrganizationsApi.md#v1organizationsdocumentsissueddocumentidget) | **GET** /v1/organizations/documents/issued/{document_id} | Get issued document. |
| [**V1OrganizationsDocumentsIssuedGet**](OrganizationsApi.md#v1organizationsdocumentsissuedget) | **GET** /v1/organizations/documents/issued | Get paginated list of issued documents of given document type. |
| [**V1OrganizationsDocumentsTypesGet**](OrganizationsApi.md#v1organizationsdocumentstypesget) | **GET** /v1/organizations/documents/types | Get paginated list of registered document types. |

<a name="v1organizationsconsentrequestsget"></a>
# **V1OrganizationsConsentRequestsGet**
> PaginatedListOfOrganizationConsentRequestDetailss V1OrganizationsConsentRequestsGet (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get all consent requests sent to Organizations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentRequestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? |  (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get all consent requests sent to Organizations.
                PaginatedListOfOrganizationConsentRequestDetailss result = apiInstance.V1OrganizationsConsentRequestsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentRequestsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all consent requests sent to Organizations.
    ApiResponse<PaginatedListOfOrganizationConsentRequestDetailss> response = apiInstance.V1OrganizationsConsentRequestsGetWithHttpInfo(status, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | [**DataConsentStatus?**](DataConsentStatus?.md) |  | [optional]  |
| **fromDateTime** | **DateTime?** |  | [optional]  |
| **toDateTime** | **DateTime?** |  | [optional]  |
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfOrganizationConsentRequestDetailss**](PaginatedListOfOrganizationConsentRequestDetailss.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentrequestspost"></a>
# **V1OrganizationsConsentRequestsPost**
> OrganizationConsentRequestDetails V1OrganizationsConsentRequestsPost (CreateConsentRequest createConsentRequest)

Create consent request for an Organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var createConsentRequest = new CreateConsentRequest(); // CreateConsentRequest | 

            try
            {
                // Create consent request for an Organization.
                OrganizationConsentRequestDetails result = apiInstance.V1OrganizationsConsentRequestsPost(createConsentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentRequestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create consent request for an Organization.
    ApiResponse<OrganizationConsentRequestDetails> response = apiInstance.V1OrganizationsConsentRequestsPostWithHttpInfo(createConsentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConsentRequest** | [**CreateConsentRequest**](CreateConsentRequest.md) |  |  |

### Return type

[**OrganizationConsentRequestDetails**](OrganizationConsentRequestDetails.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentrequestsrequestidcancelput"></a>
# **V1OrganizationsConsentRequestsRequestIdCancelPut**
> bool V1OrganizationsConsentRequestsRequestIdCancelPut (string requestId)

Cancel the  Organization data request by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentRequestsRequestIdCancelPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var requestId = "requestId_example";  // string | 

            try
            {
                // Cancel the  Organization data request by id.
                bool result = apiInstance.V1OrganizationsConsentRequestsRequestIdCancelPut(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsRequestIdCancelPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentRequestsRequestIdCancelPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel the  Organization data request by id.
    ApiResponse<bool> response = apiInstance.V1OrganizationsConsentRequestsRequestIdCancelPutWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsRequestIdCancelPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** |  |  |

### Return type

**bool**

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentrequestsrequestidget"></a>
# **V1OrganizationsConsentRequestsRequestIdGet**
> ConsentRequest V1OrganizationsConsentRequestsRequestIdGet (string requestId)

Get Organization data request by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentRequestsRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var requestId = "requestId_example";  // string | 

            try
            {
                // Get Organization data request by id.
                ConsentRequest result = apiInstance.V1OrganizationsConsentRequestsRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentRequestsRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization data request by id.
    ApiResponse<ConsentRequest> response = apiInstance.V1OrganizationsConsentRequestsRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentRequestsRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** |  |  |

### Return type

[**ConsentRequest**](ConsentRequest.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsenttemplatesget"></a>
# **V1OrganizationsConsentTemplatesGet**
> PaginatedListOfConsentRequestTemplates V1OrganizationsConsentTemplatesGet (int? pageNo = null, int? pageSize = null)

Get the paginated list of organization consent templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentTemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get the paginated list of organization consent templates.
                PaginatedListOfConsentRequestTemplates result = apiInstance.V1OrganizationsConsentTemplatesGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentTemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentTemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the paginated list of organization consent templates.
    ApiResponse<PaginatedListOfConsentRequestTemplates> response = apiInstance.V1OrganizationsConsentTemplatesGetWithHttpInfo(pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentTemplatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfConsentRequestTemplates**](PaginatedListOfConsentRequestTemplates.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsenttemplatestemplateidget"></a>
# **V1OrganizationsConsentTemplatesTemplateIdGet**
> OrganizationConsentRequestTemplateDetails V1OrganizationsConsentTemplatesTemplateIdGet (string templateId)

Get Organization consent template details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentTemplatesTemplateIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var templateId = "templateId_example";  // string | 

            try
            {
                // Get Organization consent template details by consent id.
                OrganizationConsentRequestTemplateDetails result = apiInstance.V1OrganizationsConsentTemplatesTemplateIdGet(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentTemplatesTemplateIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentTemplatesTemplateIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization consent template details by consent id.
    ApiResponse<OrganizationConsentRequestTemplateDetails> response = apiInstance.V1OrganizationsConsentTemplatesTemplateIdGetWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentTemplatesTemplateIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |

### Return type

[**OrganizationConsentRequestTemplateDetails**](OrganizationConsentRequestTemplateDetails.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentiddocumentsdocumentiddownloadget"></a>
# **V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet**
> System.IO.Stream V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet (string consentId, string documentId)

Download Organization consent document by document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 
            var documentId = "documentId_example";  // string | 

            try
            {
                // Download Organization consent document by document id.
                System.IO.Stream result = apiInstance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download Organization consent document by document id.
    ApiResponse<System.IO.Stream> response = apiInstance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo(consentId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |
| **documentId** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * CONTENT-DISPOSITION -  <br>  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentiddocumentsdocumentidget"></a>
# **V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet**
> ConsentedDocument V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet (string consentId, string documentId)

Get Organization consent document based on document id and consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdDocumentsDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 
            var documentId = "documentId_example";  // string | 

            try
            {
                // Get Organization consent document based on document id and consent id.
                ConsentedDocument result = apiInstance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization consent document based on document id and consent id.
    ApiResponse<ConsentedDocument> response = apiInstance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo(consentId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |
| **documentId** | **string** |  |  |

### Return type

[**ConsentedDocument**](ConsentedDocument.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentiddocumentsget"></a>
# **V1OrganizationsConsentsConsentIdDocumentsGet**
> List&lt;ConsentedDocument&gt; V1OrganizationsConsentsConsentIdDocumentsGet (string consentId)

Get Organization consent document by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get Organization consent document by consent id.
                List<ConsentedDocument> result = apiInstance.V1OrganizationsConsentsConsentIdDocumentsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdDocumentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization consent document by consent id.
    ApiResponse<List<ConsentedDocument>> response = apiInstance.V1OrganizationsConsentsConsentIdDocumentsGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdDocumentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |

### Return type

[**List&lt;ConsentedDocument&gt;**](ConsentedDocument.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentidfinancialaccountsaccountidget"></a>
# **V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet**
> FinancialAccount V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet (string consentId, string accountId)

Get organization consented financial account details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 
            var accountId = "accountId_example";  // string | 

            try
            {
                // Get organization consented financial account details.
                FinancialAccount result = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get organization consented financial account details.
    ApiResponse<FinancialAccount> response = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo(consentId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |
| **accountId** | **string** |  |  |

### Return type

[**FinancialAccount**](FinancialAccount.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentidfinancialaccountsaccountidtransactionsget"></a>
# **V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**
> PaginatedListOfFinancialAccountTransactions V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet (string consentId, string accountId, string? filters = null, string? fromDateTime = null, string? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get organization consented financial account transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 
            var accountId = "accountId_example";  // string | 
            var filters = "filters_example";  // string? |  (optional) 
            var fromDateTime = "fromDateTime_example";  // string? |  (optional) 
            var toDateTime = "toDateTime_example";  // string? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get organization consented financial account transactions.
                PaginatedListOfFinancialAccountTransactions result = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet(consentId, accountId, filters, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get organization consented financial account transactions.
    ApiResponse<PaginatedListOfFinancialAccountTransactions> response = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo(consentId, accountId, filters, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |
| **accountId** | **string** |  |  |
| **filters** | **string?** |  | [optional]  |
| **fromDateTime** | **string?** |  | [optional]  |
| **toDateTime** | **string?** |  | [optional]  |
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfFinancialAccountTransactions**](PaginatedListOfFinancialAccountTransactions.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentidfinancialaccountsget"></a>
# **V1OrganizationsConsentsConsentIdFinancialAccountsGet**
> List&lt;FinancialAccount&gt; V1OrganizationsConsentsConsentIdFinancialAccountsGet (string consentId)

Get all organization consented financial accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdFinancialAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get all organization consented financial accounts.
                List<FinancialAccount> result = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdFinancialAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all organization consented financial accounts.
    ApiResponse<List<FinancialAccount>> response = apiInstance.V1OrganizationsConsentsConsentIdFinancialAccountsGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdFinancialAccountsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |

### Return type

[**List&lt;FinancialAccount&gt;**](FinancialAccount.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsconsentidget"></a>
# **V1OrganizationsConsentsConsentIdGet**
> ConsentDetails V1OrganizationsConsentsConsentIdGet (string consentId)

Get Organization consent request details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsConsentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get Organization consent request details by consent id.
                ConsentDetails result = apiInstance.V1OrganizationsConsentsConsentIdGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsConsentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization consent request details by consent id.
    ApiResponse<ConsentDetails> response = apiInstance.V1OrganizationsConsentsConsentIdGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsConsentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |

### Return type

[**ConsentDetails**](ConsentDetails.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsconsentsget"></a>
# **V1OrganizationsConsentsGet**
> PaginatedListOfConsents V1OrganizationsConsentsGet (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get the paginated list of Organization consents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsConsentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? |  (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get the paginated list of Organization consents.
                PaginatedListOfConsents result = apiInstance.V1OrganizationsConsentsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsConsentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the paginated list of Organization consents.
    ApiResponse<PaginatedListOfConsents> response = apiInstance.V1OrganizationsConsentsGetWithHttpInfo(status, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsConsentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | [**DataConsentStatus?**](DataConsentStatus?.md) |  | [optional]  |
| **fromDateTime** | **DateTime?** |  | [optional]  |
| **toDateTime** | **DateTime?** |  | [optional]  |
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfConsents**](PaginatedListOfConsents.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsdocumentsissuepost"></a>
# **V1OrganizationsDocumentsIssuePost**
> DocumentIssueRequestDetails V1OrganizationsDocumentsIssuePost (DocumentIssueRequest documentIssueRequest)

Issue a new document to an organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsDocumentsIssuePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var documentIssueRequest = new DocumentIssueRequest(); // DocumentIssueRequest | 

            try
            {
                // Issue a new document to an organization.
                DocumentIssueRequestDetails result = apiInstance.V1OrganizationsDocumentsIssuePost(documentIssueRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsDocumentsIssuePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Issue a new document to an organization.
    ApiResponse<DocumentIssueRequestDetails> response = apiInstance.V1OrganizationsDocumentsIssuePostWithHttpInfo(documentIssueRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentIssueRequest** | [**DocumentIssueRequest**](DocumentIssueRequest.md) |  |  |

### Return type

[**DocumentIssueRequestDetails**](DocumentIssueRequestDetails.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsdocumentsissueuploadissuerequestidpost"></a>
# **V1OrganizationsDocumentsIssueUploadIssueRequestIdPost**
> UploadDocumentResponse V1OrganizationsDocumentsIssueUploadIssueRequestIdPost (string issueRequestId, System.IO.Stream file)

Upload a document for issuance request of Organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsDocumentsIssueUploadIssueRequestIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var issueRequestId = "issueRequestId_example";  // string | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload a document for issuance request of Organization.
                UploadDocumentResponse result = apiInstance.V1OrganizationsDocumentsIssueUploadIssueRequestIdPost(issueRequestId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssueUploadIssueRequestIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsDocumentsIssueUploadIssueRequestIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a document for issuance request of Organization.
    ApiResponse<UploadDocumentResponse> response = apiInstance.V1OrganizationsDocumentsIssueUploadIssueRequestIdPostWithHttpInfo(issueRequestId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssueUploadIssueRequestIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **issueRequestId** | **string** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**UploadDocumentResponse**](UploadDocumentResponse.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsdocumentsissueddocumentidget"></a>
# **V1OrganizationsDocumentsIssuedDocumentIdGet**
> IssuedDocument V1OrganizationsDocumentsIssuedDocumentIdGet (string documentId)

Get issued document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsDocumentsIssuedDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var documentId = "documentId_example";  // string | 

            try
            {
                // Get issued document.
                IssuedDocument result = apiInstance.V1OrganizationsDocumentsIssuedDocumentIdGet(documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuedDocumentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsDocumentsIssuedDocumentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get issued document.
    ApiResponse<IssuedDocument> response = apiInstance.V1OrganizationsDocumentsIssuedDocumentIdGetWithHttpInfo(documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuedDocumentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** |  |  |

### Return type

[**IssuedDocument**](IssuedDocument.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsdocumentsissuedget"></a>
# **V1OrganizationsDocumentsIssuedGet**
> PaginatedListOfIssuedDocuments V1OrganizationsDocumentsIssuedGet (string documentTypeId, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get paginated list of issued documents of given document type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsDocumentsIssuedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var documentTypeId = "documentTypeId_example";  // string | 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get paginated list of issued documents of given document type.
                PaginatedListOfIssuedDocuments result = apiInstance.V1OrganizationsDocumentsIssuedGet(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsDocumentsIssuedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get paginated list of issued documents of given document type.
    ApiResponse<PaginatedListOfIssuedDocuments> response = apiInstance.V1OrganizationsDocumentsIssuedGetWithHttpInfo(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsIssuedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentTypeId** | **string** |  |  |
| **fromDateTime** | **DateTime?** |  | [optional]  |
| **toDateTime** | **DateTime?** |  | [optional]  |
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfIssuedDocuments**](PaginatedListOfIssuedDocuments.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1organizationsdocumentstypesget"></a>
# **V1OrganizationsDocumentsTypesGet**
> PaginatedListOfDocumentTypes V1OrganizationsDocumentsTypesGet (int? pageNo = null, int? pageSize = null)

Get paginated list of registered document types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1OrganizationsDocumentsTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get paginated list of registered document types.
                PaginatedListOfDocumentTypes result = apiInstance.V1OrganizationsDocumentsTypesGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1OrganizationsDocumentsTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get paginated list of registered document types.
    ApiResponse<PaginatedListOfDocumentTypes> response = apiInstance.V1OrganizationsDocumentsTypesGetWithHttpInfo(pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.V1OrganizationsDocumentsTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNo** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**PaginatedListOfDocumentTypes**](PaginatedListOfDocumentTypes.md)

### Authorization

[OAuth2ClientCredentials](../README.md#OAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **403** |  |  -  |
| **404** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

