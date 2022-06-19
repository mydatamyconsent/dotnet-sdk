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
    ///  Class for testing DataProviderDiscoveryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataProviderDiscoveryApiTests : IDisposable
    {
        private DataProviderDiscoveryApi instance;

        public DataProviderDiscoveryApiTests()
        {
            instance = new DataProviderDiscoveryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataProviderDiscoveryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataProviderDiscoveryApi
            //Assert.IsType<DataProviderDiscoveryApi>(instance);
        }

        /// <summary>
        /// Test GetDataProviderById
        /// </summary>
        [Fact]
        public void GetDataProviderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //var response = instance.GetDataProviderById(providerId);
            //Assert.IsType<DataProvider>(response);
        }

        /// <summary>
        /// Test GetDataProviders
        /// </summary>
        [Fact]
        public void GetDataProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? accountType = null;
            //string? documentType = null;
            //string? organizationCategory = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //string? countryIso2Code = null;
            //var response = instance.GetDataProviders(accountType, documentType, organizationCategory, pageNo, pageSize, countryIso2Code);
            //Assert.IsType<DataProviderPaginatedList>(response);
        }
    }
}