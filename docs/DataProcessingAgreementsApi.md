# MyDataMyConsent.Api.DataProcessingAgreementsApi

All URIs are relative to *https://api.mydatamyconsent.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1DataAgreementsGet**](DataProcessingAgreementsApi.md#v1dataagreementsget) | **GET** /v1/data-agreements | Get paginated data processing agreements. |
| [**V1DataAgreementsIdDelete**](DataProcessingAgreementsApi.md#v1dataagreementsiddelete) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement this will not delete a published or a agreement in use with consents. |
| [**V1DataAgreementsIdGet**](DataProcessingAgreementsApi.md#v1dataagreementsidget) | **GET** /v1/data-agreements/{id} | Get data processing agreement by id. |
| [**V1DataAgreementsIdPut**](DataProcessingAgreementsApi.md#v1dataagreementsidput) | **PUT** /v1/data-agreements/{id} | Update data processing agreement. |
| [**V1DataAgreementsIdTerminatePut**](DataProcessingAgreementsApi.md#v1dataagreementsidterminateput) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement by id. |
| [**V1DataAgreementsPost**](DataProcessingAgreementsApi.md#v1dataagreementspost) | **POST** /v1/data-agreements | Create a data processing agreement. |

<a name="v1dataagreementsget"></a>
# **V1DataAgreementsGet**
> PaginatedListOfDataProcessingAgreements V1DataAgreementsGet (int? pageNo = null, int? pageSize = null)

Get paginated data processing agreements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var pageNo = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get paginated data processing agreements.
                PaginatedListOfDataProcessingAgreements result = apiInstance.V1DataAgreementsGet(pageNo, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get paginated data processing agreements.
    ApiResponse<PaginatedListOfDataProcessingAgreements> response = apiInstance.V1DataAgreementsGetWithHttpInfo(pageNo, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsGetWithHttpInfo: " + e.Message);
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

[**PaginatedListOfDataProcessingAgreements**](PaginatedListOfDataProcessingAgreements.md)

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

<a name="v1dataagreementsiddelete"></a>
# **V1DataAgreementsIdDelete**
> bool V1DataAgreementsIdDelete (string id)

Delete a data processing agreement this will not delete a published or a agreement in use with consents.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Delete a data processing agreement this will not delete a published or a agreement in use with consents.
                bool result = apiInstance.V1DataAgreementsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a data processing agreement this will not delete a published or a agreement in use with consents.
    ApiResponse<bool> response = apiInstance.V1DataAgreementsIdDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a name="v1dataagreementsidget"></a>
# **V1DataAgreementsIdGet**
> DataProcessingAgreement V1DataAgreementsIdGet (string id)

Get data processing agreement by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Get data processing agreement by id.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get data processing agreement by id.
    ApiResponse<DataProcessingAgreement> response = apiInstance.V1DataAgreementsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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

<a name="v1dataagreementsidput"></a>
# **V1DataAgreementsIdPut**
> DataProcessingAgreement V1DataAgreementsIdPut (string id, UpdateDataProcessingAgreement updateDataProcessingAgreement)

Update data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // string | 
            var updateDataProcessingAgreement = new UpdateDataProcessingAgreement(); // UpdateDataProcessingAgreement | 

            try
            {
                // Update data processing agreement.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsIdPut(id, updateDataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update data processing agreement.
    ApiResponse<DataProcessingAgreement> response = apiInstance.V1DataAgreementsIdPutWithHttpInfo(id, updateDataProcessingAgreement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **updateDataProcessingAgreement** | [**UpdateDataProcessingAgreement**](UpdateDataProcessingAgreement.md) |  |  |

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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

<a name="v1dataagreementsidterminateput"></a>
# **V1DataAgreementsIdTerminatePut**
> bool V1DataAgreementsIdTerminatePut (string id)

Terminate a data processing agreement by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsIdTerminatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var id = "id_example";  // string | 

            try
            {
                // Terminate a data processing agreement by id.
                bool result = apiInstance.V1DataAgreementsIdTerminatePut(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdTerminatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsIdTerminatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Terminate a data processing agreement by id.
    ApiResponse<bool> response = apiInstance.V1DataAgreementsIdTerminatePutWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsIdTerminatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

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

<a name="v1dataagreementspost"></a>
# **V1DataAgreementsPost**
> DataProcessingAgreement V1DataAgreementsPost (CreateDataProcessingAgreement createDataProcessingAgreement)

Create a data processing agreement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class V1DataAgreementsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mydatamyconsent.com";
            // Configure OAuth2 access token for authorization: OAuth2ClientCredentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataProcessingAgreementsApi(config);
            var createDataProcessingAgreement = new CreateDataProcessingAgreement(); // CreateDataProcessingAgreement | 

            try
            {
                // Create a data processing agreement.
                DataProcessingAgreement result = apiInstance.V1DataAgreementsPost(createDataProcessingAgreement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DataAgreementsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a data processing agreement.
    ApiResponse<DataProcessingAgreement> response = apiInstance.V1DataAgreementsPostWithHttpInfo(createDataProcessingAgreement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDataProcessingAgreement** | [**CreateDataProcessingAgreement**](CreateDataProcessingAgreement.md) |  |  |

### Return type

[**DataProcessingAgreement**](DataProcessingAgreement.md)

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

