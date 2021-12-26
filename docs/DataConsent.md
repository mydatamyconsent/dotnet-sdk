# MyDataMyConsent.Models.DataConsent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**UserId** | **Guid?** |  | [optional] 
**OrganizationId** | **Guid?** |  | [optional] 
**RequestedByOrgId** | **Guid** |  | [optional] 
**TransactionId** | **string** |  | [optional] 
**StartDateTime** | **DateTime?** |  | [optional] 
**ExpiryDateTime** | **DateTime** |  | [optional] 
**Description** | **string** |  | [optional] 
**PurposeCode** | **string** |  | [optional] 
**PurposeLink** | **string** |  | [optional] 
**Location** | **string** |  | [optional] 
**AgreementId** | **Guid** |  | [optional] 
**DataLifeUnit** | **DataLifeUnit** |  | [optional] 
**DataLifeValue** | **int** |  | [optional] 
**DataFetchFrequencyUnit** | **DataFetchFrequencyUnit** |  | [optional] 
**DataFetchFrequencyUnitValue** | **int** |  | [optional] 
**DataFetchType** | **DataFetchType** |  | [optional] 
**Status** | **DataConsentStatus** |  | [optional] 
**CreatedAtUtc** | **DateTime** |  | [optional] 
**ApprovedAtUtc** | **DateTime?** |  | [optional] 
**RejectedAtUtc** | **DateTime?** |  | [optional] 
**User** | [**ApplicationUser**](ApplicationUser.md) |  | [optional] 
**Organization** | [**Organization**](Organization.md) |  | [optional] 
**RequestedByOrg** | [**Organization**](Organization.md) |  | [optional] 
**Agreement** | [**DataProcessingAgreement**](DataProcessingAgreement.md) |  | [optional] 
**IdentityClaims** | [**List&lt;IdentityClaim&gt;**](IdentityClaim.md) |  | [optional] 
**Identifiers** | [**List&lt;DataConsentIdentifier&gt;**](DataConsentIdentifier.md) |  | [optional] 
**RequestedFinancialAccounts** | [**List&lt;DataConsentRequestedFinancialAccount&gt;**](DataConsentRequestedFinancialAccount.md) |  | [optional] 
**RequestedDocuments** | [**List&lt;DataConsentRequestedDocument&gt;**](DataConsentRequestedDocument.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

