# MyDataMyConsent.Models.ConsentedFinancialAccount
ConsentedFinancialAccount : Consented financial account details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Financial account id. | 
**Name** | **string** | Financial account name. | 
**Category** | **FinancialAccountCategoryType** |  | 
**SubCategory** | **FinancialAccountSubCategoryType** |  | 
**Identifier** | **string** | Financial account identifier. | 
**FieldTitle** | **string** | Financial account field title. | 
**FieldSlug** | **string** | Financial account field slug. | 
**RequestedDetails** | [**List&lt;FinancialAccountDetailsRequired&gt;**](FinancialAccountDetailsRequired.md) | Requested financial account details. | 
**TransactionPeriod** | [**ConsentedFinancialAccountTransactionPeriod**](ConsentedFinancialAccountTransactionPeriod.md) |  | [optional] 
**IssuerId** | **string** | Financial account issuer id. | 
**IssuerName** | **string** | Financial account issuer name. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

