# MyDataMyConsent.Models.DocumentIssueRequest
DocumentIssueRequest : Document Issue Request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentTypeId** | **string** | Document type id. | 
**Identifier** | **string** | Document identifier. | 
**Description** | **string** | Document description. | 
**Receiver** | [**DocumentIssueRequestReceiver**](DocumentIssueRequestReceiver.md) |  | 
**PaymentRequest** | [**DocumentIssueRequestPaymentRequest**](DocumentIssueRequestPaymentRequest.md) |  | [optional] 
**IssuedAtUtc** | **DateTime** | Datetime of issue in UTC timezone. | 
**ValidFromUtc** | **DateTime** | Valid from datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime** | Datetime of expiry in UTC timezone. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

