# com.mydatamyconsent.Model.DataConsentDetailsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Requester** | [**DataConsentRequesterDto**](DataConsentRequesterDto.md) |  | [optional] 
**Location** | **string** |  | [optional] 
**PersonalInfoRequested** | **bool** |  | [optional] 
**Documents** | **int** |  | [optional] 
**FinancialAccounts** | **int** |  | [optional] 
**TransactionId** | **string** |  | [optional] 
**IpAddress** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**PurposeCode** | **string** |  | [optional] 
**PurposeLink** | **string** |  | [optional] 
**AgreementId** | **Guid?** |  | [optional] 
**DataLifeUnit** | **DataLifeUnit** |  | [optional] 
**DataLifeValue** | **int** |  | [optional] 
**DataFetchFrequencyUnit** | **DataFetchFrequencyUnit** |  | [optional] 
**DataFetchFrequencyUnitValue** | **int** |  | [optional] 
**DataFetchType** | **DataFetchType** |  | [optional] 
**Status** | **DataConsentStatus** |  | [optional] 
**ApprovedAtUtc** | **DateTime?** |  | [optional] 
**RejectedAtUtc** | **DateTime?** |  | [optional] 
**ExpiresAtUtc** | **DateTime** |  | [optional] 
**RequestedAtUtc** | **DateTime** |  | [optional] 
**RequestedFinancialAccounts** | [**List&lt;DataConsentRequestedAccountDto&gt;**](DataConsentRequestedAccountDto.md) |  | [optional] 
**RequestedDocuments** | [**List&lt;DataConsentRequestedDocumentDto&gt;**](DataConsentRequestedDocumentDto.md) |  | [optional] 
**RequestedHealthData** | [**List&lt;DataConsentRequestedDocument&gt;**](DataConsentRequestedDocument.md) |  | [optional] 
**RequestedIdentityDetails** | [**JsonSchema**](JsonSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

