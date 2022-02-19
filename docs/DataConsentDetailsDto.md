# MyDataMyConsent.Sdk.Models.DataConsentDetailsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Status** | **DataConsentStatus** |  | [optional] 
**ApprovedAtUtc** | **DateTime?** |  | [optional] 
**RejectedAtUtc** | **DateTime?** |  | [optional] 
**ExpiresAtUtc** | **DateTime** |  | [optional] 
**RequestedAtUtc** | **DateTime** |  | [optional] 
**Requester** | [**DataConsentRequesterDto**](DataConsentRequesterDto.md) |  | [optional] 
**ConsentDetails** | [**GetConsentTemplateDetailsDto**](GetConsentTemplateDetailsDto.md) |  | [optional] 
**Identifiers** | [**List&lt;DataConsentIdentifier&gt;**](DataConsentIdentifier.md) |  | [optional] 
**ApprovedDocuments** | [**List&lt;DataConsentRequestedDocument&gt;**](DataConsentRequestedDocument.md) |  | [optional] 
**ApprovedFinancials** | [**List&lt;DataConsentRequestedFinancialAccount&gt;**](DataConsentRequestedFinancialAccount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

