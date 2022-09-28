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
    ///  Class for testing DataProvidersDiscoveryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataProvidersDiscoveryApiTests : IDisposable
    {
        private DataProvidersDiscoveryApi instance;

        public DataProvidersDiscoveryApiTests()
        {
            instance = new DataProvidersDiscoveryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataProvidersDiscoveryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataProvidersDiscoveryApi
            //Assert.IsType<DataProvidersDiscoveryApi>(instance);
        }

        /// <summary>
        /// Test V1DataProvidersGet
        /// </summary>
        [Fact]
        public void V1DataProvidersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryIso2Code = null;
            //int? pageNo = null;
            //int? pageSize = null;
            //var response = instance.V1DataProvidersGet(countryIso2Code, pageNo, pageSize);
            //Assert.IsType<PaginatedListOfDataProviders>(response);
        }

        /// <summary>
        /// Test V1DataProvidersIdGet
        /// </summary>
        [Fact]
        public void V1DataProvidersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.V1DataProvidersIdGet(id);
            //Assert.IsType<DataProviderDetails>(response);
        }
    }
}