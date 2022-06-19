# MyDataMyConsent.Models.DataConsentDetails
Data Consent details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Data consent id. | 
**RequestId** | **Guid** | Consent request id. | 
**TemplateId** | **Guid?** | Consent template id. | [optional] 
**Title** | **string** | Consent title. | 
**Description** | **string** | Consent description. | 
**Purpose** | **string** | Consent purpose. | [optional] 
**Status** | **DataConsentStatus** |  | 
**TransactionId** | **string** | Transaction id. | [optional] 
**RequestedAtUtc** | **DateTime** | Consent requested datetime in UTC timezone. | 
**ApprovedAtUtc** | **DateTime** | Consent approval datetime in UTC timezone. | 
**DataAccessExpiresAtUtc** | **DateTime** | Data access expiration datetime in UTC timezone. | 
**RevokedAtUtc** | **DateTime?** | Consent revocation datetime in UTC timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

