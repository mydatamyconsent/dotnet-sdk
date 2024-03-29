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
using OpenAPIDateConverter = MyDataMyConsent.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Models
{
    /// <summary>
    /// Defines MutualFundFundType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MutualFundFundType
    {
        /// <summary>
        /// Enum Equity for value: Equity
        /// </summary>
        [EnumMember(Value = "Equity")]
        Equity = 1,

        /// <summary>
        /// Enum Debt for value: Debt
        /// </summary>
        [EnumMember(Value = "Debt")]
        Debt = 2,

        /// <summary>
        /// Enum Hybrid for value: Hybrid
        /// </summary>
        [EnumMember(Value = "Hybrid")]
        Hybrid = 3,

        /// <summary>
        /// Enum SolutionOrientedSchemes for value: SolutionOrientedSchemes
        /// </summary>
        [EnumMember(Value = "SolutionOrientedSchemes")]
        SolutionOrientedSchemes = 4,

        /// <summary>
        /// Enum Others for value: Others
        /// </summary>
        [EnumMember(Value = "Others")]
        Others = 5

    }

}
