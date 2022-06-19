# MyDataMyConsent.Models.DataConsentRequest
Data consent request details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Data consent request id. | 
**TemplateId** | **Guid?** | Data consent template id. | [optional] 
**ConsentId** | **Guid?** | Data consent id. | [optional] 
**Title** | **string** | Data consent title. | 
**Description** | **string** | Data consent description. | 
**Purpose** | **string** | Data consent purpose. | [optional] 
**DataLife** | [**Life**](Life.md) |  | [optional] 
**Collectables** | [**List&lt;CollectibleTypes&gt;**](CollectibleTypes.md) | List of supported collectables. | 
**Receiver** | [**ConsentRequestReceiver**](ConsentRequestReceiver.md) |  | 
**Status** | **DataConsentStatus** |  | 
**CreatedAtUtc** | **DateTime** | Request creation datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime** | Request expiration datetime in UTC timezone. | 
**ApprovedAtUtc** | **DateTime?** | Request approval datetime in UTC timezone. | [optional] 
**DataAccessExpiresAtUtc** | **DateTime?** | Data access expiration datetime in UTC timezone. | [optional] 
**RejectedAtUtc** | **DateTime?** | Request rejection datetime in UTC timezone. | [optional] 
**RevokedAtUtc** | **DateTime?** | Request revocation datetime in UTC timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

