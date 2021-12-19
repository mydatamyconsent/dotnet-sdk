# com.mydatamyconsent.Model.ApplicationUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**UserName** | **string** |  | [optional] 
**NormalizedUserName** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**NormalizedEmail** | **string** |  | [optional] 
**EmailConfirmed** | **bool** |  | [optional] 
**PasswordHash** | **string** |  | [optional] 
**SecurityStamp** | **string** |  | [optional] 
**ConcurrencyStamp** | **string** |  | [optional] 
**PhoneNumber** | **string** |  | [optional] 
**PhoneNumberConfirmed** | **bool** |  | [optional] 
**TwoFactorEnabled** | **bool** |  | [optional] 
**LockoutEnd** | **DateTime?** |  | [optional] 
**LockoutEnabled** | **bool** |  | [optional] 
**AccessFailedCount** | **int** |  | [optional] 
**FirstName** | **string** |  | [optional] 
**MiddleName** | **string** |  | [optional] 
**LastName** | **string** |  | [optional] 
**FullName** | **string** |  | [optional] [readonly] 
**Gender** | **Gender** |  | [optional] 
**DateOfBirth** | **DateTime** |  | [optional] 
**CountryId** | **Guid** |  | [optional] 
**PostCode** | **string** |  | [optional] 
**ReferredBy** | **Guid?** |  | [optional] 
**Language** | **string** |  | [optional] 
**Theme** | **Theme** |  | [optional] 
**Designation** | **string** |  | [optional] 
**IsMarkedForDeletion** | **bool** |  | [optional] 
**HardDeleteDate** | **DateTime?** |  | [optional] 
**SecurityPin** | **string** |  | [optional] 
**PhotoUrl** | **string** |  | [optional] 
**ReferralCode** | **string** |  | [optional] 
**RecoveryToken** | **string** |  | [optional] 
**DigiLockerLastSyncDate** | **DateTime?** |  | [optional] 
**RefreshTokens** | [**List&lt;RefreshToken&gt;**](RefreshToken.md) |  | [optional] 
**Country** | [**Country**](Country.md) |  | [optional] 
**ReferredByUser** | [**ApplicationUser**](ApplicationUser.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

