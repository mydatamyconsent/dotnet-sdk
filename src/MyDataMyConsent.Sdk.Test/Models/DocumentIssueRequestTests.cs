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
using MyDataMyConsent.Sdk.Api;
using MyDataMyConsent.Sdk.Models;
using MyDataMyConsent.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace MyDataMyConsent.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing DocumentIssueRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DocumentIssueRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DocumentIssueRequest
        //private DocumentIssueRequest instance;

        public DocumentIssueRequestTests()
        {
            // TODO uncomment below to create an instance of DocumentIssueRequest
            //instance = new DocumentIssueRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DocumentIssueRequest
        /// </summary>
        [Fact]
        public void DocumentIssueRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" DocumentIssueRequest
            //Assert.IsType<DocumentIssueRequest>(instance);
        }


        /// <summary>
        /// Test the property 'DocumentTypeId'
        /// </summary>
        [Fact]
        public void DocumentTypeIdTest()
        {
            // TODO unit test for the property 'DocumentTypeId'
        }
        /// <summary>
        /// Test the property 'DocumentIdentifier'
        /// </summary>
        [Fact]
        public void DocumentIdentifierTest()
        {
            // TODO unit test for the property 'DocumentIdentifier'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Receiver'
        /// </summary>
        [Fact]
        public void ReceiverTest()
        {
            // TODO unit test for the property 'Receiver'
        }
        /// <summary>
        /// Test the property 'ExpiresAtUtc'
        /// </summary>
        [Fact]
        public void ExpiresAtUtcTest()
        {
            // TODO unit test for the property 'ExpiresAtUtc'
        }
        /// <summary>
        /// Test the property 'Base64PdfDocument'
        /// </summary>
        [Fact]
        public void Base64PdfDocumentTest()
        {
            // TODO unit test for the property 'Base64PdfDocument'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }

    }

}