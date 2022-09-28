# MyDataMyConsent.Models.ConsentDetails
ConsentDetails : Consent details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Consent id. | 
**RequestId** | **string** | Consent request id. | 
**TemplateId** | **string** | Consent request template id. | [optional] 
**Title** | **string** | Consent title. | 
**Description** | **string** | Consent description. | 
**Purpose** | **string** | Consent purpose. | [optional] 
**Status** | **DataConsentStatus** |  | 
**TransactionId** | **string** | Transaction id. | [optional] 
**ApprovedAtUtc** | **DateTime** | Consent approval datetime in UTC timezone. | 
**DataAccessExpiresAtUtc** | **DateTime** | Data access expiration datetime in UTC timezone. | 
**RevokedAtUtc** | **DateTime** | Consent revocation datetime in UTC timezone. | [optional] 
**Collectables** | [**List&lt;CollectibleTypes&gt;**](CollectibleTypes.md) | List of supported collectible types. | 
**Identifiers** | [**List&lt;ConsentedIdentifier&gt;**](ConsentedIdentifier.md) | Consented identity details. | [optional] 
**Documents** | [**List&lt;ConsentedDocument&gt;**](ConsentedDocument.md) | List of consented documents. | [optional] 
**MedicalRecords** | [**List&lt;ConsentedMedicalRecord&gt;**](ConsentedMedicalRecord.md) | List of consented medical records. | [optional] 
**FinancialAccounts** | [**List&lt;ConsentedFinancialAccount&gt;**](ConsentedFinancialAccount.md) | List of consented financial accounts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

