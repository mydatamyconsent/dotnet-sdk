# com.mydatamyconsent.Model.DataConsentRequestModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **Guid** |  | [optional] 
**TransactionId** | **string** |  | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**StartDateTime** | **DateTime?** |  | [optional] 
**ExpiryDateTime** | **DateTime** |  | [optional] 
**Description** | **string** |  | [optional] 
**PurposeCode** | **string** |  | [optional] 
**PurposeLink** | **string** |  | [optional] 
**DataLifeUnit** | **DataLifeUnit** |  | [optional] 
**DataLifeValue** | **int** |  | [optional] 
**DataFetchFrequencyUnit** | **DataFetchFrequencyUnit** |  | [optional] 
**DataFetchFrequencyUnitValue** | **int** |  | [optional] 
**DataFetchType** | **DataFetchType** |  | [optional] 
**AgreementId** | **Guid** |  | [optional] 
**IdentityClaims** | [**List&lt;IdentityClaim&gt;**](IdentityClaim.md) |  | [optional] 
**FinancialAccounts** | [**List&lt;DataConsentRequestedFaDto&gt;**](DataConsentRequestedFaDto.md) |  | [optional] 
**Documents** | [**List&lt;DataConsentRequestedDocumentDto&gt;**](DataConsentRequestedDocumentDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

