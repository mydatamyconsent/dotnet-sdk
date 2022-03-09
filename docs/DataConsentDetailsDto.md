# MyDataMyConsent.Sdk.Models.DataConsentDetailsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsentRequestId** | **Guid** |  | 
**Title** | [**string?**](string?.md) |  | [optional] 
**Description** | [**string?**](string?.md) |  | [optional] 
**DataLife** | [**Life**](Life.md) |  | [optional] 
**RequestedByOrg** | [**Requester**](Requester.md) |  | [optional] 
**Collectables** | [**List&lt;CollectibleTypes&gt;**](CollectibleTypes.md) |  | 
**Status** | **DataConsentStatus** |  | [optional] 
**ApprovedAtUtc** | **DateTime?** |  | [optional] 
**ApprovedExpiresAtUtc** | **DateTime?** |  | [optional] 
**RejectedAtUtc** | **DateTime?** |  | [optional] 
**RevokedAtUtc** | **DateTime?** |  | [optional] 
**RequestedExpiresAtUtc** | **DateTime** |  | [optional] 
**RequestedAtUtc** | **DateTime** |  | [optional] 
**Identifiers** | **Object** |  | [optional] 
**Documents** | [**List&lt;DataConsentDocumentDetailsDto&gt;**](DataConsentDocumentDetailsDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

