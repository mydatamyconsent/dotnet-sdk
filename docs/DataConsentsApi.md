# MyDataMyConsent.Sdk.Api.DataConsentsApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadConsentedDocumentAnalysis**](DataConsentsApi.md#downloadconsenteddocumentanalysis) | **GET** /v1/consents/{consentId}/documents/{documentId}/analysis | Get analysis of a consented document.
[**DownloadIndividualConsentedDocumentById**](DataConsentsApi.md#downloadindividualconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId}/download | Download individual consented document by document id.
[**DownloadOrganizationConsentedDocumentById**](DataConsentsApi.md#downloadorganizationconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId}/download | Download organization consent document based on document id.
[**GetAllConsentedFinancialAccounts**](DataConsentsApi.md#getallconsentedfinancialaccounts) | **GET** /v1/consents/individuals/{consentId}/financial-accounts | Get all individual consented financial accounts.
[**GetConsentFinancialAccounts**](DataConsentsApi.md#getconsentfinancialaccounts) | **GET** /v1/consents/organizations/{consentId}/financial-accounts | Get all organizational consented financial accounts.
[**GetConsentedAccountById**](DataConsentsApi.md#getconsentedaccountbyid) | **GET** /v1/consents/individuals/{consentId}/financial-accounts/{accountId} | Get individual consented financial account details based on account id.
[**GetConsentedDocumentById**](DataConsentsApi.md#getconsenteddocumentbyid) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId} | Get individual consented document by document id.
[**GetConsentedFinancialAccount**](DataConsentsApi.md#getconsentedfinancialaccount) | **GET** /v1/consents/organizations/{consentId}/financial-accounts/{accountId} | Get organization consented financial account details based on account id.
[**GetConsentedFinancialAccountInsights**](DataConsentsApi.md#getconsentedfinancialaccountinsights) | **GET** /v1/consents/{consentId}/financial-accounts/{accountId}/insights | Get consented financial account insights.
[**GetConsentedFinancialAccountTransactions**](DataConsentsApi.md#getconsentedfinancialaccounttransactions) | **GET** /v1/consents/individuals/{consentId}/financial-accounts/{accountId}/transactions | Get individual consented financial account transactions of an individual based on accountId.
[**GetConsents**](DataConsentsApi.md#getconsents) | **GET** /v1/consents/individuals | Get the paginated list of individual data consents.
[**GetIndividualConsentedDocuments**](DataConsentsApi.md#getindividualconsenteddocuments) | **GET** /v1/consents/individuals/{consentId}/documents | Get individual consented documents by consent id.
[**GetIndividualDataConsentById**](DataConsentsApi.md#getindividualdataconsentbyid) | **GET** /v1/consents/individuals/{consentId} | Get individuals data consent details by consent id.
[**GetOrgConsentedAccountTransactions**](DataConsentsApi.md#getorgconsentedaccounttransactions) | **GET** /v1/consents/organizations/{consentId}/financial-accounts/{accountId}/transactions | Get organization consented financial account transactions of an individual based on accountId.
[**GetOrganizationConsentedDocumentById**](DataConsentsApi.md#getorganizationconsenteddocumentbyid) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId} | Get organization consent document based on document id.
[**GetOrganizationConsentedDocuments**](DataConsentsApi.md#getorganizationconsenteddocuments) | **GET** /v1/consents/organizations/{consentId}/documents | Get organization consented documents by consent id.
[**GetOrganizationDataConsentById**](DataConsentsApi.md#getorganizationdataconsentbyid) | **GET** /v1/consents/organizations/{consentId} | Get organizations data consent details by consent id.
[**GetOrganizationDataConsents**](DataConsentsApi.md#getorganizationdataconsents) | **GET** /v1/consents/organizations | Get the paginated list of organization data consents.


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
            var consentId = "consentId_example";  // string | Data consent id.
            var documentId = "documentId_example";  // string | Consented document Id.

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
 **consentId** | **string**| Data consent id. | 
 **documentId** | **string**| Consented document Id. | 

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadindividualconsenteddocumentbyid"></a>
# **DownloadIndividualConsentedDocumentById**
> void DownloadIndividualConsentedDocumentById (Guid consentId, string documentId)

Download individual consented document by document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DownloadIndividualConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Individual data consent id.
            var documentId = "documentId_example";  // string | Consented document id.

            try
            {
                // Download individual consented document by document id.
                apiInstance.DownloadIndividualConsentedDocumentById(consentId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.DownloadIndividualConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Individual data consent id. | 
 **documentId** | **string**| Consented document id. | 

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadorganizationconsenteddocumentbyid"></a>
# **DownloadOrganizationConsentedDocumentById**
> void DownloadOrganizationConsentedDocumentById (Guid consentId, string documentId)

Download organization consent document based on document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DownloadOrganizationConsentedDocumentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Organization data consent id.
            var documentId = "documentId_example";  // string | Organization consented document Id.

            try
            {
                // Download organization consent document based on document id.
                apiInstance.DownloadOrganizationConsentedDocumentById(consentId, documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.DownloadOrganizationConsentedDocumentById: " + e.Message );
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
 **consentId** | **Guid**| Organization data consent id. | 
 **documentId** | **string**| Organization consented document Id. | 

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
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
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
> DataConsentDocument GetConsentedDocumentById (Guid consentId, string documentId)

Get individual consented document by document id.

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
            var consentId = "consentId_example";  // Guid | Individual data consent id.
            var documentId = "documentId_example";  // string | Consented document id.

            try
            {
                // Get individual consented document by document id.
                DataConsentDocument result = apiInstance.GetConsentedDocumentById(consentId, documentId);
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
 **consentId** | **Guid**| Individual data consent id. | 
 **documentId** | **string**| Consented document id. | 

### Return type

[**DataConsentDocument**](DataConsentDocument.md)

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
| **404** | Not Found |  -  |
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

<a name="getconsents"></a>
# **GetConsents**
> DataConsentDetailsPaginatedList GetConsents (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get the paginated list of individual data consents.

GetIndividualDataConsents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From datetime in UTC timezone. (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | To datetime in UTC timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get the paginated list of individual data consents.
                DataConsentDetailsPaginatedList result = apiInstance.GetConsents(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetConsents: " + e.Message );
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
 **fromDateTime** | **DateTime?**| From datetime in UTC timezone. | [optional] 
 **toDateTime** | **DateTime?**| To datetime in UTC timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**DataConsentDetailsPaginatedList**](DataConsentDetailsPaginatedList.md)

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

<a name="getindividualconsenteddocuments"></a>
# **GetIndividualConsentedDocuments**
> List&lt;DataConsentDocument&gt; GetIndividualConsentedDocuments (Guid consentId)

Get individual consented documents by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetIndividualConsentedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Individual data consent id.

            try
            {
                // Get individual consented documents by consent id.
                List<DataConsentDocument> result = apiInstance.GetIndividualConsentedDocuments(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetIndividualConsentedDocuments: " + e.Message );
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
 **consentId** | **Guid**| Individual data consent id. | 

### Return type

[**List&lt;DataConsentDocument&gt;**](DataConsentDocument.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindividualdataconsentbyid"></a>
# **GetIndividualDataConsentById**
> DataConsent GetIndividualDataConsentById (Guid consentId)

Get individuals data consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetIndividualDataConsentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Individual data consent id.

            try
            {
                // Get individuals data consent details by consent id.
                DataConsent result = apiInstance.GetIndividualDataConsentById(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetIndividualDataConsentById: " + e.Message );
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
 **consentId** | **Guid**| Individual data consent id. | 

### Return type

[**DataConsent**](DataConsent.md)

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
| **404** | Not Found |  -  |
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

<a name="getorganizationconsenteddocumentbyid"></a>
# **GetOrganizationConsentedDocumentById**
> DataConsentDocument GetOrganizationConsentedDocumentById (Guid consentId, string documentId)

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
            var consentId = "consentId_example";  // Guid | Organization data consent id.
            var documentId = "documentId_example";  // string | Organization consented document Id.

            try
            {
                // Get organization consent document based on document id.
                DataConsentDocument result = apiInstance.GetOrganizationConsentedDocumentById(consentId, documentId);
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
 **consentId** | **Guid**| Organization data consent id. | 
 **documentId** | **string**| Organization consented document Id. | 

### Return type

[**DataConsentDocument**](DataConsentDocument.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationconsenteddocuments"></a>
# **GetOrganizationConsentedDocuments**
> List&lt;DataConsentDocument&gt; GetOrganizationConsentedDocuments (Guid consentId)

Get organization consented documents by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationConsentedDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Organization data consent id.

            try
            {
                // Get organization consented documents by consent id.
                List<DataConsentDocument> result = apiInstance.GetOrganizationConsentedDocuments(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrganizationConsentedDocuments: " + e.Message );
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
 **consentId** | **Guid**| Organization data consent id. | 

### Return type

[**List&lt;DataConsentDocument&gt;**](DataConsentDocument.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationdataconsentbyid"></a>
# **GetOrganizationDataConsentById**
> DataConsent GetOrganizationDataConsentById (Guid consentId)

Get organizations data consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationDataConsentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | Organization data consent id.

            try
            {
                // Get organizations data consent details by consent id.
                DataConsent result = apiInstance.GetOrganizationDataConsentById(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrganizationDataConsentById: " + e.Message );
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
 **consentId** | **Guid**| Organization data consent id. | 

### Return type

[**DataConsent**](DataConsent.md)

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
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationdataconsents"></a>
# **GetOrganizationDataConsents**
> DataConsentDetailsPaginatedList GetOrganizationDataConsents (DataConsentStatus? status = null, DateTime? fromDateTime = null, DateTime? toDateTime = null, int? pageNo = null, int? pageSize = null)

Get the paginated list of organization data consents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetOrganizationDataConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DataConsentsApi(config);
            var status = new DataConsentStatus?(); // DataConsentStatus? | Data consent status. (optional) 
            var fromDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | From datetime in UTC timezone. (optional) 
            var toDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | To datetime in UTC timezone. (optional) 
            var pageNo = 1;  // int? | Page number. (optional)  (default to 1)
            var pageSize = 25;  // int? | Number of items to return. (optional)  (default to 25)

            try
            {
                // Get the paginated list of organization data consents.
                DataConsentDetailsPaginatedList result = apiInstance.GetOrganizationDataConsents(status, fromDateTime, toDateTime, pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.GetOrganizationDataConsents: " + e.Message );
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
 **fromDateTime** | **DateTime?**| From datetime in UTC timezone. | [optional] 
 **toDateTime** | **DateTime?**| To datetime in UTC timezone. | [optional] 
 **pageNo** | **int?**| Page number. | [optional] [default to 1]
 **pageSize** | **int?**| Number of items to return. | [optional] [default to 25]

### Return type

[**DataConsentDetailsPaginatedList**](DataConsentDetailsPaginatedList.md)

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

