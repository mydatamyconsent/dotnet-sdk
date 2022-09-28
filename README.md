# MyDataMyConsent - the C# library for the My Data My Consent - Developer API

Unleashing the power of consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://mydatamyconsent.com/en-us/contact-us](https://mydatamyconsent.com/en-us/contact-us)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;
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
using MyDataMyConsent.Api;
using MyDataMyConsent.Client;
using MyDataMyConsent.Models;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataProcessingAgreementsApi.V1DataAgreementsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.mydatamyconsent.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataProcessingAgreementsApi* | [**V1DataAgreementsGet**](docs/DataProcessingAgreementsApi.md#v1dataagreementsget) | **GET** /v1/data-agreements | Get paginated data processing agreements.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdDelete**](docs/DataProcessingAgreementsApi.md#v1dataagreementsiddelete) | **DELETE** /v1/data-agreements/{id} | Delete a data processing agreement this will not delete a published or a agreement in use with consents.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdGet**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidget) | **GET** /v1/data-agreements/{id} | Get data processing agreement by id.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdPut**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidput) | **PUT** /v1/data-agreements/{id} | Update data processing agreement.
*DataProcessingAgreementsApi* | [**V1DataAgreementsIdTerminatePut**](docs/DataProcessingAgreementsApi.md#v1dataagreementsidterminateput) | **PUT** /v1/data-agreements/{id}/terminate | Terminate a data processing agreement by id.
*DataProcessingAgreementsApi* | [**V1DataAgreementsPost**](docs/DataProcessingAgreementsApi.md#v1dataagreementspost) | **POST** /v1/data-agreements | Create a data processing agreement.
*DataProvidersDiscoveryApi* | [**V1DataProvidersGet**](docs/DataProvidersDiscoveryApi.md#v1dataprovidersget) | **GET** /v1/data-providers | Discover all data providers in my data my consent by country and filters.
*DataProvidersDiscoveryApi* | [**V1DataProvidersIdGet**](docs/DataProvidersDiscoveryApi.md#v1dataprovidersidget) | **GET** /v1/data-providers/{id} | Get a data provider details by provider id.
*IndividualsApi* | [**IssuerIssuedoc1XmlPost**](docs/IndividualsApi.md#issuerissuedoc1xmlpost) | **POST** /issuer/issuedoc/1/xml | Digilocker compatible endpoint to issue document.
*IndividualsApi* | [**V1IndividualsConsentRequestsGet**](docs/IndividualsApi.md#v1individualsconsentrequestsget) | **GET** /v1/individuals/consent-requests | Get all consent requests sent to Individuals.
*IndividualsApi* | [**V1IndividualsConsentRequestsPost**](docs/IndividualsApi.md#v1individualsconsentrequestspost) | **POST** /v1/individuals/consent-requests | Create individual consent request.
*IndividualsApi* | [**V1IndividualsConsentRequestsRequestIdCancelPut**](docs/IndividualsApi.md#v1individualsconsentrequestsrequestidcancelput) | **PUT** /v1/individuals/consent-requests/{request_id}/cancel | Cancel the Individual data request by id.
*IndividualsApi* | [**V1IndividualsConsentRequestsRequestIdGet**](docs/IndividualsApi.md#v1individualsconsentrequestsrequestidget) | **GET** /v1/individuals/consent-requests/{request_id} | Get Individual data request by id.
*IndividualsApi* | [**V1IndividualsConsentTemplatesGet**](docs/IndividualsApi.md#v1individualsconsenttemplatesget) | **GET** /v1/individuals/consent-templates | Get the paginated list of individual consent templates.
*IndividualsApi* | [**V1IndividualsConsentTemplatesTemplateIdGet**](docs/IndividualsApi.md#v1individualsconsenttemplatestemplateidget) | **GET** /v1/individuals/consent-templates/{template_id} | Get Individual consent template details by consent id.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdDocumentsDocumentIdDownloadGet**](docs/IndividualsApi.md#v1individualsconsentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/individuals/consents/{consent_id}/documents/{document_id}/download | Download Individual consented document by document id.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdDocumentsDocumentIdGet**](docs/IndividualsApi.md#v1individualsconsentsconsentiddocumentsdocumentidget) | **GET** /v1/individuals/consents/{consent_id}/documents/{document_id} | Get Individual consented document by document id.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdDocumentsGet**](docs/IndividualsApi.md#v1individualsconsentsconsentiddocumentsget) | **GET** /v1/individuals/consents/{consent_id}/documents | Get Individual consented document by consent id.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdFinancialAccountsAccountIdGet**](docs/IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsaccountidget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts/{account_id} | Get individual consented financial account details.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**](docs/IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsaccountidtransactionsget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts/{account_id}/transactions | Get individual consented financial account transactions.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdFinancialAccountsGet**](docs/IndividualsApi.md#v1individualsconsentsconsentidfinancialaccountsget) | **GET** /v1/individuals/consents/{consent_id}/financial-accounts | Get all individual consented financial accounts.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdGet**](docs/IndividualsApi.md#v1individualsconsentsconsentidget) | **GET** /v1/individuals/consents/{consent_id} | Get Individuals consent details by consent id.
*IndividualsApi* | [**V1IndividualsConsentsConsentIdHealthFhirBundleGet**](docs/IndividualsApi.md#v1individualsconsentsconsentidhealthfhirbundleget) | **GET** /v1/individuals/consents/{consent_id}/health/fhir/bundle | Get Individual consented document by consent id.
*IndividualsApi* | [**V1IndividualsConsentsGet**](docs/IndividualsApi.md#v1individualsconsentsget) | **GET** /v1/individuals/consents | Get the paginated list of Individual consents.
*IndividualsApi* | [**V1IndividualsDocumentsIssueIssueRequestIdUploadPost**](docs/IndividualsApi.md#v1individualsdocumentsissueissuerequestiduploadpost) | **POST** /v1/individuals/documents/issue/{issue_request_id}/upload | Upload a document for issuance request of individual.
*IndividualsApi* | [**V1IndividualsDocumentsIssuePost**](docs/IndividualsApi.md#v1individualsdocumentsissuepost) | **POST** /v1/individuals/documents/issue | Issue a new document to an individual user.
*IndividualsApi* | [**V1IndividualsDocumentsIssuedDocumentIdGet**](docs/IndividualsApi.md#v1individualsdocumentsissueddocumentidget) | **GET** /v1/individuals/documents/issued/{document_id} | Get issued document.
*IndividualsApi* | [**V1IndividualsDocumentsIssuedGet**](docs/IndividualsApi.md#v1individualsdocumentsissuedget) | **GET** /v1/individuals/documents/issued | Get paginated list of issued documents of given document type.
*IndividualsApi* | [**V1IndividualsDocumentsTypesGet**](docs/IndividualsApi.md#v1individualsdocumentstypesget) | **GET** /v1/individuals/documents/types | Get paginated list of registered document types.
*OrganizationsApi* | [**V1OrganizationsConsentRequestsGet**](docs/OrganizationsApi.md#v1organizationsconsentrequestsget) | **GET** /v1/organizations/consent-requests | Get all consent requests sent to Organizations.
*OrganizationsApi* | [**V1OrganizationsConsentRequestsPost**](docs/OrganizationsApi.md#v1organizationsconsentrequestspost) | **POST** /v1/organizations/consent-requests | Create consent request for an Organization.
*OrganizationsApi* | [**V1OrganizationsConsentRequestsRequestIdCancelPut**](docs/OrganizationsApi.md#v1organizationsconsentrequestsrequestidcancelput) | **PUT** /v1/organizations/consent-requests/{request_id}/cancel | Cancel the  Organization data request by id.
*OrganizationsApi* | [**V1OrganizationsConsentRequestsRequestIdGet**](docs/OrganizationsApi.md#v1organizationsconsentrequestsrequestidget) | **GET** /v1/organizations/consent-requests/{request_id} | Get Organization data request by id.
*OrganizationsApi* | [**V1OrganizationsConsentTemplatesGet**](docs/OrganizationsApi.md#v1organizationsconsenttemplatesget) | **GET** /v1/organizations/consent-templates | Get the paginated list of organization consent templates.
*OrganizationsApi* | [**V1OrganizationsConsentTemplatesTemplateIdGet**](docs/OrganizationsApi.md#v1organizationsconsenttemplatestemplateidget) | **GET** /v1/organizations/consent-templates/{template_id} | Get Organization consent template details by consent id.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsdocumentiddownloadget) | **GET** /v1/organizations/consents/{consent_id}/documents/{document_id}/download | Download Organization consent document by document id.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsdocumentidget) | **GET** /v1/organizations/consents/{consent_id}/documents/{document_id} | Get Organization consent document based on document id and consent id.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdDocumentsGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentiddocumentsget) | **GET** /v1/organizations/consents/{consent_id}/documents | Get Organization consent document by consent id.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsaccountidget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts/{account_id} | Get organization consented financial account details.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsaccountidtransactionsget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts/{account_id}/transactions | Get organization consented financial account transactions.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdFinancialAccountsGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentidfinancialaccountsget) | **GET** /v1/organizations/consents/{consent_id}/financial-accounts | Get all organization consented financial accounts.
*OrganizationsApi* | [**V1OrganizationsConsentsConsentIdGet**](docs/OrganizationsApi.md#v1organizationsconsentsconsentidget) | **GET** /v1/organizations/consents/{consent_id} | Get Organization consent request details by consent id.
*OrganizationsApi* | [**V1OrganizationsConsentsGet**](docs/OrganizationsApi.md#v1organizationsconsentsget) | **GET** /v1/organizations/consents | Get the paginated list of Organization consents.
*OrganizationsApi* | [**V1OrganizationsDocumentsIssuePost**](docs/OrganizationsApi.md#v1organizationsdocumentsissuepost) | **POST** /v1/organizations/documents/issue | Issue a new document to an organization.
*OrganizationsApi* | [**V1OrganizationsDocumentsIssueUploadIssueRequestIdPost**](docs/OrganizationsApi.md#v1organizationsdocumentsissueuploadissuerequestidpost) | **POST** /v1/organizations/documents/issue/upload/{issue_request_id} | Upload a document for issuance request of Organization.
*OrganizationsApi* | [**V1OrganizationsDocumentsIssuedDocumentIdGet**](docs/OrganizationsApi.md#v1organizationsdocumentsissueddocumentidget) | **GET** /v1/organizations/documents/issued/{document_id} | Get issued document.
*OrganizationsApi* | [**V1OrganizationsDocumentsIssuedGet**](docs/OrganizationsApi.md#v1organizationsdocumentsissuedget) | **GET** /v1/organizations/documents/issued | Get paginated list of issued documents of given document type.
*OrganizationsApi* | [**V1OrganizationsDocumentsTypesGet**](docs/OrganizationsApi.md#v1organizationsdocumentstypesget) | **GET** /v1/organizations/documents/types | Get paginated list of registered document types.
*SupportedIdentifiersApi* | [**V1SupportedIdentifiersCountryIso2CodeGet**](docs/SupportedIdentifiersApi.md#v1supportedidentifierscountryiso2codeget) | **GET** /v1/supported-identifiers/{country_iso2_code} | Get all supported identifiers by country.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Models.Aif](docs/Aif.md)
 - [Models.AifTransaction](docs/AifTransaction.md)
 - [Models.ApiErrorType](docs/ApiErrorType.md)
 - [Models.BillPayment](docs/BillPayment.md)
 - [Models.BillPaymentTransaction](docs/BillPaymentTransaction.md)
 - [Models.Bond](docs/Bond.md)
 - [Models.BondTransaction](docs/BondTransaction.md)
 - [Models.CIS](docs/CIS.md)
 - [Models.CISTransaction](docs/CISTransaction.md)
 - [Models.CertificateOfDeposit](docs/CertificateOfDeposit.md)
 - [Models.CertificateOfDepositTransaction](docs/CertificateOfDepositTransaction.md)
 - [Models.CollectibleTypes](docs/CollectibleTypes.md)
 - [Models.CommercialPaper](docs/CommercialPaper.md)
 - [Models.CommercialPaperTransaction](docs/CommercialPaperTransaction.md)
 - [Models.Consent](docs/Consent.md)
 - [Models.ConsentDetails](docs/ConsentDetails.md)
 - [Models.ConsentDocumentIssuer](docs/ConsentDocumentIssuer.md)
 - [Models.ConsentRequest](docs/ConsentRequest.md)
 - [Models.ConsentRequestReceiver](docs/ConsentRequestReceiver.md)
 - [Models.ConsentRequestTemplate](docs/ConsentRequestTemplate.md)
 - [Models.ConsentRequestTemplateStatus](docs/ConsentRequestTemplateStatus.md)
 - [Models.ConsentedDocument](docs/ConsentedDocument.md)
 - [Models.ConsentedFinancialAccount](docs/ConsentedFinancialAccount.md)
 - [Models.ConsentedFinancialAccountTransactionPeriod](docs/ConsentedFinancialAccountTransactionPeriod.md)
 - [Models.ConsentedIdentifier](docs/ConsentedIdentifier.md)
 - [Models.ConsentedMedicalRecord](docs/ConsentedMedicalRecord.md)
 - [Models.CreateConsentRequest](docs/CreateConsentRequest.md)
 - [Models.CreateDataProcessingAgreement](docs/CreateDataProcessingAgreement.md)
 - [Models.CreditCard](docs/CreditCard.md)
 - [Models.CreditCardHolder](docs/CreditCardHolder.md)
 - [Models.CreditCardHolders](docs/CreditCardHolders.md)
 - [Models.CreditCardProfile](docs/CreditCardProfile.md)
 - [Models.CreditCardSummary](docs/CreditCardSummary.md)
 - [Models.CreditCardTransaction](docs/CreditCardTransaction.md)
 - [Models.CreditCardTransactionType](docs/CreditCardTransactionType.md)
 - [Models.DataConsentStatus](docs/DataConsentStatus.md)
 - [Models.DataProcessingAgreement](docs/DataProcessingAgreement.md)
 - [Models.DataProtectionOfficer](docs/DataProtectionOfficer.md)
 - [Models.DataProvider](docs/DataProvider.md)
 - [Models.DataProviderDetails](docs/DataProviderDetails.md)
 - [Models.Debenture](docs/Debenture.md)
 - [Models.DebentureTransaction](docs/DebentureTransaction.md)
 - [Models.Deposit](docs/Deposit.md)
 - [Models.DepositTransaction](docs/DepositTransaction.md)
 - [Models.DocumentCategoryType](docs/DocumentCategoryType.md)
 - [Models.DocumentDigitalSignature](docs/DocumentDigitalSignature.md)
 - [Models.DocumentField](docs/DocumentField.md)
 - [Models.DocumentIssueRequest](docs/DocumentIssueRequest.md)
 - [Models.DocumentIssueRequestDetails](docs/DocumentIssueRequestDetails.md)
 - [Models.DocumentIssueRequestDetailsReceiver](docs/DocumentIssueRequestDetailsReceiver.md)
 - [Models.DocumentIssueRequestPaymentRequest](docs/DocumentIssueRequestPaymentRequest.md)
 - [Models.DocumentIssueRequestReceiver](docs/DocumentIssueRequestReceiver.md)
 - [Models.DocumentIssueRequestStatus](docs/DocumentIssueRequestStatus.md)
 - [Models.DocumentReceiver](docs/DocumentReceiver.md)
 - [Models.DocumentSubCategoryType](docs/DocumentSubCategoryType.md)
 - [Models.DocumentType](docs/DocumentType.md)
 - [Models.Epf](docs/Epf.md)
 - [Models.EpfTransaction](docs/EpfTransaction.md)
 - [Models.Equity](docs/Equity.md)
 - [Models.EquityHolding](docs/EquityHolding.md)
 - [Models.EquityHoldingMode](docs/EquityHoldingMode.md)
 - [Models.EquityHoldings](docs/EquityHoldings.md)
 - [Models.EquityInvestment](docs/EquityInvestment.md)
 - [Models.EquitySummary](docs/EquitySummary.md)
 - [Models.EquityTransaction](docs/EquityTransaction.md)
 - [Models.Error](docs/Error.md)
 - [Models.Etf](docs/Etf.md)
 - [Models.EtfTransaction](docs/EtfTransaction.md)
 - [Models.FinancialAccount](docs/FinancialAccount.md)
 - [Models.FinancialAccountAif](docs/FinancialAccountAif.md)
 - [Models.FinancialAccountAifAllOf](docs/FinancialAccountAifAllOf.md)
 - [Models.FinancialAccountAifTransaction](docs/FinancialAccountAifTransaction.md)
 - [Models.FinancialAccountAifTransactionAllOf](docs/FinancialAccountAifTransactionAllOf.md)
 - [Models.FinancialAccountBillPayment](docs/FinancialAccountBillPayment.md)
 - [Models.FinancialAccountBillPaymentAllOf](docs/FinancialAccountBillPaymentAllOf.md)
 - [Models.FinancialAccountBillPaymentTransaction](docs/FinancialAccountBillPaymentTransaction.md)
 - [Models.FinancialAccountBillPaymentTransactionAllOf](docs/FinancialAccountBillPaymentTransactionAllOf.md)
 - [Models.FinancialAccountBond](docs/FinancialAccountBond.md)
 - [Models.FinancialAccountBondAllOf](docs/FinancialAccountBondAllOf.md)
 - [Models.FinancialAccountBondTransaction](docs/FinancialAccountBondTransaction.md)
 - [Models.FinancialAccountBondTransactionAllOf](docs/FinancialAccountBondTransactionAllOf.md)
 - [Models.FinancialAccountCIS](docs/FinancialAccountCIS.md)
 - [Models.FinancialAccountCISAllOf](docs/FinancialAccountCISAllOf.md)
 - [Models.FinancialAccountCISTransaction](docs/FinancialAccountCISTransaction.md)
 - [Models.FinancialAccountCISTransactionAllOf](docs/FinancialAccountCISTransactionAllOf.md)
 - [Models.FinancialAccountCategoryType](docs/FinancialAccountCategoryType.md)
 - [Models.FinancialAccountCertificateOfDeposit](docs/FinancialAccountCertificateOfDeposit.md)
 - [Models.FinancialAccountCertificateOfDepositAllOf](docs/FinancialAccountCertificateOfDepositAllOf.md)
 - [Models.FinancialAccountCertificateOfDepositTransaction](docs/FinancialAccountCertificateOfDepositTransaction.md)
 - [Models.FinancialAccountCertificateOfDepositTransactionAllOf](docs/FinancialAccountCertificateOfDepositTransactionAllOf.md)
 - [Models.FinancialAccountCommercialPaper](docs/FinancialAccountCommercialPaper.md)
 - [Models.FinancialAccountCommercialPaperAllOf](docs/FinancialAccountCommercialPaperAllOf.md)
 - [Models.FinancialAccountCommercialPaperTransaction](docs/FinancialAccountCommercialPaperTransaction.md)
 - [Models.FinancialAccountCommercialPaperTransactionAllOf](docs/FinancialAccountCommercialPaperTransactionAllOf.md)
 - [Models.FinancialAccountCreditCard](docs/FinancialAccountCreditCard.md)
 - [Models.FinancialAccountCreditCardAllOf](docs/FinancialAccountCreditCardAllOf.md)
 - [Models.FinancialAccountCreditCardTransaction](docs/FinancialAccountCreditCardTransaction.md)
 - [Models.FinancialAccountCreditCardTransactionAllOf](docs/FinancialAccountCreditCardTransactionAllOf.md)
 - [Models.FinancialAccountDebenture](docs/FinancialAccountDebenture.md)
 - [Models.FinancialAccountDebentureAllOf](docs/FinancialAccountDebentureAllOf.md)
 - [Models.FinancialAccountDebentureTransaction](docs/FinancialAccountDebentureTransaction.md)
 - [Models.FinancialAccountDebentureTransactionAllOf](docs/FinancialAccountDebentureTransactionAllOf.md)
 - [Models.FinancialAccountDeposit](docs/FinancialAccountDeposit.md)
 - [Models.FinancialAccountDepositAllOf](docs/FinancialAccountDepositAllOf.md)
 - [Models.FinancialAccountDepositTransaction](docs/FinancialAccountDepositTransaction.md)
 - [Models.FinancialAccountDepositTransactionAllOf](docs/FinancialAccountDepositTransactionAllOf.md)
 - [Models.FinancialAccountDetailsRequired](docs/FinancialAccountDetailsRequired.md)
 - [Models.FinancialAccountEpf](docs/FinancialAccountEpf.md)
 - [Models.FinancialAccountEpfAllOf](docs/FinancialAccountEpfAllOf.md)
 - [Models.FinancialAccountEpfTransaction](docs/FinancialAccountEpfTransaction.md)
 - [Models.FinancialAccountEpfTransactionAllOf](docs/FinancialAccountEpfTransactionAllOf.md)
 - [Models.FinancialAccountEquity](docs/FinancialAccountEquity.md)
 - [Models.FinancialAccountEquityAllOf](docs/FinancialAccountEquityAllOf.md)
 - [Models.FinancialAccountEquityTransaction](docs/FinancialAccountEquityTransaction.md)
 - [Models.FinancialAccountEquityTransactionAllOf](docs/FinancialAccountEquityTransactionAllOf.md)
 - [Models.FinancialAccountEtf](docs/FinancialAccountEtf.md)
 - [Models.FinancialAccountEtfAllOf](docs/FinancialAccountEtfAllOf.md)
 - [Models.FinancialAccountEtfTransaction](docs/FinancialAccountEtfTransaction.md)
 - [Models.FinancialAccountEtfTransactionAllOf](docs/FinancialAccountEtfTransactionAllOf.md)
 - [Models.FinancialAccountField](docs/FinancialAccountField.md)
 - [Models.FinancialAccountGovtSecurity](docs/FinancialAccountGovtSecurity.md)
 - [Models.FinancialAccountGovtSecurityAllOf](docs/FinancialAccountGovtSecurityAllOf.md)
 - [Models.FinancialAccountGovtSecurityTransaction](docs/FinancialAccountGovtSecurityTransaction.md)
 - [Models.FinancialAccountGovtSecurityTransactionAllOf](docs/FinancialAccountGovtSecurityTransactionAllOf.md)
 - [Models.FinancialAccountIdr](docs/FinancialAccountIdr.md)
 - [Models.FinancialAccountIdrAllOf](docs/FinancialAccountIdrAllOf.md)
 - [Models.FinancialAccountIdrTransaction](docs/FinancialAccountIdrTransaction.md)
 - [Models.FinancialAccountIdrTransactionAllOf](docs/FinancialAccountIdrTransactionAllOf.md)
 - [Models.FinancialAccountInsurancePolicy](docs/FinancialAccountInsurancePolicy.md)
 - [Models.FinancialAccountInsurancePolicyAllOf](docs/FinancialAccountInsurancePolicyAllOf.md)
 - [Models.FinancialAccountInsurancePolicyTransaction](docs/FinancialAccountInsurancePolicyTransaction.md)
 - [Models.FinancialAccountInsurancePolicyTransactionAllOf](docs/FinancialAccountInsurancePolicyTransactionAllOf.md)
 - [Models.FinancialAccountInvit](docs/FinancialAccountInvit.md)
 - [Models.FinancialAccountInvitAllOf](docs/FinancialAccountInvitAllOf.md)
 - [Models.FinancialAccountInvitTransaction](docs/FinancialAccountInvitTransaction.md)
 - [Models.FinancialAccountInvitTransactionAllOf](docs/FinancialAccountInvitTransactionAllOf.md)
 - [Models.FinancialAccountLoan](docs/FinancialAccountLoan.md)
 - [Models.FinancialAccountLoanAllOf](docs/FinancialAccountLoanAllOf.md)
 - [Models.FinancialAccountLoanTransaction](docs/FinancialAccountLoanTransaction.md)
 - [Models.FinancialAccountLoanTransactionAllOf](docs/FinancialAccountLoanTransactionAllOf.md)
 - [Models.FinancialAccountMutualFund](docs/FinancialAccountMutualFund.md)
 - [Models.FinancialAccountMutualFundAllOf](docs/FinancialAccountMutualFundAllOf.md)
 - [Models.FinancialAccountMutualFundTransaction](docs/FinancialAccountMutualFundTransaction.md)
 - [Models.FinancialAccountMutualFundTransactionAllOf](docs/FinancialAccountMutualFundTransactionAllOf.md)
 - [Models.FinancialAccountNps](docs/FinancialAccountNps.md)
 - [Models.FinancialAccountNpsAllOf](docs/FinancialAccountNpsAllOf.md)
 - [Models.FinancialAccountNpsTransaction](docs/FinancialAccountNpsTransaction.md)
 - [Models.FinancialAccountNpsTransactionAllOf](docs/FinancialAccountNpsTransactionAllOf.md)
 - [Models.FinancialAccountPpf](docs/FinancialAccountPpf.md)
 - [Models.FinancialAccountPpfAllOf](docs/FinancialAccountPpfAllOf.md)
 - [Models.FinancialAccountPpfTransaction](docs/FinancialAccountPpfTransaction.md)
 - [Models.FinancialAccountPpfTransactionAllOf](docs/FinancialAccountPpfTransactionAllOf.md)
 - [Models.FinancialAccountRecurringDeposit](docs/FinancialAccountRecurringDeposit.md)
 - [Models.FinancialAccountRecurringDepositAllOf](docs/FinancialAccountRecurringDepositAllOf.md)
 - [Models.FinancialAccountRecurringDepositTransaction](docs/FinancialAccountRecurringDepositTransaction.md)
 - [Models.FinancialAccountRecurringDepositTransactionAllOf](docs/FinancialAccountRecurringDepositTransactionAllOf.md)
 - [Models.FinancialAccountReit](docs/FinancialAccountReit.md)
 - [Models.FinancialAccountReitAllOf](docs/FinancialAccountReitAllOf.md)
 - [Models.FinancialAccountReitTransaction](docs/FinancialAccountReitTransaction.md)
 - [Models.FinancialAccountReitTransactionAllOf](docs/FinancialAccountReitTransactionAllOf.md)
 - [Models.FinancialAccountSip](docs/FinancialAccountSip.md)
 - [Models.FinancialAccountSipAllOf](docs/FinancialAccountSipAllOf.md)
 - [Models.FinancialAccountSipTransaction](docs/FinancialAccountSipTransaction.md)
 - [Models.FinancialAccountSipTransactionAllOf](docs/FinancialAccountSipTransactionAllOf.md)
 - [Models.FinancialAccountSubCategoryType](docs/FinancialAccountSubCategoryType.md)
 - [Models.FinancialAccountTermDeposit](docs/FinancialAccountTermDeposit.md)
 - [Models.FinancialAccountTermDepositAllOf](docs/FinancialAccountTermDepositAllOf.md)
 - [Models.FinancialAccountTermDepositTransaction](docs/FinancialAccountTermDepositTransaction.md)
 - [Models.FinancialAccountTermDepositTransactionAllOf](docs/FinancialAccountTermDepositTransactionAllOf.md)
 - [Models.FinancialAccountTransaction](docs/FinancialAccountTransaction.md)
 - [Models.FinancialAccountTransactionPeriod](docs/FinancialAccountTransactionPeriod.md)
 - [Models.FinancialAccountUlip](docs/FinancialAccountUlip.md)
 - [Models.FinancialAccountUlipAllOf](docs/FinancialAccountUlipAllOf.md)
 - [Models.FinancialAccountUlipTransaction](docs/FinancialAccountUlipTransaction.md)
 - [Models.FinancialAccountUlipTransactionAllOf](docs/FinancialAccountUlipTransactionAllOf.md)
 - [Models.GovtSecurity](docs/GovtSecurity.md)
 - [Models.GovtSecurityTransaction](docs/GovtSecurityTransaction.md)
 - [Models.Holder](docs/Holder.md)
 - [Models.Holders](docs/Holders.md)
 - [Models.HoldersType](docs/HoldersType.md)
 - [Models.HoldingNominee](docs/HoldingNominee.md)
 - [Models.IdentificationStrategy](docs/IdentificationStrategy.md)
 - [Models.Identifier](docs/Identifier.md)
 - [Models.IdentityField](docs/IdentityField.md)
 - [Models.Idr](docs/Idr.md)
 - [Models.IdrTransaction](docs/IdrTransaction.md)
 - [Models.IndividualConsentRequestDetails](docs/IndividualConsentRequestDetails.md)
 - [Models.IndividualConsentRequestTemplateDetails](docs/IndividualConsentRequestTemplateDetails.md)
 - [Models.IndividualConsentRequestTemplateDetailsDataFrequency](docs/IndividualConsentRequestTemplateDetailsDataFrequency.md)
 - [Models.IndividualConsentRequestTemplateDetailsDataLife](docs/IndividualConsentRequestTemplateDetailsDataLife.md)
 - [Models.IndividualConsentRequestTemplateDetailsRequestLife](docs/IndividualConsentRequestTemplateDetailsRequestLife.md)
 - [Models.InsurancePolicy](docs/InsurancePolicy.md)
 - [Models.InsurancePolicyTransaction](docs/InsurancePolicyTransaction.md)
 - [Models.Invit](docs/Invit.md)
 - [Models.InvitTransaction](docs/InvitTransaction.md)
 - [Models.IssuedDocument](docs/IssuedDocument.md)
 - [Models.KeyValuePair](docs/KeyValuePair.md)
 - [Models.Life](docs/Life.md)
 - [Models.Loan](docs/Loan.md)
 - [Models.LoanTransaction](docs/LoanTransaction.md)
 - [Models.MedicalRecordField](docs/MedicalRecordField.md)
 - [Models.MutualFund](docs/MutualFund.md)
 - [Models.MutualFundFundType](docs/MutualFundFundType.md)
 - [Models.MutualFundHolding](docs/MutualFundHolding.md)
 - [Models.MutualFundHoldingMode](docs/MutualFundHoldingMode.md)
 - [Models.MutualFundHoldings](docs/MutualFundHoldings.md)
 - [Models.MutualFundInvestment](docs/MutualFundInvestment.md)
 - [Models.MutualFundSchemeCategory](docs/MutualFundSchemeCategory.md)
 - [Models.MutualFundSchemeOption](docs/MutualFundSchemeOption.md)
 - [Models.MutualFundSchemePlan](docs/MutualFundSchemePlan.md)
 - [Models.MutualFundSchemeType](docs/MutualFundSchemeType.md)
 - [Models.MutualFundSummary](docs/MutualFundSummary.md)
 - [Models.MutualFundTransaction](docs/MutualFundTransaction.md)
 - [Models.MutualFundTransactionType](docs/MutualFundTransactionType.md)
 - [Models.Nps](docs/Nps.md)
 - [Models.NpsTransaction](docs/NpsTransaction.md)
 - [Models.OrganizationConsentRequestDetails](docs/OrganizationConsentRequestDetails.md)
 - [Models.OrganizationConsentRequestTemplateDetails](docs/OrganizationConsentRequestTemplateDetails.md)
 - [Models.PaginatedListOfConsentRequestTemplates](docs/PaginatedListOfConsentRequestTemplates.md)
 - [Models.PaginatedListOfConsents](docs/PaginatedListOfConsents.md)
 - [Models.PaginatedListOfDataProcessingAgreements](docs/PaginatedListOfDataProcessingAgreements.md)
 - [Models.PaginatedListOfDataProviders](docs/PaginatedListOfDataProviders.md)
 - [Models.PaginatedListOfDocumentTypes](docs/PaginatedListOfDocumentTypes.md)
 - [Models.PaginatedListOfFinancialAccountTransactions](docs/PaginatedListOfFinancialAccountTransactions.md)
 - [Models.PaginatedListOfIndividualConsentRequestDetailss](docs/PaginatedListOfIndividualConsentRequestDetailss.md)
 - [Models.PaginatedListOfIssuedDocuments](docs/PaginatedListOfIssuedDocuments.md)
 - [Models.PaginatedListOfOrganizationConsentRequestDetailss](docs/PaginatedListOfOrganizationConsentRequestDetailss.md)
 - [Models.PaymentOrderItem](docs/PaymentOrderItem.md)
 - [Models.PaymentRequest](docs/PaymentRequest.md)
 - [Models.Ppf](docs/Ppf.md)
 - [Models.PpfTransaction](docs/PpfTransaction.md)
 - [Models.Profile](docs/Profile.md)
 - [Models.PushUriRequest](docs/PushUriRequest.md)
 - [Models.PushUriResponse](docs/PushUriResponse.md)
 - [Models.RecurringDeposit](docs/RecurringDeposit.md)
 - [Models.RecurringDepositTransaction](docs/RecurringDepositTransaction.md)
 - [Models.Reit](docs/Reit.md)
 - [Models.ReitTransaction](docs/ReitTransaction.md)
 - [Models.SelectedFinancialAccountType](docs/SelectedFinancialAccountType.md)
 - [Models.Sip](docs/Sip.md)
 - [Models.SipTransaction](docs/SipTransaction.md)
 - [Models.SupportedDocumentType](docs/SupportedDocumentType.md)
 - [Models.SupportedEntityType](docs/SupportedEntityType.md)
 - [Models.SupportedIdentifier](docs/SupportedIdentifier.md)
 - [Models.TermDeposit](docs/TermDeposit.md)
 - [Models.TermDepositTransaction](docs/TermDepositTransaction.md)
 - [Models.Ulip](docs/Ulip.md)
 - [Models.UlipTransaction](docs/UlipTransaction.md)
 - [Models.UpdateDataProcessingAgreement](docs/UpdateDataProcessingAgreement.md)
 - [Models.UploadDocumentResponse](docs/UploadDocumentResponse.md)
 - [Models.UriDetails](docs/UriDetails.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="OAuth2ClientCredentials"></a>
### OAuth2ClientCredentials

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - SupportedIdentifiers:Read: Read SupportedIdentifiers.
  - DataProviders:Read: Read DataProviders.
  - DataProcessingAgreements:Read: Read DataProcessingAgreements.
  - DataProcessingAgreements:Write: Read &amp; Write DataProcessingAgreements.
  - Individuals:DocumentTypes:Read: Read Individual DocumentTypes.
  - Individuals:Documents:Read: Read Individual Issued Documents.
  - Individuals:Documents:Issue: Issue Individual Documents.
  - Organizations:DocumentTypes:Read: Read Organization DocumentTypes.
  - Organizations:Documents:Read: Read Organization Issued Documents.
  - Organizations:Documents:Issue: Issue Organization Documents.
  - Individuals:ConsentRequests:Request: Request Individual Consent requests.
  - Individuals:ConsentRequests:Cancel: Cancel Individual Consent requests.
  - Individuals:ConsentRequests:Read: Read Individual Consent requests.
  - Organizations:ConsentRequests:Request: Request Organization Consent requests.
  - Organizations:ConsentRequests:Cancel: Cancel Organization Consent requests.
  - Organizations:ConsentRequests:Read: Read Organization Consent requests.
  - Individuals:Consents:Read: Read Individual Consents.
  - Organizations:Consents:Read: Read Organization Consents.
  - Individuals:ConsentRequestTemplates:Read: Read Individual Consent Request templates.
  - Organizations:ConsentRequestTemplates:Read: Read Organization Consent Request templates.

