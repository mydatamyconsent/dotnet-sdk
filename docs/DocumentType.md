# MyDataMyConsent.Models.DocumentType
Issuable Document Type details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Document Type Identifier. | 
**CategoryType** | **DocumentCategoryType** |  | 
**SubCategoryType** | **DocumentSubCategoryType** |  | 
**Name** | **string** | Document Type Name. eg: Driving License. | 
**Slug** | **string** | Document Type Unique Slug. eg: \&quot;in.gov.gj.transport.dl\&quot;. | 
**Description** | **string** | Document Type description. eg: Gujarat State Driving License. | [optional] 
**LogoUrl** | **string** | Logo URL of document type. | 
**SearchServiceName** | **string** | Document search repository service name. | [optional] 
**RepositoryServiceName** | **string** | Document repository service name. | [optional] 
**SupportedEntityTypes** | [**List&lt;SupportedEntityType&gt;**](SupportedEntityType.md) | Supported entity types. eg: Individual, Organization. | 
**AddedBy** | **string** | Name of the document type creator. | 
**PayableAmount** | **double** | Payable amount if document is chargeable. eg: 10.25. | 
**PayableAmountCurrency** | **string** | Payable amount currency. eg: INR, USD etc.,. | [optional] 
**ApprovedAtUtc** | **DateTime?** | DateTime of approval in UTC timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

