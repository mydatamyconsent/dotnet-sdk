# MyDataMyConsent.Api.SupportedIdentifiersApi

All URIs are relative to *https://api.mydatamyconsent.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1SupportedIdentifiersCountryIso2CodeGet**](SupportedIdentifiersApi.md#v1supportedidentifierscountryiso2codeget) | **GET** /v1/supported-identifiers/{country_iso2_code} | Get all supported identifiers by country. |

<a name="v1supportedidentifierscountryiso2codeget"></a>
# **V1SupportedIdentifiersCountryIso2CodeGet**
> SupportedIdentifier V1SupportedIdentifiersCountryIso2CodeGet (string countryIso2Code)

Get all supported identifiers by country.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1SupportedIdentifiersCountryIso2CodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SupportedIdentifiersApi(config);
            var countryIso2Code = "countryIso2Code_example";  // string | 

            try
            {
                // Get all supported identifiers by country.
                SupportedIdentifier result = apiInstance.V1SupportedIdentifiersCountryIso2CodeGet(countryIso2Code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportedIdentifiersApi.V1SupportedIdentifiersCountryIso2CodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SupportedIdentifiersCountryIso2CodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all supported identifiers by country.
    ApiResponse<SupportedIdentifier> response = apiInstance.V1SupportedIdentifiersCountryIso2CodeGetWithHttpInfo(countryIso2Code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupportedIdentifiersApi.V1SupportedIdentifiersCountryIso2CodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **countryIso2Code** | **string** |  |  |

### Return type

[**SupportedIdentifier**](SupportedIdentifier.md)

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

