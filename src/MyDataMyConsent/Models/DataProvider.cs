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
    /// DataProvider
    /// </summary>
    [DataContract(Name = "DataProvider")]
    public partial class DataProvider : IEquatable<DataProvider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataProvider" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="website">website.</param>
        /// <param name="email">email.</param>
        /// <param name="supportPhoneNumber">supportPhoneNumber.</param>
        /// <param name="privacyPolicy">privacyPolicy.</param>
        /// <param name="termOfService">termOfService.</param>
        /// <param name="category">category.</param>
        /// <param name="dataProtectionOfficer">dataProtectionOfficer.</param>
        /// <param name="supportedAccountTypes">supportedAccountTypes.</param>
        /// <param name="supportedDocumentTypes">supportedDocumentTypes.</param>
        public DataProvider(string id = default(string), string name = default(string), string logoUrl = default(string), string website = default(string), string email = default(string), string supportPhoneNumber = default(string), string privacyPolicy = default(string), string termOfService = default(string), string category = default(string), DataProtectionOfficer dataProtectionOfficer = default(DataProtectionOfficer), List<string> supportedAccountTypes = default(List<string>), List<string> supportedDocumentTypes = default(List<string>))
        {
            this.Id = id;
            this.Name = name;
            this.LogoUrl = logoUrl;
            this.Website = website;
            this.Email = email;
            this.SupportPhoneNumber = supportPhoneNumber;
            this.PrivacyPolicy = privacyPolicy;
            this.TermOfService = termOfService;
            this.Category = category;
            this.DataProtectionOfficer = dataProtectionOfficer;
            this.SupportedAccountTypes = supportedAccountTypes;
            this.SupportedDocumentTypes = supportedDocumentTypes;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logoUrl", EmitDefaultValue = true)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = true)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets SupportPhoneNumber
        /// </summary>
        [DataMember(Name = "supportPhoneNumber", EmitDefaultValue = true)]
        public string SupportPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicy
        /// </summary>
        [DataMember(Name = "privacyPolicy", EmitDefaultValue = true)]
        public string PrivacyPolicy { get; set; }

        /// <summary>
        /// Gets or Sets TermOfService
        /// </summary>
        [DataMember(Name = "termOfService", EmitDefaultValue = true)]
        public string TermOfService { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets DataProtectionOfficer
        /// </summary>
        [DataMember(Name = "dataProtectionOfficer", EmitDefaultValue = false)]
        public DataProtectionOfficer DataProtectionOfficer { get; set; }

        /// <summary>
        /// Gets or Sets SupportedAccountTypes
        /// </summary>
        [DataMember(Name = "supportedAccountTypes", EmitDefaultValue = true)]
        public List<string> SupportedAccountTypes { get; set; }

        /// <summary>
        /// Gets or Sets SupportedDocumentTypes
        /// </summary>
        [DataMember(Name = "supportedDocumentTypes", EmitDefaultValue = true)]
        public List<string> SupportedDocumentTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataProvider {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SupportPhoneNumber: ").Append(SupportPhoneNumber).Append("\n");
            sb.Append("  PrivacyPolicy: ").Append(PrivacyPolicy).Append("\n");
            sb.Append("  TermOfService: ").Append(TermOfService).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DataProtectionOfficer: ").Append(DataProtectionOfficer).Append("\n");
            sb.Append("  SupportedAccountTypes: ").Append(SupportedAccountTypes).Append("\n");
            sb.Append("  SupportedDocumentTypes: ").Append(SupportedDocumentTypes).Append("\n");
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
            return this.Equals(input as DataProvider);
        }

        /// <summary>
        /// Returns true if DataProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of DataProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SupportPhoneNumber == input.SupportPhoneNumber ||
                    (this.SupportPhoneNumber != null &&
                    this.SupportPhoneNumber.Equals(input.SupportPhoneNumber))
                ) && 
                (
                    this.PrivacyPolicy == input.PrivacyPolicy ||
                    (this.PrivacyPolicy != null &&
                    this.PrivacyPolicy.Equals(input.PrivacyPolicy))
                ) && 
                (
                    this.TermOfService == input.TermOfService ||
                    (this.TermOfService != null &&
                    this.TermOfService.Equals(input.TermOfService))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.DataProtectionOfficer == input.DataProtectionOfficer ||
                    (this.DataProtectionOfficer != null &&
                    this.DataProtectionOfficer.Equals(input.DataProtectionOfficer))
                ) && 
                (
                    this.SupportedAccountTypes == input.SupportedAccountTypes ||
                    this.SupportedAccountTypes != null &&
                    input.SupportedAccountTypes != null &&
                    this.SupportedAccountTypes.SequenceEqual(input.SupportedAccountTypes)
                ) && 
                (
                    this.SupportedDocumentTypes == input.SupportedDocumentTypes ||
                    this.SupportedDocumentTypes != null &&
                    input.SupportedDocumentTypes != null &&
                    this.SupportedDocumentTypes.SequenceEqual(input.SupportedDocumentTypes)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.SupportPhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SupportPhoneNumber.GetHashCode();
                }
                if (this.PrivacyPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PrivacyPolicy.GetHashCode();
                }
                if (this.TermOfService != null)
                {
                    hashCode = (hashCode * 59) + this.TermOfService.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.DataProtectionOfficer != null)
                {
                    hashCode = (hashCode * 59) + this.DataProtectionOfficer.GetHashCode();
                }
                if (this.SupportedAccountTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedAccountTypes.GetHashCode();
                }
                if (this.SupportedDocumentTypes != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedDocumentTypes.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}