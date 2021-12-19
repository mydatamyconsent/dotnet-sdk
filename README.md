# com.mydatamyconsent - the C# library for the My Data My Consent - Developer API

Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://mydatamyconsent.com/en-us/developers](https://mydatamyconsent.com/en-us/developers)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Client;
using com.mydatamyconsent.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataConsentRequestsApi(config);
            var requestId = new Guid(); // Guid | consent request id.

            try
            {
                // Cancel a Consent Request by ID.
                apiInstance.CancelConsentRequest(requestId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataConsentRequestsApi.CancelConsentRequest: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataConsentRequestsApi* | [**CancelConsentRequest**](docs/DataConsentRequestsApi.md#cancelconsentrequest) | **DELETE** /v1/consent-requests/{requestId}/cancel | Cancel a Consent Request by ID.
*DataConsentRequestsApi* | [**CreateRequest**](docs/DataConsentRequestsApi.md#createrequest) | **POST** /v1/consent-requests | Create a consent request.
*DataConsentRequestsApi* | [**GetAllConsentRequests**](docs/DataConsentRequestsApi.md#getallconsentrequests) | **GET** /v1/consent-requests | Get all Consent Requests.
*DataConsentRequestsApi* | [**GetConsentRequestById**](docs/DataConsentRequestsApi.md#getconsentrequestbyid) | **GET** /v1/consent-requests/{requestId} | Get a Consent Request by ID.
*DataConsentsApi* | [**V1ConsentsConsentIdAccountsAccountIdGet**](docs/DataConsentsApi.md#v1consentsconsentidaccountsaccountidget) | **GET** /v1/consents/{consentId}/accounts/{accountId} | Get consented financial account details.
*DataConsentsApi* | [**V1ConsentsConsentIdAccountsAccountIdInsightsGet**](docs/DataConsentsApi.md#v1consentsconsentidaccountsaccountidinsightsget) | **GET** /v1/consents/{consentId}/accounts/{accountId}/insights | Get consented financial account insights.
*DataConsentsApi* | [**V1ConsentsConsentIdAccountsAccountIdTransactionsGet**](docs/DataConsentsApi.md#v1consentsconsentidaccountsaccountidtransactionsget) | **GET** /v1/consents/{consentId}/accounts/{accountId}/transactions | Get consented financial account transactions.
*DataConsentsApi* | [**V1ConsentsConsentIdAccountsGet**](docs/DataConsentsApi.md#v1consentsconsentidaccountsget) | **GET** /v1/consents/{consentId}/accounts | Get all accounts in a consent.
*DataConsentsApi* | [**V1ConsentsConsentIdDocumentsDocumentIdAnalysisGet**](docs/DataConsentsApi.md#v1consentsconsentiddocumentsdocumentidanalysisget) | **GET** /v1/consents/{consentId}/documents/{documentId}/analysis | Get analysis of a consented document.
*DataConsentsApi* | [**V1ConsentsConsentIdDocumentsDocumentIdDownloadGet**](docs/DataConsentsApi.md#v1consentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/consents/{consentId}/documents/{documentId}/download | Download a consented document.
*DataConsentsApi* | [**V1ConsentsConsentIdDocumentsDocumentIdGet**](docs/DataConsentsApi.md#v1consentsconsentiddocumentsdocumentidget) | **GET** /v1/consents/{consentId}/documents/{documentId} | Get consented document details.
*DataConsentsApi* | [**V1ConsentsConsentIdDocumentsGet**](docs/DataConsentsApi.md#v1consentsconsentiddocumentsget) | **GET** /v1/consents/{consentId}/documents | Get all documents in a consent.
*DataConsentsApi* | [**V1ConsentsConsentIdGet**](docs/DataConsentsApi.md#v1consentsconsentidget) | **GET** /v1/consents/{consentId} | Get consent details by consent id.
*DataConsentsApi* | [**V1ConsentsGet**](docs/DataConsentsApi.md#v1consentsget) | **GET** /v1/consents | Get all consents filtered by status and time.
*DataProcessingAgreementsApi* | [**V1DataAgreementsGet**](docs/DataProcessingAgreementsApi.md#v1dataagreementsget) | **GET** /v1/data-agreements | Get all data processing agreements.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdDelete**](docs/DataProcessingAgreementsApi.md#v1dataagreementsiddelete) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement. This will not delete a published or a agreement in use with consents.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdGet**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidget) | **GET** /v1/data-agreements/{id} | Get data processing agreement by Id.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdPut**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidput) | **PUT** /v1/data-agreements/{id} | Update a data processing agreement.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdTerminatePut**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidterminateput) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement.
*DataProcessingAgreementsApi* | [**V1DataAgreementsPost**](docs/DataProcessingAgreementsApi.md#v1dataagreementspost) | **POST** /v1/data-agreements | Create a data processing agreement.
*DataProviderDiscoveryApi* | [**V1DataProvidersGet**](docs/DataProviderDiscoveryApi.md#v1dataprovidersget) | **GET** /v1/data-providers | Discover all data providers in My Data My Consent by country and filters.
*DataProviderDiscoveryApi* | [**V1DataProvidersProviderIdGet**](docs/DataProviderDiscoveryApi.md#v1dataprovidersprovideridget) | **GET** /v1/data-providers/{providerId} | Get a Data Provider details.
*DigiLockerCompatIssuerApi* | [**IssuerIssuedoc1XmlPost**](docs/DigiLockerCompatIssuerApi.md#issuerissuedoc1xmlpost) | **POST** /issuer/issuedoc/1/xml | Digilocker Compatible endpoint to Issue Documents.
*DocumentsApi* | [**IssueDocument**](docs/DocumentsApi.md#issuedocument) | **POST** /v1/documents/issue | Issue a new document.
*DocumentsApi* | [**V1DocumentsIssuedDocumentIdGet**](docs/DocumentsApi.md#v1documentsissueddocumentidget) | **GET** /v1/documents/issued/{documentId} | Get issued document.
*DocumentsApi* | [**V1DocumentsIssuedGet**](docs/DocumentsApi.md#v1documentsissuedget) | **GET** /v1/documents/issued | Get issued documents.
*DocumentsApi* | [**V1DocumentsTypesGet**](docs/DocumentsApi.md#v1documentstypesget) | **GET** /v1/documents/types | Get registered document types.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApplicationUser](docs/ApplicationUser.md)
 - [Model.BankAccountType](docs/BankAccountType.md)
 - [Model.CategoryIconFontFamily](docs/CategoryIconFontFamily.md)
 - [Model.Country](docs/Country.md)
 - [Model.CountryState](docs/CountryState.md)
 - [Model.DataConsent](docs/DataConsent.md)
 - [Model.DataConsentDetailsDto](docs/DataConsentDetailsDto.md)
 - [Model.DataConsentIdentifier](docs/DataConsentIdentifier.md)
 - [Model.DataConsentRequestModel](docs/DataConsentRequestModel.md)
 - [Model.DataConsentRequestedAccountDto](docs/DataConsentRequestedAccountDto.md)
 - [Model.DataConsentRequestedDocument](docs/DataConsentRequestedDocument.md)
 - [Model.DataConsentRequestedDocumentDto](docs/DataConsentRequestedDocumentDto.md)
 - [Model.DataConsentRequestedFaDto](docs/DataConsentRequestedFaDto.md)
 - [Model.DataConsentRequestedFinancialAccount](docs/DataConsentRequestedFinancialAccount.md)
 - [Model.DataConsentRequesterDto](docs/DataConsentRequesterDto.md)
 - [Model.DataConsentRfaFilter](docs/DataConsentRfaFilter.md)
 - [Model.DataConsentRfaFilterDto](docs/DataConsentRfaFilterDto.md)
 - [Model.DataConsentStatus](docs/DataConsentStatus.md)
 - [Model.DataFetchFrequencyUnit](docs/DataFetchFrequencyUnit.md)
 - [Model.DataFetchType](docs/DataFetchType.md)
 - [Model.DataLifeUnit](docs/DataLifeUnit.md)
 - [Model.DataProcessingAgreement](docs/DataProcessingAgreement.md)
 - [Model.DataProcessingAgreementPaginatedList](docs/DataProcessingAgreementPaginatedList.md)
 - [Model.DataProtectionOfficer](docs/DataProtectionOfficer.md)
 - [Model.DataProvider](docs/DataProvider.md)
 - [Model.DataProviderPaginatedList](docs/DataProviderPaginatedList.md)
 - [Model.DocumentIssueRequest](docs/DocumentIssueRequest.md)
 - [Model.DocumentProviderCategory](docs/DocumentProviderCategory.md)
 - [Model.FileType](docs/FileType.md)
 - [Model.FilterType](docs/FilterType.md)
 - [Model.FinancialAccountTypes](docs/FinancialAccountTypes.md)
 - [Model.Gender](docs/Gender.md)
 - [Model.IdentificationStrategy](docs/IdentificationStrategy.md)
 - [Model.Identifier](docs/Identifier.md)
 - [Model.IdentifierStringKeyValuePair](docs/IdentifierStringKeyValuePair.md)
 - [Model.IdentityClaim](docs/IdentityClaim.md)
 - [Model.JsonSchema](docs/JsonSchema.md)
 - [Model.Operator](docs/Operator.md)
 - [Model.Organization](docs/Organization.md)
 - [Model.OrganizationAddress](docs/OrganizationAddress.md)
 - [Model.OrganizationAddressType](docs/OrganizationAddressType.md)
 - [Model.OrganizationCategory](docs/OrganizationCategory.md)
 - [Model.OrganizationFinancialAccount](docs/OrganizationFinancialAccount.md)
 - [Model.OrganizationKyoDocument](docs/OrganizationKyoDocument.md)
 - [Model.OrganizationMetaData](docs/OrganizationMetaData.md)
 - [Model.OrganizationStatus](docs/OrganizationStatus.md)
 - [Model.OrganizationType](docs/OrganizationType.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.ProofDocumentType](docs/ProofDocumentType.md)
 - [Model.PushUriRequest](docs/PushUriRequest.md)
 - [Model.PushUriResponse](docs/PushUriResponse.md)
 - [Model.Receiver](docs/Receiver.md)
 - [Model.ReceiverType](docs/ReceiverType.md)
 - [Model.RefreshToken](docs/RefreshToken.md)
 - [Model.Rejection](docs/Rejection.md)
 - [Model.SuggestedAccountDto](docs/SuggestedAccountDto.md)
 - [Model.Theme](docs/Theme.md)
 - [Model.UriDetails](docs/UriDetails.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
