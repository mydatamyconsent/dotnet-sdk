# MyDataMyConsent.Sdk.Api.DigiLockerCompatIssuerApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DigilockerCompatIssueDocument**](DigiLockerCompatIssuerApi.md#digilockercompatissuedocument) | **POST** /issuer/issuedoc/1/xml | Digilocker Compatible endpoint to issue document.


<a name="digilockercompatissuedocument"></a>
# **DigilockerCompatIssueDocument**
> PushUriResponse DigilockerCompatIssueDocument (PushUriRequest? pushUriRequest = null)

Digilocker Compatible endpoint to issue document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class DigilockerCompatIssueDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new DigiLockerCompatIssuerApi(config);
            var pushUriRequest = new PushUriRequest?(); // PushUriRequest? | Push uri request MyDataMyConsent.Models.DigiLocker.PushUriRequest. (optional) 

            try
            {
                // Digilocker Compatible endpoint to issue document.
                PushUriResponse result = apiInstance.DigilockerCompatIssueDocument(pushUriRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DigiLockerCompatIssuerApi.DigilockerCompatIssueDocument: " + e.Message );
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
 **pushUriRequest** | [**PushUriRequest?**](PushUriRequest?.md)| Push uri request MyDataMyConsent.Models.DigiLocker.PushUriRequest. | [optional] 

### Return type

[**PushUriResponse**](PushUriResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml
 - **Accept**: application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Server Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

