# MyDataMyConsent.Sdk.Models.OrganizationDataConsentRequestDetails
DataConsentRequestResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Receiver** | **string** | Name of request receiver organization. | 
**Id** | **Guid** | Consent request id | 
**TemplateId** | **Guid?** | Consent request template id | [optional] 
**ConsentId** | **Guid?** | Data Consent id | [optional] 
**Title** | **string** | Consent request title. | 
**Description** | **string** | Consent request description. | 
**Purpose** | **string** | Consent request purpose. | [optional] 
**Status** | **DataConsentStatus** |  | 
**TransactionId** | **string** | Transaction id | [optional] 
**CreatedAtUtc** | **DateTime** | Request creation datetime in UTC timezone | 
**ExpiresAtUtc** | **DateTime** | Request expiration datetime in UTC timezone | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

