# MyDataMyConsent.Models.ConsentRequest
ConsentRequest :Consent request details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Consent request id. | 
**TemplateId** | **string** | Consent request template id. | [optional] 
**ConsentId** | **string** | Consent id. | [optional] 
**Title** | **string** | Consent title. | 
**Description** | **string** | Consent description. | 
**Purpose** | **string** | Consent purpose. | [optional] 
**DataLife** | [**Life**](Life.md) |  | [optional] 
**Collectables** | [**List&lt;CollectibleTypes&gt;**](CollectibleTypes.md) | List of supported collectables. | 
**Receiver** | [**ConsentRequestReceiver**](ConsentRequestReceiver.md) |  | 
**Status** | **DataConsentStatus** |  | 
**CreatedAtUtc** | **DateTime** | Request creation datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime** | Request expiration datetime in UTC timezone. | 
**ApprovedAtUtc** | **DateTime** | Request approval datetime in UTC timezone. | [optional] 
**DataAccessExpiresAtUtc** | **DateTime** | Data access expiration datetime in UTC timezone. | [optional] 
**RejectedAtUtc** | **DateTime** | Request rejection datetime in UTC timezone. | [optional] 
**RevokedAtUtc** | **DateTime** | Request revocation datetime in UTC timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

