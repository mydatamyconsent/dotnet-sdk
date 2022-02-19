# MyDataMyConsent.Sdk.Api.DigiLockerCompatIssuerApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IssuerIssuedoc1XmlPost**](DigiLockerCompatIssuerApi.md#issuerissuedoc1xmlpost) | **POST** /issuer/issuedoc/1/xml | Digilocker Compatible endpoint to Issue Documents.


<a name="issuerissuedoc1xmlpost"></a>
# **IssuerIssuedoc1XmlPost**
> PushUriResponse IssuerIssuedoc1XmlPost (PushUriRequest pushUriRequest = null)

Digilocker Compatible endpoint to Issue Documents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class IssuerIssuedoc1XmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DigiLockerCompatIssuerApi(config);
            var pushUriRequest = new PushUriRequest(); // PushUriRequest |  (optional) 

            try
            {
                // Digilocker Compatible endpoint to Issue Documents.
                PushUriResponse result = apiInstance.IssuerIssuedoc1XmlPost(pushUriRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DigiLockerCompatIssuerApi.IssuerIssuedoc1XmlPost: " + e.Message );
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
 **pushUriRequest** | [**PushUriRequest**](PushUriRequest.md)|  | [optional] 

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

