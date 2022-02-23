# MyDataMyConsent.Sdk.Api.SupportedIdentifiersApi

All URIs are relative to *https://api.mydatamyconsent.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSupportedIdentifiers**](SupportedIdentifiersApi.md#getallsupportedidentifiers) | **GET** /v1/supported-identifiers/{countryIso2Code} | Get all supported identifiers by country.


<a name="getallsupportedidentifiers"></a>
# **GetAllSupportedIdentifiers**
> SupportedIdentifier GetAllSupportedIdentifiers (string countryIso2Code)

Get all supported identifiers by country.

Get all supported identifiers by country.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Models;

namespace Example
{
    public class GetAllSupportedIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            var apiInstance = new SupportedIdentifiersApi(config);
            var countryIso2Code = "countryIso2Code_example";  // string | Country ISO 2 code.

            try
            {
                // Get all supported identifiers by country.
                SupportedIdentifier result = apiInstance.GetAllSupportedIdentifiers(countryIso2Code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportedIdentifiersApi.GetAllSupportedIdentifiers: " + e.Message );
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
 **countryIso2Code** | **string**| Country ISO 2 code. | 

### Return type

[**SupportedIdentifier**](SupportedIdentifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

