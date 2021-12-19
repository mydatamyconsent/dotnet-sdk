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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.mydatamyconsent.Client.OpenAPIDateConverter;

namespace com.mydatamyconsent.Model
{
    /// <summary>
    /// Defines DataFetchFrequencyUnit
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataFetchFrequencyUnit
    {
        /// <summary>
        /// Enum Hourly for value: Hourly
        /// </summary>
        [EnumMember(Value = "Hourly")]
        Hourly = 1,

        /// <summary>
        /// Enum Daily for value: Daily
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily = 2,

        /// <summary>
        /// Enum Monthly for value: Monthly
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly = 3,

        /// <summary>
        /// Enum Yearly for value: Yearly
        /// </summary>
        [EnumMember(Value = "Yearly")]
        Yearly = 4,

        /// <summary>
        /// Enum Unlimited for value: Unlimited
        /// </summary>
        [EnumMember(Value = "Unlimited")]
        Unlimited = 5

    }

}
