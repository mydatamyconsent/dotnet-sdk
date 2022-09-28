/*
 * My Data My Consent - Developer API
 *
 * Unleashing the power of consent by establishing trust. The Platform Core Developer API defines a set of capabilities that can be used to request, issue, manage and update data, documents and credentials by organizations. The API can be used to request, manage and update Decentralised Identifiers, Financial Data, Health Data issue Documents, Credentials directly or using OpenID Connect flows, and verify Messages signed with DIDs and much more.
 *
 * The version of the OpenAPI document: 1.0
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
    ///  Class for testing OrganizationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationsApiTests : IDisposable
    {
        private OrganizationsApi instance;

        public OrganizationsApiTests()
        {
            instance = new OrganizationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationsApi
            //Assert.IsType<OrganizationsApi>(instance);
        }

        /// <summary>
        /// Test V1OrganizationsConsentRequestsGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentRequestsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsConsentRequestsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<PaginatedListOfOrganizationConsentRequestDetailss>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentRequestsPost
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentRequestsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateConsentRequest createConsentRequest = null;
            //var response = instance.V1OrganizationsConsentRequestsPost(createConsentRequest);
            //Assert.IsType<OrganizationConsentRequestDetails>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentRequestsRequestIdCancelPut
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentRequestsRequestIdCancelPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.V1OrganizationsConsentRequestsRequestIdCancelPut(requestId);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentRequestsRequestIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentRequestsRequestIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string requestId = null;
            //var response = instance.V1OrganizationsConsentRequestsRequestIdGet(requestId);
            //Assert.IsType<ConsentRequest>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentTemplatesGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsConsentTemplatesGet(pageNo, pageSize);
            //Assert.IsType<PaginatedListOfConsentRequestTemplates>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentTemplatesTemplateIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentTemplatesTemplateIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string templateId = null;
            //var response = instance.V1OrganizationsConsentTemplatesTemplateIdGet(templateId);
            //Assert.IsType<OrganizationConsentRequestTemplateDetails>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string documentId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdDownloadGet(consentId, documentId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdDocumentsDocumentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string documentId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdDocumentsDocumentIdGet(consentId, documentId);
            //Assert.IsType<ConsentedDocument>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdDocumentsGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdDocumentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdDocumentsGet(consentId);
            //Assert.IsType<List<ConsentedDocument>>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string accountId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdGet(consentId, accountId);
            //Assert.IsType<FinancialAccount>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //string accountId = null;
            //string? filters = null;
            //string? fromDateTime = null;
            //string? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsConsentsConsentIdFinancialAccountsAccountIdTransactionsGet(consentId, accountId, filters, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<PaginatedListOfFinancialAccountTransactions>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdFinancialAccountsGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdFinancialAccountsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdFinancialAccountsGet(consentId);
            //Assert.IsType<List<FinancialAccount>>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsConsentIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsConsentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentId = null;
            //var response = instance.V1OrganizationsConsentsConsentIdGet(consentId);
            //Assert.IsType<ConsentDetails>(response);
        }

        /// <summary>
        /// Test V1OrganizationsConsentsGet
        /// </summary>
        [Fact]
        public void V1OrganizationsConsentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataConsentStatus? status = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsConsentsGet(status, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<PaginatedListOfConsents>(response);
        }

        /// <summary>
        /// Test V1OrganizationsDocumentsIssuePost
        /// </summary>
        [Fact]
        public void V1OrganizationsDocumentsIssuePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIssueRequest documentIssueRequest = null;
            //var response = instance.V1OrganizationsDocumentsIssuePost(documentIssueRequest);
            //Assert.IsType<DocumentIssueRequestDetails>(response);
        }

        /// <summary>
        /// Test V1OrganizationsDocumentsIssueUploadIssueRequestIdPost
        /// </summary>
        [Fact]
        public void V1OrganizationsDocumentsIssueUploadIssueRequestIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string issueRequestId = null;
            //System.IO.Stream file = null;
            //var response = instance.V1OrganizationsDocumentsIssueUploadIssueRequestIdPost(issueRequestId, file);
            //Assert.IsType<UploadDocumentResponse>(response);
        }

        /// <summary>
        /// Test V1OrganizationsDocumentsIssuedDocumentIdGet
        /// </summary>
        [Fact]
        public void V1OrganizationsDocumentsIssuedDocumentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentId = null;
            //var response = instance.V1OrganizationsDocumentsIssuedDocumentIdGet(documentId);
            //Assert.IsType<IssuedDocument>(response);
        }

        /// <summary>
        /// Test V1OrganizationsDocumentsIssuedGet
        /// </summary>
        [Fact]
        public void V1OrganizationsDocumentsIssuedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentTypeId = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsDocumentsIssuedGet(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<PaginatedListOfIssuedDocuments>(response);
        }

        /// <summary>
        /// Test V1OrganizationsDocumentsTypesGet
        /// </summary>
        [Fact]
        public void V1OrganizationsDocumentsTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1OrganizationsDocumentsTypesGet(pageNo, pageSize);
            //Assert.IsType<PaginatedListOfDocumentTypes>(response);
        }
    }
}
