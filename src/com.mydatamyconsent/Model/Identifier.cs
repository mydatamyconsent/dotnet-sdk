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
    /// Defines Identifier
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Identifier
    {
        /// <summary>
        /// Enum Email for value: Email
        /// </summary>
        [EnumMember(Value = "Email")]
        Email = 1,

        /// <summary>
        /// Enum PermanentAccountNumber for value: PermanentAccountNumber
        /// </summary>
        [EnumMember(Value = "PermanentAccountNumber")]
        PermanentAccountNumber = 2,

        /// <summary>
        /// Enum AadhaarNumber for value: AadhaarNumber
        /// </summary>
        [EnumMember(Value = "AadhaarNumber")]
        AadhaarNumber = 3,

        /// <summary>
        /// Enum MobileNumber for value: MobileNumber
        /// </summary>
        [EnumMember(Value = "MobileNumber")]
        MobileNumber = 4,

        /// <summary>
        /// Enum CorporateIdentificationNumber for value: CorporateIdentificationNumber
        /// </summary>
        [EnumMember(Value = "CorporateIdentificationNumber")]
        CorporateIdentificationNumber = 5,

        /// <summary>
        /// Enum TaxDeductionAccountNumber for value: TaxDeductionAccountNumber
        /// </summary>
        [EnumMember(Value = "TaxDeductionAccountNumber")]
        TaxDeductionAccountNumber = 6,

        /// <summary>
        /// Enum GoodsAndServicesTaxIdentificationNumber for value: GoodsAndServicesTaxIdentificationNumber
        /// </summary>
        [EnumMember(Value = "GoodsAndServicesTaxIdentificationNumber")]
        GoodsAndServicesTaxIdentificationNumber = 7

    }

}
