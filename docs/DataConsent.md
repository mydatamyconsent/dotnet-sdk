# MyDataMyConsent.Sdk.Models.DataConsent
Data Consent details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Data consent id. | 
**RequestId** | **Guid** | Data consent request id. | 
**TemplateId** | **Guid?** | Consent template id. | [optional] 
**Title** | **string** | Consent title. | 
**Description** | **string** | Consent description. | 
**Purpose** | [**string?**](string?.md) | Consent purpose. | [optional] 
**Status** | **DataConsentStatus** |  | 
**TransactionId** | [**string?**](string?.md) | Transaction id. | [optional] 
**ApprovedAtUtc** | **DateTime** | Consent approval datetime in UTC timezone. | 
**DataAccessExpiresAtUtc** | **DateTime** | Data access expiration datetime in UTC timezone. | 
**RevokedAtUtc** | **DateTime?** | Consent revocation datetime in UTC timezone. | [optional] 
**Collectables** | [**List&lt;CollectibleTypes&gt;**](CollectibleTypes.md) | List of supported collectible types. | 
**Identifiers** | **Object** | Consented identity details. | [optional] 
**Documents** | [**List&lt;DataConsentDocument&gt;**](DataConsentDocument.md) | List of consented documents. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

