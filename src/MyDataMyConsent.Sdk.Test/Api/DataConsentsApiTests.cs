/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of data consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: v1
 * Contact: support@mydatamyconsent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using MyDataMyConsent.Sdk.Client;
using MyDataMyConsent.Sdk.Api;
// uncomment below to import models
//using MyDataMyConsent.Sdk.Models;

namespace MyDataMyConsent.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing DataConsentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataConsentsApiTests : IDisposable
    {
        private DataConsentsApi instance;

        public DataConsentsApiTests()
        {
            instance = new DataConsentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataConsentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataConsentsApi
            //Assert.IsType<DataConsentsApi>(instance);
        }

        /// <summary>
        /// Test DownloadConsentedDocumentById
        /// </summary>
        [Fact]
        public void DownloadConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.DownloadConsentedDocumentById(consentId, documentId);
            //Assert.IsType<UserDocumentDownloadDto>(response);
        }

        /// <summary>
        /// Test DownloadOrgConsentedDocumentById
        /// </summary>
        [Fact]
        public void DownloadOrgConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.DownloadOrgConsentedDocumentById(consentId, documentId);
            //Assert.IsType<OrganizationDocumentDownloadDto>(response);
        }

        /// <summary>
        /// Test GetAllConsentedDocuments
        /// </summary>
        [Fact]
        public void GetAllConsentedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetAllConsentedDocuments(consentId);
            //Assert.IsType<DataConsentDocumentsDto>(response);
        }

        /// <summary>
        /// Test GetAllConsentedFinancialAccounts
        /// </summary>
        [Fact]
        public void GetAllConsentedFinancialAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetAllConsentedFinancialAccounts(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test GetAllOrganizationConsentedAccounts
        /// </summary>
        [Fact]
        public void GetAllOrganizationConsentedAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetAllOrganizationConsentedAccounts(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test GetAllOrganizationConsentedDocuments
        /// </summary>
        [Fact]
        public void GetAllOrganizationConsentedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetAllOrganizationConsentedDocuments(consentId);
            //Assert.IsType<DataConsentDocumentsDto>(response);
        }

        /// <summary>
        /// Test GetConsentDetailsById
        /// </summary>
        [Fact]
        public void GetConsentDetailsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetConsentDetailsById(consentId);
            //Assert.IsType<DataConsentDetailsDto>(response);
        }

        /// <summary>
        /// Test GetConsentedAccountById
        /// </summary>
        [Fact]
        public void GetConsentedAccountByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.GetConsentedAccountById(consentId, accountId);
            //Assert.IsType<FinancialAccount>(response);
        }

        /// <summary>
        /// Test GetConsentedDocumentById
        /// </summary>
        [Fact]
        public void GetConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.GetConsentedDocumentById(consentId, documentId);
            //Assert.IsType<UserDocumentDetailsDto>(response);
        }

        /// <summary>
        /// Test GetConsentedFinancialAccount
        /// </summary>
        [Fact]
        public void GetConsentedFinancialAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.GetConsentedFinancialAccount(consentId, accountId);
            //Assert.IsType<OrganizationFinancialAccountDto>(response);
        }

        /// <summary>
        /// Test GetConsentedFinancialAccountTransactions
        /// </summary>
        [Fact]
        public void GetConsentedFinancialAccountTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string? filters = null;
            //DateTime? fromDateTimeUtc = null;
            //DateTime? toDateTimeUtc = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetConsentedFinancialAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
            //Assert.IsType<UserAccountFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetConsents
        /// </summary>
        [Fact]
        public void GetConsentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetConsents(status, from, to, pageNo, pageSize);
            //Assert.IsType<UserDataConsentInfoDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetConsentsForOrganizations
        /// </summary>
        [Fact]
        public void GetConsentsForOrganizationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? from = null;
            //DateTime? to = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetConsentsForOrganizations(status, from, to, pageNo, pageSize);
            //Assert.IsType<OrganizationDataConsentInfoDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetOrgConsentedAccountTransactions
        /// </summary>
        [Fact]
        public void GetOrgConsentedAccountTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string? filters = null;
            //DateTime? fromDateTimeUtc = null;
            //DateTime? toDateTimeUtc = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetOrgConsentedAccountTransactions(consentId, accountId, filters, fromDateTimeUtc, toDateTimeUtc, pageNo, pageSize);
            //Assert.IsType<OrganizationFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test GetOrganizationConsentDetailsById
        /// </summary>
        [Fact]
        public void GetOrganizationConsentDetailsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.GetOrganizationConsentDetailsById(consentId);
            //Assert.IsType<DataConsentDetailsDto>(response);
        }

        /// <summary>
        /// Test GetOrganizationConsentedDocumentById
        /// </summary>
        [Fact]
        public void GetOrganizationConsentedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.GetOrganizationConsentedDocumentById(consentId, documentId);
            //Assert.IsType<OrganizationDocumentDetailsDto>(response);
        }
    }
}
