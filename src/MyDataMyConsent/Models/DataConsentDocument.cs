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
    /// Data Consent document details.
    /// </summary>
    [DataContract(Name = "DataConsentDocument")]
    public partial class DataConsentDocument : IEquatable<DataConsentDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataConsentDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentDocument" /> class.
        /// </summary>
        /// <param name="id">Document id. (required).</param>
        /// <param name="name">Document name. (required).</param>
        /// <param name="category">Document category. (required).</param>
        /// <param name="identifier">Document identifier. (required).</param>
        /// <param name="fieldTitle">Document field title. (required).</param>
        /// <param name="fieldSlug">Document field slug. (required).</param>
        /// <param name="issuedAtUtc">Document issued at datetime in UTC timezone. (required).</param>
        /// <param name="expiresAtUtc">Document expires at datetime in UTC timezone..</param>
        /// <param name="issuer">issuer (required).</param>
        /// <param name="digitalSignatures">Digital signatures. (required).</param>
        public DataConsentDocument(string id = default(string), string name = default(string), string category = default(string), string identifier = default(string), string fieldTitle = default(string), string fieldSlug = default(string), DateTime issuedAtUtc = default(DateTime), DateTime? expiresAtUtc = default(DateTime?), DataConsentDocumentIssuer issuer = default(DataConsentDocumentIssuer), List<DocumentDigitalSignature> digitalSignatures = default(List<DocumentDigitalSignature>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DataConsentDocument and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DataConsentDocument and cannot be null");
            }
            this.Name = name;
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for DataConsentDocument and cannot be null");
            }
            this.Category = category;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for DataConsentDocument and cannot be null");
            }
            this.Identifier = identifier;
            // to ensure "fieldTitle" is required (not null)
            if (fieldTitle == null)
            {
                throw new ArgumentNullException("fieldTitle is a required property for DataConsentDocument and cannot be null");
            }
            this.FieldTitle = fieldTitle;
            // to ensure "fieldSlug" is required (not null)
            if (fieldSlug == null)
            {
                throw new ArgumentNullException("fieldSlug is a required property for DataConsentDocument and cannot be null");
            }
            this.FieldSlug = fieldSlug;
            this.IssuedAtUtc = issuedAtUtc;
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new ArgumentNullException("issuer is a required property for DataConsentDocument and cannot be null");
            }
            this.Issuer = issuer;
            // to ensure "digitalSignatures" is required (not null)
            if (digitalSignatures == null)
            {
                throw new ArgumentNullException("digitalSignatures is a required property for DataConsentDocument and cannot be null");
            }
            this.DigitalSignatures = digitalSignatures;
            this.ExpiresAtUtc = expiresAtUtc;
        }

        /// <summary>
        /// Document id.
        /// </summary>
        /// <value>Document id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Document name.
        /// </summary>
        /// <value>Document name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Document category.
        /// </summary>
        /// <value>Document category.</value>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        /// <value>Document identifier.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Document field title.
        /// </summary>
        /// <value>Document field title.</value>
        [DataMember(Name = "fieldTitle", IsRequired = true, EmitDefaultValue = false)]
        public string FieldTitle { get; set; }

        /// <summary>
        /// Document field slug.
        /// </summary>
        /// <value>Document field slug.</value>
        [DataMember(Name = "fieldSlug", IsRequired = true, EmitDefaultValue = false)]
        public string FieldSlug { get; set; }

        /// <summary>
        /// Document issued at datetime in UTC timezone.
        /// </summary>
        /// <value>Document issued at datetime in UTC timezone.</value>
        [DataMember(Name = "issuedAtUtc", IsRequired = true, EmitDefaultValue = false)]
        public DateTime IssuedAtUtc { get; set; }

        /// <summary>
        /// Document expires at datetime in UTC timezone.
        /// </summary>
        /// <value>Document expires at datetime in UTC timezone.</value>
        [DataMember(Name = "expiresAtUtc", EmitDefaultValue = true)]
        public DateTime? ExpiresAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", IsRequired = true, EmitDefaultValue = false)]
        public DataConsentDocumentIssuer Issuer { get; set; }

        /// <summary>
        /// Digital signatures.
        /// </summary>
        /// <value>Digital signatures.</value>
        [DataMember(Name = "digitalSignatures", IsRequired = true, EmitDefaultValue = false)]
        public List<DocumentDigitalSignature> DigitalSignatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataConsentDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  FieldTitle: ").Append(FieldTitle).Append("\n");
            sb.Append("  FieldSlug: ").Append(FieldSlug).Append("\n");
            sb.Append("  IssuedAtUtc: ").Append(IssuedAtUtc).Append("\n");
            sb.Append("  ExpiresAtUtc: ").Append(ExpiresAtUtc).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  DigitalSignatures: ").Append(DigitalSignatures).Append("\n");
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
            return this.Equals(input as DataConsentDocument);
        }

        /// <summary>
        /// Returns true if DataConsentDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentDocument input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.FieldTitle == input.FieldTitle ||
                    (this.FieldTitle != null &&
                    this.FieldTitle.Equals(input.FieldTitle))
                ) && 
                (
                    this.FieldSlug == input.FieldSlug ||
                    (this.FieldSlug != null &&
                    this.FieldSlug.Equals(input.FieldSlug))
                ) && 
                (
                    this.IssuedAtUtc == input.IssuedAtUtc ||
                    (this.IssuedAtUtc != null &&
                    this.IssuedAtUtc.Equals(input.IssuedAtUtc))
                ) && 
                (
                    this.ExpiresAtUtc == input.ExpiresAtUtc ||
                    (this.ExpiresAtUtc != null &&
                    this.ExpiresAtUtc.Equals(input.ExpiresAtUtc))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.DigitalSignatures == input.DigitalSignatures ||
                    this.DigitalSignatures != null &&
                    input.DigitalSignatures != null &&
                    this.DigitalSignatures.SequenceEqual(input.DigitalSignatures)
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.FieldTitle != null)
                {
                    hashCode = (hashCode * 59) + this.FieldTitle.GetHashCode();
                }
                if (this.FieldSlug != null)
                {
                    hashCode = (hashCode * 59) + this.FieldSlug.GetHashCode();
                }
                if (this.IssuedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedAtUtc.GetHashCode();
                }
                if (this.ExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAtUtc.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.DigitalSignatures != null)
                {
                    hashCode = (hashCode * 59) + this.DigitalSignatures.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}