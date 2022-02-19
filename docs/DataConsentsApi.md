# MyDataMyConsent.Sdk.Api.DataConsentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1ConsentsIndividualsConsentIdAccountsAccountIdGet**](DataConsentsApi.md#v1consentsindividualsconsentidaccountsaccountidget) | **GET** /v1/consents/individuals/{consentId}/accounts/{accountId} | Get individual consented financial account details based on account id.
[**V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet**](DataConsentsApi.md#v1consentsindividualsconsentidaccountsaccountidtransactionsget) | **GET** /v1/consents/individuals/{consentId}/accounts/{accountId}/transactions | Get consented financial account transactions of an individual based on accountId.
[**V1ConsentsIndividualsConsentIdAccountsGet**](DataConsentsApi.md#v1consentsindividualsconsentidaccountsget) | **GET** /v1/consents/individuals/{consentId}/accounts | Get all individual financial accounts in a consent.
[**V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet**](DataConsentsApi.md#v1consentsindividualsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId}/download | Download a individuals consented document.
[**V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet**](DataConsentsApi.md#v1consentsindividualsconsentiddocumentsdocumentidget) | **GET** /v1/consents/individuals/{consentId}/documents/{documentId} | Get individuals consent document based on document id.
[**V1ConsentsIndividualsConsentIdDocumentsGet**](DataConsentsApi.md#v1consentsindividualsconsentiddocumentsget) | **GET** /v1/consents/individuals/{consentId}/documents | Get the individual documents based on ConsentId.
[**V1ConsentsIndividualsConsentIdGet**](DataConsentsApi.md#v1consentsindividualsconsentidget) | **GET** /v1/consents/individuals/{consentId} | Get individuals consent details by consent id.
[**V1ConsentsIndividualsGet**](DataConsentsApi.md#v1consentsindividualsget) | **GET** /v1/consents/individuals | Get the list of Consents Sent to Individuals.
[**V1ConsentsOrganizationsConsentIdAccountsAccountIdGet**](DataConsentsApi.md#v1consentsorganizationsconsentidaccountsaccountidget) | **GET** /v1/consents/organizations/{consentId}/accounts/{accountId} | Get orgnization consented financial account details based on account id.
[**V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet**](DataConsentsApi.md#v1consentsorganizationsconsentidaccountsaccountidtransactionsget) | **GET** /v1/consents/organizations/{consentId}/accounts/{accountId}/transactions | Get consented financial account transactions of an organization based on accountId.
[**V1ConsentsOrganizationsConsentIdAccountsGet**](DataConsentsApi.md#v1consentsorganizationsconsentidaccountsget) | **GET** /v1/consents/organizations/{consentId}/accounts | Get all organizational financial accounts in a consent.
[**V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet**](DataConsentsApi.md#v1consentsorganizationsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId}/download | Download organizations consented document.
[**V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet**](DataConsentsApi.md#v1consentsorganizationsconsentiddocumentsdocumentidget) | **GET** /v1/consents/organizations/{consentId}/documents/{documentId} | Get organizations consent document based on document id.
[**V1ConsentsOrganizationsConsentIdDocumentsGet**](DataConsentsApi.md#v1consentsorganizationsconsentiddocumentsget) | **GET** /v1/consents/organizations/{consentId}/documents | Get the organizations documents based on ConsentId.
[**V1ConsentsOrganizationsConsentIdGet**](DataConsentsApi.md#v1consentsorganizationsconsentidget) | **GET** /v1/consents/organizations/{consentId} | Get organizations consent details by consent id.
[**V1ConsentsOrganizationsGet**](DataConsentsApi.md#v1consentsorganizationsget) | **GET** /v1/consents/organizations | Get the list of data consents sent for organizations.


<a name="v1consentsindividualsconsentidaccountsaccountidget"></a>
# **V1ConsentsIndividualsConsentIdAccountsAccountIdGet**
> FinancialAccount V1ConsentsIndividualsConsentIdAccountsAccountIdGet (Guid consentId, Guid accountId)

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
    public class V1ConsentsIndividualsConsentIdAccountsAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Get individual consented financial account details based on account id.
                FinancialAccount result = apiInstance.V1ConsentsIndividualsConsentIdAccountsAccountIdGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdAccountsAccountIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **accountId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsindividualsconsentidaccountsaccountidtransactionsget"></a>
# **V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet**
> UserAccountFinancialTransactionsDtoPaginatedList V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet (Guid consentId, Guid accountId, string filters = null, int? pageNo = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)

Get consented financial account transactions of an individual based on accountId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 
            var filters = "filters_example";  // string |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var fromDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Get consented financial account transactions of an individual based on accountId.
                UserAccountFinancialTransactionsDtoPaginatedList result = apiInstance.V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet(consentId, accountId, filters, pageNo, pageSize, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **accountId** | **Guid**|  | 
 **filters** | **string**|  | [optional] 
 **pageNo** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **fromDate** | **DateTime?**|  | [optional] 
 **toDate** | **DateTime?**|  | [optional] 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsindividualsconsentidaccountsget"></a>
# **V1ConsentsIndividualsConsentIdAccountsGet**
> DataConsentFinancialsDto V1ConsentsIndividualsConsentIdAccountsGet (Guid consentId)

Get all individual financial accounts in a consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsIndividualsConsentIdAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get all individual financial accounts in a consent.
                DataConsentFinancialsDto result = apiInstance.V1ConsentsIndividualsConsentIdAccountsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdAccountsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsindividualsconsentiddocumentsdocumentiddownloadget"></a>
# **V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet**
> UserDocumentDownloadDto V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet (Guid consentId, Guid documentId)

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
    public class V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | consentId.
            var documentId = "documentId_example";  // Guid | documentId.

            try
            {
                // Download a individuals consented document.
                UserDocumentDownloadDto result = apiInstance.V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet: " + e.Message );
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
 **consentId** | **Guid**| consentId. | 
 **documentId** | **Guid**| documentId. | 

### Return type

[**UserDocumentDownloadDto**](UserDocumentDownloadDto.md)

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

<a name="v1consentsindividualsconsentiddocumentsdocumentidget"></a>
# **V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet**
> UserDocumentDetailsDto V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet (Guid consentId, Guid documentId)

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
    public class V1ConsentsIndividualsConsentIdDocumentsDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var documentId = "documentId_example";  // Guid | Document Id.

            try
            {
                // Get individuals consent document based on document id.
                UserDocumentDetailsDto result = apiInstance.V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **documentId** | **Guid**| Document Id. | 

### Return type

[**UserDocumentDetailsDto**](UserDocumentDetailsDto.md)

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

<a name="v1consentsindividualsconsentiddocumentsget"></a>
# **V1ConsentsIndividualsConsentIdDocumentsGet**
> DataConsentDocumentsDto V1ConsentsIndividualsConsentIdDocumentsGet (Guid consentId)

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
    public class V1ConsentsIndividualsConsentIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get the individual documents based on ConsentId.
                DataConsentDocumentsDto result = apiInstance.V1ConsentsIndividualsConsentIdDocumentsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdDocumentsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsindividualsconsentidget"></a>
# **V1ConsentsIndividualsConsentIdGet**
> DataConsentDetailsDto V1ConsentsIndividualsConsentIdGet (Guid consentId)

Get individuals consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsIndividualsConsentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get individuals consent details by consent id.
                DataConsentDetailsDto result = apiInstance.V1ConsentsIndividualsConsentIdGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsConsentIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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

<a name="v1consentsindividualsget"></a>
# **V1ConsentsIndividualsGet**
> UserDataConsentInfoDtoPaginatedList V1ConsentsIndividualsGet (int? pageNo = null, int? pageSize = null, DataConsentStatus? status = null, DateTime? startDate = null, DateTime? endDate = null)

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
    public class V1ConsentsIndividualsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var status = (DataConsentStatus) "Pending";  // DataConsentStatus? |  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Get the list of Consents Sent to Individuals.
                UserDataConsentInfoDtoPaginatedList result = apiInstance.V1ConsentsIndividualsGet(pageNo, pageSize, status, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsIndividualsGet: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

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

<a name="v1consentsorganizationsconsentidaccountsaccountidget"></a>
# **V1ConsentsOrganizationsConsentIdAccountsAccountIdGet**
> OrganizationFinancialAccountDto V1ConsentsOrganizationsConsentIdAccountsAccountIdGet (Guid consentId, Guid accountId)

Get orgnization consented financial account details based on account id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdAccountsAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 

            try
            {
                // Get orgnization consented financial account details based on account id.
                OrganizationFinancialAccountDto result = apiInstance.V1ConsentsOrganizationsConsentIdAccountsAccountIdGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdAccountsAccountIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **accountId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsorganizationsconsentidaccountsaccountidtransactionsget"></a>
# **V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet**
> OrganizationFinancialTransactionsDtoPaginatedList V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet (Guid consentId, Guid accountId, string filters = null, int? pageNo = null, int? pageSize = null, DateTime? fromDate = null, DateTime? toDate = null)

Get consented financial account transactions of an organization based on accountId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var accountId = "accountId_example";  // Guid | 
            var filters = "filters_example";  // string |  (optional) 
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var fromDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var toDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Get consented financial account transactions of an organization based on accountId.
                OrganizationFinancialTransactionsDtoPaginatedList result = apiInstance.V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet(consentId, accountId, filters, pageNo, pageSize, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **accountId** | **Guid**|  | 
 **filters** | **string**|  | [optional] 
 **pageNo** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **fromDate** | **DateTime?**|  | [optional] 
 **toDate** | **DateTime?**|  | [optional] 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsorganizationsconsentidaccountsget"></a>
# **V1ConsentsOrganizationsConsentIdAccountsGet**
> DataConsentFinancialsDto V1ConsentsOrganizationsConsentIdAccountsGet (Guid consentId)

Get all organizational financial accounts in a consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get all organizational financial accounts in a consent.
                DataConsentFinancialsDto result = apiInstance.V1ConsentsOrganizationsConsentIdAccountsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdAccountsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsorganizationsconsentiddocumentsdocumentiddownloadget"></a>
# **V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet**
> OrganizationDocumentDownloadDto V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet (Guid consentId, Guid documentId)

Download organizations consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var documentId = "documentId_example";  // Guid | 

            try
            {
                // Download organizations consented document.
                OrganizationDocumentDownloadDto result = apiInstance.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **documentId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsorganizationsconsentiddocumentsdocumentidget"></a>
# **V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet**
> OrganizationDocumentDetailsDto V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet (Guid consentId, Guid documentId)

Get organizations consent document based on document id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 
            var documentId = "documentId_example";  // Guid | 

            try
            {
                // Get organizations consent document based on document id.
                OrganizationDocumentDetailsDto result = apiInstance.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 
 **documentId** | **Guid**|  | 

### Return type

[**OrganizationDocumentDetailsDto**](OrganizationDocumentDetailsDto.md)

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

<a name="v1consentsorganizationsconsentiddocumentsget"></a>
# **V1ConsentsOrganizationsConsentIdDocumentsGet**
> DataConsentDocumentsDto V1ConsentsOrganizationsConsentIdDocumentsGet (Guid consentId)

Get the organizations documents based on ConsentId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get the organizations documents based on ConsentId.
                DataConsentDocumentsDto result = apiInstance.V1ConsentsOrganizationsConsentIdDocumentsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdDocumentsGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsorganizationsconsentidget"></a>
# **V1ConsentsOrganizationsConsentIdGet**
> DataConsentDetailsDto V1ConsentsOrganizationsConsentIdGet (Guid consentId)

Get organizations consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class V1ConsentsOrganizationsConsentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = "consentId_example";  // Guid | 

            try
            {
                // Get organizations consent details by consent id.
                DataConsentDetailsDto result = apiInstance.V1ConsentsOrganizationsConsentIdGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsConsentIdGet: " + e.Message );
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
 **consentId** | **Guid**|  | 

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

<a name="v1consentsorganizationsget"></a>
# **V1ConsentsOrganizationsGet**
> OrganizationDataConsentInfoDtoPaginatedList V1ConsentsOrganizationsGet (int? pageNo = null, int? pageSize = null, DataConsentStatus? status = null, DateTime? startDate = null, DateTime? endDate = null)

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
    public class V1ConsentsOrganizationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var status = (DataConsentStatus) "Pending";  // DataConsentStatus? |  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Get the list of data consents sent for organizations.
                OrganizationDataConsentInfoDtoPaginatedList result = apiInstance.V1ConsentsOrganizationsGet(pageNo, pageSize, status, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsOrganizationsGet: " + e.Message );
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
 **startDate** | **DateTime?**|  | [optional] 
 **endDate** | **DateTime?**|  | [optional] 

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

