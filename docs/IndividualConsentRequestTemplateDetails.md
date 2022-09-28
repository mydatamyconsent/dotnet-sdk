# MyDataMyConsent.Models.IndividualConsentRequestTemplateDetails
IndividualConsentRequestTemplateDetails :  Individual consent request template details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Consent request template id. | 
**Title** | **string** | Consent request template title. | 
**Description** | **string** | Consent request template description. | 
**Purpose** | **string** | Consent request template purpose. | [optional] 
**ShortId** | **string** | Consent request template short Id. | 
**Status** | **ConsentRequestTemplateStatus** |  | 
**DataLife** | [**IndividualConsentRequestTemplateDetailsDataLife**](IndividualConsentRequestTemplateDetailsDataLife.md) |  | [optional] 
**RequestLife** | [**IndividualConsentRequestTemplateDetailsRequestLife**](IndividualConsentRequestTemplateDetailsRequestLife.md) |  | [optional] 
**DataFrequency** | [**IndividualConsentRequestTemplateDetailsDataFrequency**](IndividualConsentRequestTemplateDetailsDataFrequency.md) |  | [optional] 
**Identifiers** | [**List&lt;IdentityField&gt;**](IdentityField.md) | Consent request template identity fields. | [optional] 
**Documents** | [**List&lt;DocumentField&gt;**](DocumentField.md) | Consent request template document fields. | [optional] 
**MedicalRecords** | [**List&lt;MedicalRecordField&gt;**](MedicalRecordField.md) | Consent request template medical record fields. | [optional] 
**FinancialAccounts** | [**List&lt;FinancialAccountField&gt;**](FinancialAccountField.md) | Consent request template financial account fields. | [optional] 
**CreatedBy** | **string** | Consent request template created by user. | 
**CreatedAtUtc** | **DateTime** | Consent request template created datetime in UTC timezone. | 
**ApprovedAtUtc** | **DateTime** | Consent request template approval datetime in UTC timezone. | [optional] 
**PublishedAtUtc** | **DateTime** | Consent request template published datetime in UTC timezone. | [optional] 
**RejectedAtUtc** | **DateTime** | Consent request template rejection datetime in UTC timezone. | [optional] 
**RejectionReason** | **string** | Consent request template rejection reason. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

