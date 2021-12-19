/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@mydatamyconsent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.mydatamyconsent.Api;
using com.mydatamyconsent.Model;
using com.mydatamyconsent.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.mydatamyconsent.Test.Model
{
    /// <summary>
    ///  Class for testing ApplicationUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationUserTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ApplicationUser
        //private ApplicationUser instance;

        public ApplicationUserTests()
        {
            // TODO uncomment below to create an instance of ApplicationUser
            //instance = new ApplicationUser();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationUser
        /// </summary>
        [Fact]
        public void ApplicationUserInstanceTest()
        {
            // TODO uncomment below to test "IsType" ApplicationUser
            //Assert.IsType<ApplicationUser>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'NormalizedUserName'
        /// </summary>
        [Fact]
        public void NormalizedUserNameTest()
        {
            // TODO unit test for the property 'NormalizedUserName'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'NormalizedEmail'
        /// </summary>
        [Fact]
        public void NormalizedEmailTest()
        {
            // TODO unit test for the property 'NormalizedEmail'
        }
        /// <summary>
        /// Test the property 'EmailConfirmed'
        /// </summary>
        [Fact]
        public void EmailConfirmedTest()
        {
            // TODO unit test for the property 'EmailConfirmed'
        }
        /// <summary>
        /// Test the property 'PasswordHash'
        /// </summary>
        [Fact]
        public void PasswordHashTest()
        {
            // TODO unit test for the property 'PasswordHash'
        }
        /// <summary>
        /// Test the property 'SecurityStamp'
        /// </summary>
        [Fact]
        public void SecurityStampTest()
        {
            // TODO unit test for the property 'SecurityStamp'
        }
        /// <summary>
        /// Test the property 'ConcurrencyStamp'
        /// </summary>
        [Fact]
        public void ConcurrencyStampTest()
        {
            // TODO unit test for the property 'ConcurrencyStamp'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'PhoneNumberConfirmed'
        /// </summary>
        [Fact]
        public void PhoneNumberConfirmedTest()
        {
            // TODO unit test for the property 'PhoneNumberConfirmed'
        }
        /// <summary>
        /// Test the property 'TwoFactorEnabled'
        /// </summary>
        [Fact]
        public void TwoFactorEnabledTest()
        {
            // TODO unit test for the property 'TwoFactorEnabled'
        }
        /// <summary>
        /// Test the property 'LockoutEnd'
        /// </summary>
        [Fact]
        public void LockoutEndTest()
        {
            // TODO unit test for the property 'LockoutEnd'
        }
        /// <summary>
        /// Test the property 'LockoutEnabled'
        /// </summary>
        [Fact]
        public void LockoutEnabledTest()
        {
            // TODO unit test for the property 'LockoutEnabled'
        }
        /// <summary>
        /// Test the property 'AccessFailedCount'
        /// </summary>
        [Fact]
        public void AccessFailedCountTest()
        {
            // TODO unit test for the property 'AccessFailedCount'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'MiddleName'
        /// </summary>
        [Fact]
        public void MiddleNameTest()
        {
            // TODO unit test for the property 'MiddleName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'FullName'
        /// </summary>
        [Fact]
        public void FullNameTest()
        {
            // TODO unit test for the property 'FullName'
        }
        /// <summary>
        /// Test the property 'Gender'
        /// </summary>
        [Fact]
        public void GenderTest()
        {
            // TODO unit test for the property 'Gender'
        }
        /// <summary>
        /// Test the property 'DateOfBirth'
        /// </summary>
        [Fact]
        public void DateOfBirthTest()
        {
            // TODO unit test for the property 'DateOfBirth'
        }
        /// <summary>
        /// Test the property 'CountryId'
        /// </summary>
        [Fact]
        public void CountryIdTest()
        {
            // TODO unit test for the property 'CountryId'
        }
        /// <summary>
        /// Test the property 'PostCode'
        /// </summary>
        [Fact]
        public void PostCodeTest()
        {
            // TODO unit test for the property 'PostCode'
        }
        /// <summary>
        /// Test the property 'ReferredBy'
        /// </summary>
        [Fact]
        public void ReferredByTest()
        {
            // TODO unit test for the property 'ReferredBy'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'Theme'
        /// </summary>
        [Fact]
        public void ThemeTest()
        {
            // TODO unit test for the property 'Theme'
        }
        /// <summary>
        /// Test the property 'Designation'
        /// </summary>
        [Fact]
        public void DesignationTest()
        {
            // TODO unit test for the property 'Designation'
        }
        /// <summary>
        /// Test the property 'IsMarkedForDeletion'
        /// </summary>
        [Fact]
        public void IsMarkedForDeletionTest()
        {
            // TODO unit test for the property 'IsMarkedForDeletion'
        }
        /// <summary>
        /// Test the property 'HardDeleteDate'
        /// </summary>
        [Fact]
        public void HardDeleteDateTest()
        {
            // TODO unit test for the property 'HardDeleteDate'
        }
        /// <summary>
        /// Test the property 'SecurityPin'
        /// </summary>
        [Fact]
        public void SecurityPinTest()
        {
            // TODO unit test for the property 'SecurityPin'
        }
        /// <summary>
        /// Test the property 'PhotoUrl'
        /// </summary>
        [Fact]
        public void PhotoUrlTest()
        {
            // TODO unit test for the property 'PhotoUrl'
        }
        /// <summary>
        /// Test the property 'ReferralCode'
        /// </summary>
        [Fact]
        public void ReferralCodeTest()
        {
            // TODO unit test for the property 'ReferralCode'
        }
        /// <summary>
        /// Test the property 'RecoveryToken'
        /// </summary>
        [Fact]
        public void RecoveryTokenTest()
        {
            // TODO unit test for the property 'RecoveryToken'
        }
        /// <summary>
        /// Test the property 'DigiLockerLastSyncDate'
        /// </summary>
        [Fact]
        public void DigiLockerLastSyncDateTest()
        {
            // TODO unit test for the property 'DigiLockerLastSyncDate'
        }
        /// <summary>
        /// Test the property 'RefreshTokens'
        /// </summary>
        [Fact]
        public void RefreshTokensTest()
        {
            // TODO unit test for the property 'RefreshTokens'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'ReferredByUser'
        /// </summary>
        [Fact]
        public void ReferredByUserTest()
        {
            // TODO unit test for the property 'ReferredByUser'
        }

    }

}
