# MyDataMyConsent.Models.Consent
Consent : Consent details.

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
**RequestedAtUtc** | **DateTime** | Consent requested datetime in UTC timezone. | 
**ApprovedAtUtc** | **DateTime** | Consent approval datetime in UTC timezone. | [optional] 
**DataAccessExpiresAtUtc** | **DateTime** | Data access expiration datetime in UTC timezone. | [optional] 
**RevokedAtUtc** | **DateTime** | Consent revocation datetime in UTC timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

