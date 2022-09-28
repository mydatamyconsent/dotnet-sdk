# MyDataMyConsent.Api.IndividualsApi

All URIs are relative to *https://api.mydatamyconsent.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IssuerIssuedoc1XmlPost**](IndividualsApi.md#issuerissuedoc1xmlpost) | **POST** /issuer/issuedoc/1/xml | Digilocker compatible endpoint to issue document. |
| [**V1IndividualsConsentRequestsGet**](IndividualsApi.md#v1individualsconsentrequestsget) | **GET** /v1/individuals/consent-requests | Get all consent requests sent to Individuals. |
| [**V1IndividualsConsentRequestsPost**](IndividualsApi.md#v1individualsconsentrequestspost) | **POST** /v1/individuals/consent-requests | Create individual consent request. |
| [**V1IndividualsConsentRequestsRequestIdCancelPut**](IndividualsApi.md#v1individualsconsentrequestsrequestidcancelput) | **PUT** /v1/individuals/consent-requests/{request_id}/cancel | Cancel the Individual data request by id. |
| [**V1IndividualsConsentRequestsRequestIdGet**](IndividualsApi.md#v1individualsconsentrequestsrequestidget) | **GET** /v1/individuals/consent-requests/{request_id} | Get Individual data request by id. |
| [**V1IndividualsConsentTemplatesGet**](IndividualsApi.md#v1individualsconsenttemplatesget) | **GET** /v1/individuals/consent-templates | Get the paginated list of individual consent templates. |
| [**V1IndividualsConsentTemplatesTemplateIdGet**](IndividualsApi.md#v1individualsconsenttemplatestemplateidget) | **GET** /v1/individuals/consent-templates/{template_id} | Get Individual consent template details by consent id. |
| [**V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet**](IndividualsApi.md#v1individualsconsentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/individuals/consents/{consent_id}/documents/{document_id}/download | Download Individual consented document by document id. |
| [**V1IndividualsConsentsConsentIdDocumentsDocumentIdGet**](IndividualsApi.md#v1individualsconsentsconsentiddocumentsdocumentidget) | **GET** /v1/individuals/consents/{consent_id}/documents/{document_id} | Get Individual consented document by document id. |
| [**V1IndividualsConsentsConsentIdDocumentsGet**](IndividualsApi.md#v1individualsconsentsconsentiddocumentsget) | **GET** /v1/individuals/consents/{consent_id}/documents | Get Individual consented document by consent id. |
| [**V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet**](IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsaccountidget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts/{account_id} | Get individual consented financial account details. |
| [**V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**](IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsaccountidtransactionsget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts/{account_id}/transactions | Get individual consented financial account transactions. |
| [**V1IndividualsConsentsConsentIdFinancialAccountsGet**](IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts | Get all individual consented financial accounts. |
| [**V1IndividualsConsentsConsentIdGet**](IndividualsApi.md#v1individualsconsentsconsentidget) | **GET** /v1/individuals/consents/{consent_id} | Get Individuals consent details by consent id. |
| [**V1IndividualsConsentsConsentIdHealthFhirBundleGet**](IndividualsApi.md#v1individualsconsentsconsentidhealthfhirbundleget) | **GET** /v1/individuals/consents/{consent_id}/health/fhir/bundle | Get Individual consented document by consent id. |
| [**V1IndividualsConsentsGet**](IndividualsApi.md#v1individualsconsentsget) | **GET** /v1/individuals/consents | Get the paginated list of Individual consents. |
| [**V1IndividualsDocumentsIssueIssueRequestIdUploadPost**](IndividualsApi.md#v1individualsdocumentsissueissuerequestiduploadpost) | **POST** /v1/individuals/documents/issue/{issue_request_id}/upload | Upload a document for issuance request of individual. |
| [**V1IndividualsDocumentsIssuePost**](IndividualsApi.md#v1individualsdocumentsissuepost) | **POST** /v1/individuals/documents/issue | Issue a new document to an individual user. |
| [**V1IndividualsDocumentsIssuedDocumentIdGet**](IndividualsApi.md#v1individualsdocumentsissueddocumentidget) | **GET** /v1/individuals/documents/issued/{document_id} | Get issued document. |
| [**V1IndividualsDocumentsIssuedGet**](IndividualsApi.md#v1individualsdocumentsissuedget) | **GET** /v1/individuals/documents/issued | Get paginated list of issued documents of given document type. |
| [**V1IndividualsDocumentsTypesGet**](IndividualsApi.md#v1individualsdocumentstypesget) | **GET** /v1/individuals/documents/types | Get paginated list of registered document types. |

<a name="issuerissuedoc1xmlpost"></a>
# **IssuerIssuedoc1XmlPost**
> PushUriResponse IssuerIssuedoc1XmlPost (PushUriRequest pushUriRequest)

Digilocker compatible endpoint to issue document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class IssuerIssuedoc1XmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var pushUriRequest = new PushUriRequest(); // PushUriRequest | 

            try
            {
                // Digilocker compatible endpoint to issue document.
                PushUriResponse result = apiInstance.IssuerIssuedoc1XmlPost(pushUriRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.IssuerIssuedoc1XmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuerIssuedoc1XmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Digilocker compatible endpoint to issue document.
    ApiResponse<PushUriResponse> response = apiInstance.IssuerIssuedoc1XmlPostWithHttpInfo(pushUriRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.IssuerIssuedoc1XmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushUriRequest** | [**PushUriRequest**](PushUriRequest.md) |  |  |

### Return type

[**PushUriResponse**](PushUriResponse.md)

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

<a name="v1individualsconsentrequestsget"></a>
# **V1IndividualsConsentRequestsGet**
> PaginatedListOfIndividualConsentRequestDetailss V1IndividualsConsentRequestsGet (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get all consent requests sent to Individuals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentRequestsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? |  (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get all consent requests sent to Individuals.
                PaginatedListOfIndividualConsentRequestDetailss result = apiInstance.V1IndividualsConsentRequestsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentRequestsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all consent requests sent to Individuals.
    ApiResponse<PaginatedListOfIndividualConsentRequestDetailss> response = apiInstance.V1IndividualsConsentRequestsGetWithHttpInfo(status, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsGetWithHttpInfo: " + e.Message);
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

[**PaginatedListOfIndividualConsentRequestDetailss**](PaginatedListOfIndividualConsentRequestDetailss.md)

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

<a name="v1individualsconsentrequestspost"></a>
# **V1IndividualsConsentRequestsPost**
> IndividualConsentRequestDetails V1IndividualsConsentRequestsPost (CreateConsentRequest createConsentRequest)

Create individual consent request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var createConsentRequest = new CreateConsentRequest(); // CreateConsentRequest | 

            try
            {
                // Create individual consent request.
                IndividualConsentRequestDetails result = apiInstance.V1IndividualsConsentRequestsPost(createConsentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentRequestsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create individual consent request.
    ApiResponse<IndividualConsentRequestDetails> response = apiInstance.V1IndividualsConsentRequestsPostWithHttpInfo(createConsentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConsentRequest** | [**CreateConsentRequest**](CreateConsentRequest.md) |  |  |

### Return type

[**IndividualConsentRequestDetails**](IndividualConsentRequestDetails.md)

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

<a name="v1individualsconsentrequestsrequestidcancelput"></a>
# **V1IndividualsConsentRequestsRequestIdCancelPut**
> bool V1IndividualsConsentRequestsRequestIdCancelPut (string requestId)

Cancel the Individual data request by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentRequestsRequestIdCancelPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var requestId = "requestId_example";  // string | 

            try
            {
                // Cancel the Individual data request by id.
                bool result = apiInstance.V1IndividualsConsentRequestsRequestIdCancelPut(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsRequestIdCancelPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentRequestsRequestIdCancelPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel the Individual data request by id.
    ApiResponse<bool> response = apiInstance.V1IndividualsConsentRequestsRequestIdCancelPutWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsRequestIdCancelPutWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentrequestsrequestidget"></a>
# **V1IndividualsConsentRequestsRequestIdGet**
> ConsentRequest V1IndividualsConsentRequestsRequestIdGet (string requestId)

Get Individual data request by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentRequestsRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var requestId = "requestId_example";  // string | 

            try
            {
                // Get Individual data request by id.
                ConsentRequest result = apiInstance.V1IndividualsConsentRequestsRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentRequestsRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individual data request by id.
    ApiResponse<ConsentRequest> response = apiInstance.V1IndividualsConsentRequestsRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentRequestsRequestIdGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsenttemplatesget"></a>
# **V1IndividualsConsentTemplatesGet**
> PaginatedListOfConsentRequestTemplates V1IndividualsConsentTemplatesGet (int? pageNo = null, int? pageSize = null)

Get the paginated list of individual consent templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentTemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get the paginated list of individual consent templates.
                PaginatedListOfConsentRequestTemplates result = apiInstance.V1IndividualsConsentTemplatesGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentTemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentTemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the paginated list of individual consent templates.
    ApiResponse<PaginatedListOfConsentRequestTemplates> response = apiInstance.V1IndividualsConsentTemplatesGetWithHttpInfo(pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentTemplatesGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsenttemplatestemplateidget"></a>
# **V1IndividualsConsentTemplatesTemplateIdGet**
> IndividualConsentRequestTemplateDetails V1IndividualsConsentTemplatesTemplateIdGet (string templateId)

Get Individual consent template details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentTemplatesTemplateIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var templateId = "templateId_example";  // string | 

            try
            {
                // Get Individual consent template details by consent id.
                IndividualConsentRequestTemplateDetails result = apiInstance.V1IndividualsConsentTemplatesTemplateIdGet(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentTemplatesTemplateIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentTemplatesTemplateIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individual consent template details by consent id.
    ApiResponse<IndividualConsentRequestTemplateDetails> response = apiInstance.V1IndividualsConsentTemplatesTemplateIdGetWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentTemplatesTemplateIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |

### Return type

[**IndividualConsentRequestTemplateDetails**](IndividualConsentRequestTemplateDetails.md)

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

<a name="v1individualsconsentsconsentiddocumentsdocumentiddownloadget"></a>
# **V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet**
> System.IO.Stream V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet (string consentId, string documentId)

Download Individual consented document by document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 
            var documentId = "documentId_example";  // string | 

            try
            {
                // Download Individual consented document by document id.
                System.IO.Stream result = apiInstance.V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download Individual consented document by document id.
    ApiResponse<System.IO.Stream> response = apiInstance.V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo(consentId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentiddocumentsdocumentidget"></a>
# **V1IndividualsConsentsConsentIdDocumentsDocumentIdGet**
> ConsentedDocument V1IndividualsConsentsConsentIdDocumentsDocumentIdGet (string consentId, string documentId)

Get Individual consented document by document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdDocumentsDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 
            var documentId = "documentId_example";  // string | 

            try
            {
                // Get Individual consented document by document id.
                ConsentedDocument result = apiInstance.V1IndividualsConsentsConsentIdDocumentsDocumentIdGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsDocumentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individual consented document by document id.
    ApiResponse<ConsentedDocument> response = apiInstance.V1IndividualsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo(consentId, documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsDocumentIdGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentiddocumentsget"></a>
# **V1IndividualsConsentsConsentIdDocumentsGet**
> List&lt;ConsentedDocument&gt; V1IndividualsConsentsConsentIdDocumentsGet (string consentId)

Get Individual consented document by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get Individual consented document by consent id.
                List<ConsentedDocument> result = apiInstance.V1IndividualsConsentsConsentIdDocumentsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdDocumentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individual consented document by consent id.
    ApiResponse<List<ConsentedDocument>> response = apiInstance.V1IndividualsConsentsConsentIdDocumentsGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdDocumentsGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentidfinancialaccountsaccountidget"></a>
# **V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet**
> FinancialAccount V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet (string consentId, string accountId)

Get individual consented financial account details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 
            var accountId = "accountId_example";  // string | 

            try
            {
                // Get individual consented financial account details.
                FinancialAccount result = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get individual consented financial account details.
    ApiResponse<FinancialAccount> response = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo(consentId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentidfinancialaccountsaccountidtransactionsget"></a>
# **V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**
> PaginatedListOfFinancialAccountTransactions V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet (string consentId, string accountId, string? filters = null, string? fromDateTime = null, string? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get individual consented financial account transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 
            var accountId = "accountId_example";  // string | 
            var filters = "filters_example";  // string? |  (optional) 
            var fromDateTime = "fromDateTime_example";  // string? |  (optional) 
            var toDateTime = "toDateTime_example";  // string? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get individual consented financial account transactions.
                PaginatedListOfFinancialAccountTransactions result = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet(consentId, accountId, filters, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get individual consented financial account transactions.
    ApiResponse<PaginatedListOfFinancialAccountTransactions> response = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo(consentId, accountId, filters, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentidfinancialaccountsget"></a>
# **V1IndividualsConsentsConsentIdFinancialAccountsGet**
> List&lt;FinancialAccount&gt; V1IndividualsConsentsConsentIdFinancialAccountsGet (string consentId)

Get all individual consented financial accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdFinancialAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get all individual consented financial accounts.
                List<FinancialAccount> result = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdFinancialAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all individual consented financial accounts.
    ApiResponse<List<FinancialAccount>> response = apiInstance.V1IndividualsConsentsConsentIdFinancialAccountsGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdFinancialAccountsGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentidget"></a>
# **V1IndividualsConsentsConsentIdGet**
> ConsentDetails V1IndividualsConsentsConsentIdGet (string consentId)

Get Individuals consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get Individuals consent details by consent id.
                ConsentDetails result = apiInstance.V1IndividualsConsentsConsentIdGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individuals consent details by consent id.
    ApiResponse<ConsentDetails> response = apiInstance.V1IndividualsConsentsConsentIdGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsconsentsconsentidhealthfhirbundleget"></a>
# **V1IndividualsConsentsConsentIdHealthFhirBundleGet**
> Object V1IndividualsConsentsConsentIdHealthFhirBundleGet (string consentId)

Get Individual consented document by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsConsentIdHealthFhirBundleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var consentId = "consentId_example";  // string | 

            try
            {
                // Get Individual consented document by consent id.
                Object result = apiInstance.V1IndividualsConsentsConsentIdHealthFhirBundleGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdHealthFhirBundleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsConsentIdHealthFhirBundleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Individual consented document by consent id.
    ApiResponse<Object> response = apiInstance.V1IndividualsConsentsConsentIdHealthFhirBundleGetWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsConsentIdHealthFhirBundleGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** |  |  |

### Return type

**Object**

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

<a name="v1individualsconsentsget"></a>
# **V1IndividualsConsentsGet**
> PaginatedListOfConsents V1IndividualsConsentsGet (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get the paginated list of Individual consents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsConsentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? |  (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get the paginated list of Individual consents.
                PaginatedListOfConsents result = apiInstance.V1IndividualsConsentsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsConsentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the paginated list of Individual consents.
    ApiResponse<PaginatedListOfConsents> response = apiInstance.V1IndividualsConsentsGetWithHttpInfo(status, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsConsentsGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsdocumentsissueissuerequestiduploadpost"></a>
# **V1IndividualsDocumentsIssueIssueRequestIdUploadPost**
> UploadDocumentResponse V1IndividualsDocumentsIssueIssueRequestIdUploadPost (string issueRequestId, System.IO.Stream file)

Upload a document for issuance request of individual.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsDocumentsIssueIssueRequestIdUploadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var issueRequestId = "issueRequestId_example";  // string | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Upload a document for issuance request of individual.
                UploadDocumentResponse result = apiInstance.V1IndividualsDocumentsIssueIssueRequestIdUploadPost(issueRequestId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssueIssueRequestIdUploadPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsDocumentsIssueIssueRequestIdUploadPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a document for issuance request of individual.
    ApiResponse<UploadDocumentResponse> response = apiInstance.V1IndividualsDocumentsIssueIssueRequestIdUploadPostWithHttpInfo(issueRequestId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssueIssueRequestIdUploadPostWithHttpInfo: " + e.Message);
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

<a name="v1individualsdocumentsissuepost"></a>
# **V1IndividualsDocumentsIssuePost**
> DocumentIssueRequestDetails V1IndividualsDocumentsIssuePost (DocumentIssueRequest documentIssueRequest)

Issue a new document to an individual user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1IndividualsDocumentsIssuePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var documentIssueRequest = new DocumentIssueRequest(); // DocumentIssueRequest | 

            try
            {
                // Issue a new document to an individual user.
                DocumentIssueRequestDetails result = apiInstance.V1IndividualsDocumentsIssuePost(documentIssueRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsDocumentsIssuePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Issue a new document to an individual user.
    ApiResponse<DocumentIssueRequestDetails> response = apiInstance.V1IndividualsDocumentsIssuePostWithHttpInfo(documentIssueRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuePostWithHttpInfo: " + e.Message);
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

<a name="v1individualsdocumentsissueddocumentidget"></a>
# **V1IndividualsDocumentsIssuedDocumentIdGet**
> IssuedDocument V1IndividualsDocumentsIssuedDocumentIdGet (string documentId)

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
    public class V1IndividualsDocumentsIssuedDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var documentId = "documentId_example";  // string | 

            try
            {
                // Get issued document.
                IssuedDocument result = apiInstance.V1IndividualsDocumentsIssuedDocumentIdGet(documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuedDocumentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsDocumentsIssuedDocumentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get issued document.
    ApiResponse<IssuedDocument> response = apiInstance.V1IndividualsDocumentsIssuedDocumentIdGetWithHttpInfo(documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuedDocumentIdGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsdocumentsissuedget"></a>
# **V1IndividualsDocumentsIssuedGet**
> PaginatedListOfIssuedDocuments V1IndividualsDocumentsIssuedGet (string documentTypeId, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

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
    public class V1IndividualsDocumentsIssuedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var documentTypeId = "documentTypeId_example";  // string | 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get paginated list of issued documents of given document type.
                PaginatedListOfIssuedDocuments result = apiInstance.V1IndividualsDocumentsIssuedGet(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsDocumentsIssuedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get paginated list of issued documents of given document type.
    ApiResponse<PaginatedListOfIssuedDocuments> response = apiInstance.V1IndividualsDocumentsIssuedGetWithHttpInfo(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsIssuedGetWithHttpInfo: " + e.Message);
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

<a name="v1individualsdocumentstypesget"></a>
# **V1IndividualsDocumentsTypesGet**
> PaginatedListOfDocumentTypes V1IndividualsDocumentsTypesGet (int? pageNo = null, int? pageSize = null)

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
    public class V1IndividualsDocumentsTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndividualsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get paginated list of registered document types.
                PaginatedListOfDocumentTypes result = apiInstance.V1IndividualsDocumentsTypesGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1IndividualsDocumentsTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get paginated list of registered document types.
    ApiResponse<PaginatedListOfDocumentTypes> response = apiInstance.V1IndividualsDocumentsTypesGetWithHttpInfo(pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndividualsApi.V1IndividualsDocumentsTypesGetWithHttpInfo: " + e.Message);
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

