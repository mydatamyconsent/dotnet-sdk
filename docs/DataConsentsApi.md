# MyDataMyConsent.Api.DataConsentsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1ConsentsConsentIdAccountsAccountIdGet**](DataConsentsApi.md#v1consentsconsentidaccountsaccountidget) | **GET** /v1/consents/{consentId}/accounts/{accountId} | Get consented financial account details.
[**V1ConsentsConsentIdAccountsAccountIdInsightsGet**](DataConsentsApi.md#v1consentsconsentidaccountsaccountidinsightsget) | **GET** /v1/consents/{consentId}/accounts/{accountId}/insights | Get consented financial account insights.
[**V1ConsentsConsentIdAccountsAccountIdTransactionsGet**](DataConsentsApi.md#v1consentsconsentidaccountsaccountidtransactionsget) | **GET** /v1/consents/{consentId}/accounts/{accountId}/transactions | Get consented financial account transactions.
[**V1ConsentsConsentIdAccountsGet**](DataConsentsApi.md#v1consentsconsentidaccountsget) | **GET** /v1/consents/{consentId}/accounts | Get all accounts in a consent.
[**V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet**](DataConsentsApi.md#v1consentsconsentiddocumentsdocumentidanalysisget) | **GET** /v1/consents/{consentId}/documents/{documentId}/analysis | Get analysis of a consented document.
[**V1ConsentsConsentIdDocumentsDocumentIdDownloadGet**](DataConsentsApi.md#v1consentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/consents/{consentId}/documents/{documentId}/download | Download a consented document.
[**V1ConsentsConsentIdDocumentsDocumentIdGet**](DataConsentsApi.md#v1consentsconsentiddocumentsdocumentidget) | **GET** /v1/consents/{consentId}/documents/{documentId} | Get consented document details.
[**V1ConsentsConsentIdDocumentsGet**](DataConsentsApi.md#v1consentsconsentiddocumentsget) | **GET** /v1/consents/{consentId}/documents | Get all documents in a consent.
[**V1ConsentsConsentIdGet**](DataConsentsApi.md#v1consentsconsentidget) | **GET** /v1/consents/{consentId} | Get consent details by consent id.
[**V1ConsentsGet**](DataConsentsApi.md#v1consentsget) | **GET** /v1/consents | Get all consents filtered by status and time.


<a name="v1consentsconsentidaccountsaccountidget"></a>
# **V1ConsentsConsentIdAccountsAccountIdGet**
> Object V1ConsentsConsentIdAccountsAccountIdGet (string consentId, string accountId)

Get consented financial account details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdAccountsAccountIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var accountId = accountId_example;  // string | 

            try
            {
                // Get consented financial account details.
                Object result = apiInstance.V1ConsentsConsentIdAccountsAccountIdGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdAccountsAccountIdGet: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentidaccountsaccountidinsightsget"></a>
# **V1ConsentsConsentIdAccountsAccountIdInsightsGet**
> Object V1ConsentsConsentIdAccountsAccountIdInsightsGet (string consentId, string accountId)

Get consented financial account insights.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdAccountsAccountIdInsightsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var accountId = accountId_example;  // string | 

            try
            {
                // Get consented financial account insights.
                Object result = apiInstance.V1ConsentsConsentIdAccountsAccountIdInsightsGet(consentId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdAccountsAccountIdInsightsGet: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentidaccountsaccountidtransactionsget"></a>
# **V1ConsentsConsentIdAccountsAccountIdTransactionsGet**
> Object V1ConsentsConsentIdAccountsAccountIdTransactionsGet (string consentId, string accountId, string filters = null, DateTime? fromDate = null, DateTime? toDate = null)

Get consented financial account transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdAccountsAccountIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var accountId = accountId_example;  // string | 
            var filters = filters_example;  // string |  (optional) 
            var fromDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var toDate = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Get consented financial account transactions.
                Object result = apiInstance.V1ConsentsConsentIdAccountsAccountIdTransactionsGet(consentId, accountId, filters, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdAccountsAccountIdTransactionsGet: " + e.Message );
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
 **filters** | **string**|  | [optional] 
 **fromDate** | **DateTime?**|  | [optional] 
 **toDate** | **DateTime?**|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentidaccountsget"></a>
# **V1ConsentsConsentIdAccountsGet**
> Object V1ConsentsConsentIdAccountsGet (string consentId)

Get all accounts in a consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 

            try
            {
                // Get all accounts in a consent.
                Object result = apiInstance.V1ConsentsConsentIdAccountsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdAccountsGet: " + e.Message );
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

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentiddocumentsdocumentidanalysisget"></a>
# **V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet**
> Object V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet (string consentId, string documentId)

Get analysis of a consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdDocumentsDocumentIdAnalysisGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var documentId = documentId_example;  // string | Document Id.

            try
            {
                // Get analysis of a consented document.
                Object result = apiInstance.V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentiddocumentsdocumentiddownloadget"></a>
# **V1ConsentsConsentIdDocumentsDocumentIdDownloadGet**
> Object V1ConsentsConsentIdDocumentsDocumentIdDownloadGet (string consentId, string documentId)

Download a consented document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdDocumentsDocumentIdDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var documentId = documentId_example;  // string | Document Id.

            try
            {
                // Download a consented document.
                Object result = apiInstance.V1ConsentsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdDocumentsDocumentIdDownloadGet: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentiddocumentsdocumentidget"></a>
# **V1ConsentsConsentIdDocumentsDocumentIdGet**
> Object V1ConsentsConsentIdDocumentsDocumentIdGet (string consentId, string documentId)

Get consented document details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdDocumentsDocumentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 
            var documentId = documentId_example;  // string | Document Id.

            try
            {
                // Get consented document details.
                Object result = apiInstance.V1ConsentsConsentIdDocumentsDocumentIdGet(consentId, documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdDocumentsDocumentIdGet: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentiddocumentsget"></a>
# **V1ConsentsConsentIdDocumentsGet**
> Object V1ConsentsConsentIdDocumentsGet (string consentId)

Get all documents in a consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 

            try
            {
                // Get all documents in a consent.
                Object result = apiInstance.V1ConsentsConsentIdDocumentsGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdDocumentsGet: " + e.Message );
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

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsconsentidget"></a>
# **V1ConsentsConsentIdGet**
> Object V1ConsentsConsentIdGet (string consentId)

Get consent details by consent id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsConsentIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var consentId = consentId_example;  // string | 

            try
            {
                // Get consent details by consent id.
                Object result = apiInstance.V1ConsentsConsentIdGet(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsConsentIdGet: " + e.Message );
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

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1consentsget"></a>
# **V1ConsentsGet**
> Object V1ConsentsGet (DataConsentStatus? status = null, DateTime? startDate = null, DateTime? endDate = null)

Get all consents filtered by status and time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1ConsentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentsApi(config);
            var status = ;  // DataConsentStatus? | MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | System.DateTime. (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | till dateSystem.DateTime. (optional) 

            try
            {
                // Get all consents filtered by status and time.
                Object result = apiInstance.V1ConsentsGet(status, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataConsentsApi.V1ConsentsGet: " + e.Message );
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
 **status** | **DataConsentStatus?**| MyDataMyConsent.Domain.Entities.ConsentAggregate.Enums.DataConsentStatus. | [optional] 
 **startDate** | **DateTime?**| System.DateTime. | [optional] 
 **endDate** | **DateTime?**| till dateSystem.DateTime. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

