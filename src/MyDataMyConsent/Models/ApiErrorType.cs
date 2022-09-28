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
    /// Defines ApiErrorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApiErrorType
    {
        /// <summary>
        /// Enum Unauthorized for value: Unauthorized
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized = 1,

        /// <summary>
        /// Enum TooManyRequests for value: TooManyRequests
        /// </summary>
        [EnumMember(Value = "TooManyRequests")]
        TooManyRequests = 2,

        /// <summary>
        /// Enum BadRequest for value: BadRequest
        /// </summary>
        [EnumMember(Value = "BadRequest")]
        BadRequest = 3,

        /// <summary>
        /// Enum NotFound for value: NotFound
        /// </summary>
        [EnumMember(Value = "NotFound")]
        NotFound = 4,

        /// <summary>
        /// Enum InternalServerError for value: InternalServerError
        /// </summary>
        [EnumMember(Value = "InternalServerError")]
        InternalServerError = 5,

        /// <summary>
        /// Enum DataConsentRequestExists for value: DataConsentRequestExists
        /// </summary>
        [EnumMember(Value = "DataConsentRequestExists")]
        DataConsentRequestExists = 6

    }

}