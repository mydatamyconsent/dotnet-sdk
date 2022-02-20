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
using OpenAPIDateConverter = MyDataMyConsent.Sdk.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Sdk.Models
{
    /// <summary>
    /// DataConsentRequesterDto
    /// </summary>
    [DataContract(Name = "DataConsentRequesterDto")]
    public partial class DataConsentRequesterDto : IEquatable<DataConsentRequesterDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentRequesterDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="description">description.</param>
        /// <param name="website">website.</param>
        /// <param name="supportEmail">supportEmail.</param>
        /// <param name="helpLineNumber">helpLineNumber.</param>
        public DataConsentRequesterDto(string? name = default(string?), string? logoUrl = default(string?), string? description = default(string?), string? website = default(string?), string? supportEmail = default(string?), string? helpLineNumber = default(string?))
        {
            this.Name = name;
            this.LogoUrl = logoUrl;
            this.Description = description;
            this.Website = website;
            this.SupportEmail = supportEmail;
            this.HelpLineNumber = helpLineNumber;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logoUrl", EmitDefaultValue = true)]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        public string? Website { get; set; }

        /// <summary>
        /// Gets or Sets SupportEmail
        /// </summary>
        [DataMember(Name = "supportEmail", EmitDefaultValue = true)]
        public string? SupportEmail { get; set; }

        /// <summary>
        /// Gets or Sets HelpLineNumber
        /// </summary>
        [DataMember(Name = "helpLineNumber", EmitDefaultValue = true)]
        public string? HelpLineNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataConsentRequesterDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
            sb.Append("  HelpLineNumber: ").Append(HelpLineNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataConsentRequesterDto);
        }

        /// <summary>
        /// Returns true if DataConsentRequesterDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentRequesterDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentRequesterDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.SupportEmail == input.SupportEmail ||
                    (this.SupportEmail != null &&
                    this.SupportEmail.Equals(input.SupportEmail))
                ) && 
                (
                    this.HelpLineNumber == input.HelpLineNumber ||
                    (this.HelpLineNumber != null &&
                    this.HelpLineNumber.Equals(input.HelpLineNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.SupportEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SupportEmail.GetHashCode();
                }
                if (this.HelpLineNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HelpLineNumber.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
