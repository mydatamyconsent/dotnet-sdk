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
using OpenAPIDateConverter = MyDataMyConsent.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Models
{
    /// <summary>
    /// Defines Operator
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Operator
    {
        /// <summary>
        /// Enum EqualTo for value: EqualTo
        /// </summary>
        [EnumMember(Value = "EqualTo")]
        EqualTo = 1,

        /// <summary>
        /// Enum NotEqualto for value: NotEqualto
        /// </summary>
        [EnumMember(Value = "NotEqualto")]
        NotEqualto = 2,

        /// <summary>
        /// Enum TextContains for value: TextContains
        /// </summary>
        [EnumMember(Value = "TextContains")]
        TextContains = 3,

        /// <summary>
        /// Enum GreaterThan for value: GreaterThan
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        GreaterThan = 4,

        /// <summary>
        /// Enum LessThan for value: LessThan
        /// </summary>
        [EnumMember(Value = "LessThan")]
        LessThan = 5,

        /// <summary>
        /// Enum GreaterThanOrEqualTo for value: GreaterThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "GreaterThanOrEqualTo")]
        GreaterThanOrEqualTo = 6,

        /// <summary>
        /// Enum LessThanOrEqualTo for value: LessThanOrEqualTo
        /// </summary>
        [EnumMember(Value = "LessThanOrEqualTo")]
        LessThanOrEqualTo = 7

    }

}