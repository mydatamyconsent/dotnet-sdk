# MyDataMyConsent.Sdk.Api.DataConsentsApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadConsentedDocumentAnalysis**](DataConsentsApi.md#downloadconsenteddocumentanalysis) | **GET** /v1/consents/{consentId}/documents/{documentId}/analysis | Get analysis of a consented document.
[**DownloadConsentedDocumentById**](DataConsentsApi.md#downloadconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId}/download | Download a individuals consented document.
[**DownloadOrgConsentedDocumentById**](DataConsentsApi.md#downloadorgconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId}/download | Download a organizations consented document.
[**GetAllConsentedDocuments**](DataConsentsApi.md#getallconsenteddocuments) | **GET** /v1/consents/individuals/{consentId}/documents | Get the individual documents based on ConsentId.
[**GetAllConsentedFinancialAccounts**](DataConsentsApi.md#getallconsentedfinancialaccounts) | **GET** /v1/consents/individuals/{consentId}/financial-accounts | Get all individual consented financial accounts.
[**GetAllOrganizationConsentedDocuments**](DataConsentsApi.md#getallorganizationconsenteddocuments) | **GET** /v1/consents/organizations/{consentId}/documents | Get the organization documents based on ConsentId.
[**GetConsentDetailsById**](DataConsentsApi.md#getconsentdetailsbyid) | **GET** /v1/consents/individuals/{consentId} | Get all individuals consent details by consent id.
[**GetConsentFinancialAccounts**](DataConsentsApi.md#getconsentfinancialaccounts) | **GET** /v1/consents/organizations/{consentId}/financial-accounts | Get all organizational consented financial accounts.
[**GetConsentedAccountById**](DataConsentsApi.md#getconsentedaccountbyid) | **GET** /v1/consents/individuals/{consentId}/financial-accounts/{accountId} | Get individual consented financial account details based on account id.
[**GetConsentedDocumentById**](DataConsentsApi.md#getconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId} | Get individuals consent document based on document id.
[**GetConsentedFinancialAccount**](DataConsentsApi.md#getconsentedfinancialaccount) | **GET** /v1/consents/organizations/{consentId}/financial-accounts/{accountId} | Get organization consented financial account details based on account id.
[**GetConsentedFinancialAccountInsights**](DataConsentsApi.md#getconsentedfinancialaccountinsights) | **GET** /v1/consents/{consentId}/financial-accounts/{accountId}/insights | Get consented financial account insights.
[**GetConsentedFinancialAccountTransactions**](DataConsentsApi.md#getconsentedfinancialaccounttransactions) | **GET** /v1/consents/individuals/{consentId}/financial-accounts/{accountId}/transactions | Get individual consented financial account transactions of an individual based on accountId.
[**GetConsentsForOrganizations**](DataConsentsApi.md#getconsentsfororganizations) | **GET** /v1/consents/organizations | Get the list of data consents sent for organizations.
[**GetConsentsSentToIndividuals**](DataConsentsApi.md#getconsentssenttoindividuals) | **GET** /v1/consents/individuals | Get the list of Consents Sent to Individuals.
[**GetOrgConsentedAccountTransactions**](DataConsentsApi.md#getorgconsentedaccounttransactions) | **GET** /v1/consents/organizations/{consentId}/financial-accounts/{accountId}/transactions | Get organization consented financial account transactions of an individual based on accountId.
[**GetOrganizationConsentDetailsById**](DataConsentsApi.md#getorganizationconsentdetailsbyid) | **GET** /v1/consents/organizations/{consentId} | Get all organization consent details by consent id.
[**GetOrganizationConsentedDocumentById**](DataConsentsApi.md#getorganizationconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId} | Get organization consent document based on document id.


<a name="downloadconsenteddocumentanalysis"></a>
# **DownloadConsentedDocumentAnalysis**
> void DownloadConsentedDocumentAnalysis (string consentId, string documentId)

Get analysis of a consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DownloadConsentedDocumentAnalysisExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // string | 
            var documentId = "documentId_example";  // string | Document Id.

            try
            {
                // Get analysis of a consented document.
                apiInstance.DownloadConsentedDocumentAnalysis(consentId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.DownloadConsentedDocumentAnalysis: " + e.Message );
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
 **consentId** | **string**|  | 
 **documentId** | **string**| Document Id. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadconsenteddocumentbyid"></a>
# **DownloadConsentedDocumentById**
> UserDocumentDownload DownloadConsentedDocumentById (Guid consentId, Guid documentId)

Download a individuals consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DownloadConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var documentId = "documentId_example";  // Guid | Document id.

            try
            {
                // Download a individuals consented document.
                UserDocumentDownload result = apiInstance.DownloadConsentedDocumentById(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.DownloadConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **documentId** | **Guid**| Document id. | 

### Return type

[**UserDocumentDownload**](UserDocumentDownload.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadorgconsenteddocumentbyid"></a>
# **DownloadOrgConsentedDocumentById**
> OrganizationDocumentDownloadDto DownloadOrgConsentedDocumentById (Guid consentId, Guid documentId)

Download a organizations consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DownloadOrgConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var documentId = "documentId_example";  // Guid | Document id.

            try
            {
                // Download a organizations consented document.
                OrganizationDocumentDownloadDto result = apiInstance.DownloadOrgConsentedDocumentById(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.DownloadOrgConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **documentId** | **Guid**| Document id. | 

### Return type

[**OrganizationDocumentDownloadDto**](OrganizationDocumentDownloadDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsenteddocuments"></a>
# **GetAllConsentedDocuments**
> DataConsentDocumentsDto GetAllConsentedDocuments (Guid consentId)

Get the individual documents based on ConsentId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllConsentedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get the individual documents based on ConsentId.
                DataConsentDocumentsDto result = apiInstance.GetAllConsentedDocuments(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetAllConsentedDocuments: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

### Return type

[**DataConsentDocumentsDto**](DataConsentDocumentsDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallconsentedfinancialaccounts"></a>
# **GetAllConsentedFinancialAccounts**
> DataConsentFinancialsDto GetAllConsentedFinancialAccounts (Guid consentId)

Get all individual consented financial accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllConsentedFinancialAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get all individual consented financial accounts.
                DataConsentFinancialsDto result = apiInstance.GetAllConsentedFinancialAccounts(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetAllConsentedFinancialAccounts: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

### Return type

[**DataConsentFinancialsDto**](DataConsentFinancialsDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallorganizationconsenteddocuments"></a>
# **GetAllOrganizationConsentedDocuments**
> DataConsentDocumentsDto GetAllOrganizationConsentedDocuments (Guid consentId)

Get the organization documents based on ConsentId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllOrganizationConsentedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get the organization documents based on ConsentId.
                DataConsentDocumentsDto result = apiInstance.GetAllOrganizationConsentedDocuments(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetAllOrganizationConsentedDocuments: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

### Return type

[**DataConsentDocumentsDto**](DataConsentDocumentsDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentdetailsbyid"></a>
# **GetConsentDetailsById**
> DataConsentDetailsDto GetConsentDetailsById (Guid consentId)

Get all individuals consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentDetailsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get all individuals consent details by consent id.
                DataConsentDetailsDto result = apiInstance.GetConsentDetailsById(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentDetailsById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentfinancialaccounts"></a>
# **GetConsentFinancialAccounts**
> DataConsentFinancialsDto GetConsentFinancialAccounts (Guid consentId)

Get all organizational consented financial accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentFinancialAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get all organizational consented financial accounts.
                DataConsentFinancialsDto result = apiInstance.GetConsentFinancialAccounts(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentFinancialAccounts: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

### Return type

[**DataConsentFinancialsDto**](DataConsentFinancialsDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentedaccountbyid"></a>
# **GetConsentedAccountById**
> FinancialAccount GetConsentedAccountById (Guid consentId, Guid accountId)

Get individual consented financial account details based on account id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentedAccountByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var accountId = "accountId_example";  // Guid | Account id.

            try
            {
                // Get individual consented financial account details based on account id.
                FinancialAccount result = apiInstance.GetConsentedAccountById(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentedAccountById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **accountId** | **Guid**| Account id. | 

### Return type

[**FinancialAccount**](FinancialAccount.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsenteddocumentbyid"></a>
# **GetConsentedDocumentById**
> UserDocumentDetails GetConsentedDocumentById (Guid consentId, Guid documentId)

Get individuals consent document based on document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var documentId = "documentId_example";  // Guid | Document Id.

            try
            {
                // Get individuals consent document based on document id.
                UserDocumentDetails result = apiInstance.GetConsentedDocumentById(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **documentId** | **Guid**| Document Id. | 

### Return type

[**UserDocumentDetails**](UserDocumentDetails.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentedfinancialaccount"></a>
# **GetConsentedFinancialAccount**
> OrganizationFinancialAccountDto GetConsentedFinancialAccount (Guid consentId, Guid accountId)

Get organization consented financial account details based on account id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentedFinancialAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var accountId = "accountId_example";  // Guid | Account id.

            try
            {
                // Get organization consented financial account details based on account id.
                OrganizationFinancialAccountDto result = apiInstance.GetConsentedFinancialAccount(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentedFinancialAccount: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **accountId** | **Guid**| Account id. | 

### Return type

[**OrganizationFinancialAccountDto**](OrganizationFinancialAccountDto.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentedfinancialaccountinsights"></a>
# **GetConsentedFinancialAccountInsights**
> void GetConsentedFinancialAccountInsights (string consentId, string accountId)

Get consented financial account insights.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentedFinancialAccountInsightsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // string | 
            var accountId = "accountId_example";  // string | 

            try
            {
                // Get consented financial account insights.
                apiInstance.GetConsentedFinancialAccountInsights(consentId, accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentedFinancialAccountInsights: " + e.Message );
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
 **consentId** | **string**|  | 
 **accountId** | **string**|  | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentedfinancialaccounttransactions"></a>
# **GetConsentedFinancialAccountTransactions**
> UserAccountFinancialTransactionsDtoPaginatedList GetConsentedFinancialAccountTransactions (Guid consentId, Guid accountId, string? filters = null, DateTime? fromDateTimeUtc = null, DateTime? toDateTimeUtc = null, int? pageNo = null, int? pageSize = null)

Get individual consented financial account transactions of an individual based on accountId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentedFinancialAccountTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var accountId = "accountId_example";  // Guid | Account id.
            var filters = "filters_example";  // string? | Filters. (optional) 
            var fromDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From date time in utc timezone. (optional) 
            var toDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Til date time in utc timezone. (optional) 
            var pageNo = 10;  // int? | Page number. (optional)  (default to 10)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get individual consented financial account transactions of an individual based on accountId.
                UserAccountFinancialTransactionsDtoPaginatedList result = apiInstance.GetConsentedFinancialAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentedFinancialAccountTransactions: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **accountId** | **Guid**| Account id. | 
 **filters** | **string?**| Filters. | [optional] 
 **fromDateTimeUtc** | **DateTime?**| From date time in utc timezone. | [optional] 
 **toDateTimeUtc** | **DateTime?**| Til date time in utc timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 10]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**UserAccountFinancialTransactionsDtoPaginatedList**](UserAccountFinancialTransactionsDtoPaginatedList.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentsfororganizations"></a>
# **GetConsentsForOrganizations**
> OrganizationDataConsentInfoDtoPaginatedList GetConsentsForOrganizations (DataConsentStatus? status = null, DateTime? from = null, DateTime? to = null, int? pageNo = null, int? pageSize = null)

Get the list of data consents sent for organizations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentsForOrganizationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From date time in utc timezone. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Til date time in utc timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get the list of data consents sent for organizations.
                OrganizationDataConsentInfoDtoPaginatedList result = apiInstance.GetConsentsForOrganizations(status, from, to, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentsForOrganizations: " + e.Message );
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
 **status** | [**DataConsentStatus?**](DataConsentStatus?.md)| Data consent status MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. | [optional] 
 **from** | **DateTime?**| From date time in utc timezone. | [optional] 
 **to** | **DateTime?**| Til date time in utc timezone. | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentssenttoindividuals"></a>
# **GetConsentsSentToIndividuals**
> UserDataConsentInfoDtoPaginatedList GetConsentsSentToIndividuals (DataConsentStatus? status = null, DateTime? from = null, DateTime? to = null, int? pageNo = null, int? pageSize = null)

Get the list of Consents Sent to Individuals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentsSentToIndividualsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. (optional) 
            var from = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From date time in utc timezone. (optional) 
            var to = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Til date time in utc timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get the list of Consents Sent to Individuals.
                UserDataConsentInfoDtoPaginatedList result = apiInstance.GetConsentsSentToIndividuals(status, from, to, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsentsSentToIndividuals: " + e.Message );
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
 **status** | [**DataConsentStatus?**](DataConsentStatus?.md)| Data consent status MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. | [optional] 
 **from** | **DateTime?**| From date time in utc timezone. | [optional] 
 **to** | **DateTime?**| Til date time in utc timezone. | [optional] 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorgconsentedaccounttransactions"></a>
# **GetOrgConsentedAccountTransactions**
> OrganizationFinancialTransactionsDtoPaginatedList GetOrgConsentedAccountTransactions (Guid consentId, Guid accountId, string? filters = null, DateTime? fromDateTimeUtc = null, DateTime? toDateTimeUtc = null, int? pageNo = null, int? pageSize = null)

Get organization consented financial account transactions of an individual based on accountId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrgConsentedAccountTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var accountId = "accountId_example";  // Guid | Account id.
            var filters = "filters_example";  // string? | Filters. (optional) 
            var fromDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From date time in utc timezone. (optional) 
            var toDateTimeUtc = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Til date time in utc timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get organization consented financial account transactions of an individual based on accountId.
                OrganizationFinancialTransactionsDtoPaginatedList result = apiInstance.GetOrgConsentedAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrgConsentedAccountTransactions: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **accountId** | **Guid**| Account id. | 
 **filters** | **string?**| Filters. | [optional] 
 **fromDateTimeUtc** | **DateTime?**| From date time in utc timezone. | [optional] 
 **toDateTimeUtc** | **DateTime?**| Til date time in utc timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**OrganizationFinancialTransactionsDtoPaginatedList**](OrganizationFinancialTransactionsDtoPaginatedList.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationconsentdetailsbyid"></a>
# **GetOrganizationConsentDetailsById**
> DataConsentDetailsDto GetOrganizationConsentDetailsById (Guid consentId)

Get all organization consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationConsentDetailsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.

            try
            {
                // Get all organization consent details by consent id.
                DataConsentDetailsDto result = apiInstance.GetOrganizationConsentDetailsById(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrganizationConsentDetailsById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationconsenteddocumentbyid"></a>
# **GetOrganizationConsentedDocumentById**
> OrganizationDocumentDetails GetOrganizationConsentedDocumentById (Guid consentId, Guid documentId)

Get organization consent document based on document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Consent id.
            var documentId = "documentId_example";  // Guid | Document Id.

            try
            {
                // Get organization consent document based on document id.
                OrganizationDocumentDetails result = apiInstance.GetOrganizationConsentedDocumentById(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrganizationConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Consent id. | 
 **documentId** | **Guid**| Document Id. | 

### Return type

[**OrganizationDocumentDetails**](OrganizationDocumentDetails.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

