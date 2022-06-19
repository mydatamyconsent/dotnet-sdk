# MyDataMyConsent.Models.DocumentIssueRequestDetails
Document issue request details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Document issue request Id. | 
**DocumentTypeId** | **Guid** | Document type Id. | 
**TypeName** | **string** | Document type name. | 
**Identifier** | **string** | Document identifier. | 
**Status** | **DocumentIssueRequestStatus** |  | 
**Description** | **string** | Document description. | 
**Receiver** | **Object** | Document receiver details. | 
**IssuedAtUtc** | **DateTime** | Datetime of issue in UTC timezone. | 
**ValidFromUtc** | **DateTime** | Valid from datetime in UTC timezone. | 
**ExpiresAtUtc** | **DateTime?** | Datetime of expiry in UTC timezone. | [optional] 
**MetaData** | **Object** | Metadata. | [optional] 
**CreatedAtUtc** | **DateTime** | Creation datetime of issue request in UTC timezone. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

