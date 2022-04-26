# MyDataMyConsent.Sdk.Models.IssuedDocumentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Document Id. | 
**Identifier** | **string** | Document Identifier. | 
**DocumentType** | **string** | Document type name. | 
**IssuedTo** | **string** | User name. | 
**IssuedAtUtc** | **DateTime** | Issued datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime?** | Expires datetime in UTC timezone. | [optional] 
**AcceptedAtUtc** | **DateTime?** | Accepted datetime in UTC timezone. | [optional] 
**Receiver** | [**DocumentReceiver**](DocumentReceiver.md) |  | 
**Metadata** | **Dictionary&lt;string, string&gt;** | Metadata. | [optional] 
**DigitalSignatures** | [**List&lt;DocumentDigitalSignature&gt;**](DocumentDigitalSignature.md) | Digital signatures. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

