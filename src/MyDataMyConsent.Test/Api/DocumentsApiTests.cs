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
    ///  Class for testing DocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DocumentsApiTests : IDisposable
    {
        private DocumentsApi instance;

        public DocumentsApiTests()
        {
            instance = new DocumentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DocumentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DocumentsApi
            //Assert.IsType<DocumentsApi>(instance);
        }

        /// <summary>
        /// Test GetIssuedDocumentById
        /// </summary>
        [Fact]
        public void GetIssuedDocumentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid documentId = null;
            //var response = instance.GetIssuedDocumentById(documentId);
            //Assert.IsType<IssuedDocumentDetails>(response);
        }

        /// <summary>
        /// Test GetIssuedDocuments
        /// </summary>
        [Fact]
        public void GetIssuedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? documentTypeId = null;
            //DateTime? fromDateTime = null;
            //DateTime? toDateTime = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetIssuedDocuments(documentTypeId, fromDateTime, toDateTime, pageNo, pageSize);
            //Assert.IsType<IssuedDocumentPaginatedList>(response);
        }

        /// <summary>
        /// Test GetRegisteredDocumentTypes
        /// </summary>
        [Fact]
        public void GetRegisteredDocumentTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SupportedEntityType? supportedEntityType = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.GetRegisteredDocumentTypes(supportedEntityType, pageNo, pageSize);
            //Assert.IsType<DocumentTypePaginatedList>(response);
        }

        /// <summary>
        /// Test IssueDocumentToIndividual
        /// </summary>
        [Fact]
        public void IssueDocumentToIndividualTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIssueRequest documentIssueRequest = null;
            //var response = instance.IssueDocumentToIndividual(documentIssueRequest);
            //Assert.IsType<DocumentIssueRequestDetails>(response);
        }

        /// <summary>
        /// Test IssueDocumentToOrganization
        /// </summary>
        [Fact]
        public void IssueDocumentToOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentIssueRequest documentIssueRequest = null;
            //var response = instance.IssueDocumentToOrganization(documentIssueRequest);
            //Assert.IsType<DocumentIssueRequestDetails>(response);
        }

        /// <summary>
        /// Test UploadDocumentForIndividual
        /// </summary>
        [Fact]
        public void UploadDocumentForIndividualTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid issueRequestId = null;
            //System.IO.Stream formFile = null;
            //instance.UploadDocumentForIndividual(issueRequestId, formFile);
        }

        /// <summary>
        /// Test UploadDocumentForOrganization
        /// </summary>
        [Fact]
        public void UploadDocumentForOrganizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid issueRequestId = null;
            //System.IO.Stream formFile = null;
            //instance.UploadDocumentForOrganization(issueRequestId, formFile);
        }
    }
}