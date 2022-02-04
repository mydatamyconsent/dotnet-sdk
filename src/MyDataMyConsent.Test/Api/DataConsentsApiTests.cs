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

using MyDataMyConsent.Client;
using MyDataMyConsent.Api;
// uncomment below to import models
//using MyDataMyConsent.Models;

namespace MyDataMyConsent.Test.Api
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
        /// Test V1ConsentsIndividualsConsentIdAccountsAccountIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdAccountsAccountIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdAccountsAccountIdGet(consentId, accountId);
            //Assert.IsType<FinancialAccount>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string filters = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //DateTime? fromDate = null;
            //DateTime? toDate = null;
            //var response = instance.V1ConsentsIndividualsConsentIdAccountsAccountIdTransactionsGet(consentId, accountId, filters, pageNo, pageSize, fromDate, toDate);
            //Assert.IsType<UserAccountFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdAccountsGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdAccountsGet(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
            //Assert.IsType<UserDocumentDownloadDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdDocumentsDocumentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdDocumentsDocumentIdGet(consentId, documentId);
            //Assert.IsType<UserDocumentDetailsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdDocumentsGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdDocumentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdDocumentsGet(consentId);
            //Assert.IsType<DataConsentDocumentsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsConsentIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsConsentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsIndividualsConsentIdGet(consentId);
            //Assert.IsType<DataConsentDetailsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsIndividualsGet
        /// </summary>
        [Fact]
        public void V1ConsentsIndividualsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNo = null;
            //int? pageSize = null;
            //DataConsentStatus? status = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.V1ConsentsIndividualsGet(pageNo, pageSize, status, startDate, endDate);
            //Assert.IsType<UserDataConsentInfoDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdAccountsAccountIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdAccountsAccountIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdAccountsAccountIdGet(consentId, accountId);
            //Assert.IsType<OrganizationFinancialAccountDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid accountId = null;
            //string filters = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //DateTime? fromDate = null;
            //DateTime? toDate = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdAccountsAccountIdTransactionsGet(consentId, accountId, filters, pageNo, pageSize, fromDate, toDate);
            //Assert.IsType<OrganizationFinancialTransactionsDtoPaginatedList>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdAccountsGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdAccountsGet(consentId);
            //Assert.IsType<DataConsentFinancialsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
            //Assert.IsType<OrganizationDocumentDownloadDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //Guid documentId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdDocumentsDocumentIdGet(consentId, documentId);
            //Assert.IsType<OrganizationDocumentDetailsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdDocumentsGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdDocumentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdDocumentsGet(consentId);
            //Assert.IsType<DataConsentDocumentsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsConsentIdGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsConsentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid consentId = null;
            //var response = instance.V1ConsentsOrganizationsConsentIdGet(consentId);
            //Assert.IsType<DataConsentDetailsDto>(response);
        }

        /// <summary>
        /// Test V1ConsentsOrganizationsGet
        /// </summary>
        [Fact]
        public void V1ConsentsOrganizationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNo = null;
            //int? pageSize = null;
            //DataConsentStatus? status = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.V1ConsentsOrganizationsGet(pageNo, pageSize, status, startDate, endDate);
            //Assert.IsType<OrganizationDataConsentInfoDtoPaginatedList>(response);
        }
    }
}
