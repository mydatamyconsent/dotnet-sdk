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
    /// Defines MutualFundSchemeOption
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MutualFundSchemeOption
    {
        /// <summary>
        /// Enum Reinvest for value: Reinvest
        /// </summary>
        [EnumMember(Value = "Reinvest")]
        Reinvest = 1,

        /// <summary>
        /// Enum Payout for value: Payout
        /// </summary>
        [EnumMember(Value = "Payout")]
        Payout = 2,

        /// <summary>
        /// Enum GrowthType for value: GrowthType
        /// </summary>
        [EnumMember(Value = "GrowthType")]
        GrowthType = 3

    }

}
