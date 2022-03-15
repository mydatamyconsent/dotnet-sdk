# MyDataMyConsent.Sdk.Models.DataConsentRequestDetails
DataConsentRequestResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Consent request id | 
**TemplateId** | **Guid?** | Consent request template id | [optional] 
**Title** | **string** | Consent request title. | 
**Description** | **string** | Consent request description. | 
**Purpose** | [**string?**](string?.md) | Consent request purpose. | [optional] 
**Status** | **DataConsentStatus** |  | 
**TransactionId** | [**string?**](string?.md) | Transaction id | [optional] 
**CreatedAtUtc** | **DateTime** | Request creation datetime in UTC timezone | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

