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
    /// Defines IdentificationStrategy
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentificationStrategy
    {
        /// <summary>
        /// Enum MatchAtLeastOneIdentifier for value: MatchAtLeastOneIdentifier
        /// </summary>
        [EnumMember(Value = "MatchAtLeastOneIdentifier")]
        MatchAtLeastOneIdentifier = 1,

        /// <summary>
        /// Enum MatchAnyTwoIdentifiers for value: MatchAnyTwoIdentifiers
        /// </summary>
        [EnumMember(Value = "MatchAnyTwoIdentifiers")]
        MatchAnyTwoIdentifiers = 2,

        /// <summary>
        /// Enum MatchAllIdentifiers for value: MatchAllIdentifiers
        /// </summary>
        [EnumMember(Value = "MatchAllIdentifiers")]
        MatchAllIdentifiers = 3

    }

}
