# MyDataMyConsent.Models.DocumentIssueRequestDetails
DocumentIssueRequestDetails : Document issue request details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Document issue request Id. | 
**DocumentTypeId** | **string** | Document type Id. | 
**TypeName** | **string** | Document type name. | 
**Identifier** | **string** | Document identifier. | 
**Status** | **DocumentIssueRequestStatus** |  | 
**Description** | **string** | Document description. | 
**Receiver** | [**DocumentIssueRequestDetailsReceiver**](DocumentIssueRequestDetailsReceiver.md) |  | 
**PaymentRequest** | [**PaymentRequest**](PaymentRequest.md) |  | [optional] 
**IssuedAtUtc** | **DateTime** | Datetime of issue in UTC timezone. | 
**ValidFromUtc** | **DateTime** | Valid from datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime** | Datetime of expiry in UTC timezone. | [optional] 
**MetaData** | **Object** | Metadata. | [optional] 
**CreatedAtUtc** | **DateTime** | Creation datetime of issue request in UTC timezone. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

