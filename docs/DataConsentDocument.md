# MyDataMyConsent.Models.DataConsentDocument
Data Consent document details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Document id. | 
**Name** | **string** | Document name. | 
**Category** | **string** | Document category. | 
**Identifier** | **string** | Document identifier. | 
**FieldTitle** | **string** | Document field title. | 
**FieldSlug** | **string** | Document field slug. | 
**IssuedAtUtc** | **DateTime** | Document issued at datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime?** | Document expires at datetime in UTC timezone. | [optional] 
**Issuer** | [**DataConsentDocumentIssuer**](DataConsentDocumentIssuer.md) |  | 
**DigitalSignatures** | [**List&lt;DocumentDigitalSignature&gt;**](DocumentDigitalSignature.md) | Digital signatures. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

