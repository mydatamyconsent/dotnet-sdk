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
    /// IssuedDocumentDetails
    /// </summary>
    [DataContract(Name = "IssuedDocumentDetails")]
    public partial class IssuedDocumentDetails : IEquatable<IssuedDocumentDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuedDocumentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuedDocumentDetails" /> class.
        /// </summary>
        /// <param name="id">Document Id. (required).</param>
        /// <param name="identifier">Document Identifier. (required).</param>
        /// <param name="documentType">Document type name. (required).</param>
        /// <param name="issuedTo">User name. (required).</param>
        /// <param name="issuedAtUtc">Issued datetime in UTC timezone. (required).</param>
        /// <param name="expiresAtUtc">Expires datetime in UTC timezone..</param>
        /// <param name="acceptedAtUtc">Accepted datetime in UTC timezone..</param>
        /// <param name="receiver">receiver (required).</param>
        /// <param name="metadata">Metadata..</param>
        /// <param name="digitalSignatures">Digital signatures. (required).</param>
        public IssuedDocumentDetails(Guid id = default(Guid), string identifier = default(string), string documentType = default(string), string issuedTo = default(string), DateTime issuedAtUtc = default(DateTime), DateTime? expiresAtUtc = default(DateTime?), DateTime? acceptedAtUtc = default(DateTime?), DocumentReceiver receiver = default(DocumentReceiver), Dictionary<string, string> metadata = default(Dictionary<string, string>), List<DocumentDigitalSignature> digitalSignatures = default(List<DocumentDigitalSignature>))
        {
            this.Id = id;
            this.Identifier = identifier;
            this.DocumentType = documentType;
            this.IssuedTo = issuedTo;
            this.IssuedAtUtc = issuedAtUtc;
            // to ensure "receiver" is required (not null)
            if (receiver == null) {
                throw new ArgumentNullException("receiver is a required property for IssuedDocumentDetails and cannot be null");
            }
            this.Receiver = receiver;
            // to ensure "digitalSignatures" is required (not null)
            if (digitalSignatures == null) {
                throw new ArgumentNullException("digitalSignatures is a required property for IssuedDocumentDetails and cannot be null");
            }
            this.DigitalSignatures = digitalSignatures;
            this.ExpiresAtUtc = expiresAtUtc;
            this.AcceptedAtUtc = acceptedAtUtc;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Document Id.
        /// </summary>
        /// <value>Document Id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Document Identifier.
        /// </summary>
        /// <value>Document Identifier.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Document type name.
        /// </summary>
        /// <value>Document type name.</value>
        [DataMember(Name = "documentType", IsRequired = true, EmitDefaultValue = false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        /// <value>User name.</value>
        [DataMember(Name = "issuedTo", IsRequired = true, EmitDefaultValue = false)]
        public string IssuedTo { get; set; }

        /// <summary>
        /// Issued datetime in UTC timezone.
        /// </summary>
        /// <value>Issued datetime in UTC timezone.</value>
        [DataMember(Name = "issuedAtUtc", IsRequired = true, EmitDefaultValue = false)]
        public DateTime IssuedAtUtc { get; set; }

        /// <summary>
        /// Expires datetime in UTC timezone.
        /// </summary>
        /// <value>Expires datetime in UTC timezone.</value>
        [DataMember(Name = "expiresAtUtc", EmitDefaultValue = true)]
        public DateTime? ExpiresAtUtc { get; set; }

        /// <summary>
        /// Accepted datetime in UTC timezone.
        /// </summary>
        /// <value>Accepted datetime in UTC timezone.</value>
        [DataMember(Name = "acceptedAtUtc", EmitDefaultValue = true)]
        public DateTime? AcceptedAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = false)]
        public DocumentReceiver Receiver { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        /// <value>Metadata.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, string> Metadata { get; set; }

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
            sb.Append("class IssuedDocumentDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  IssuedTo: ").Append(IssuedTo).Append("\n");
            sb.Append("  IssuedAtUtc: ").Append(IssuedAtUtc).Append("\n");
            sb.Append("  ExpiresAtUtc: ").Append(ExpiresAtUtc).Append("\n");
            sb.Append("  AcceptedAtUtc: ").Append(AcceptedAtUtc).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as IssuedDocumentDetails);
        }

        /// <summary>
        /// Returns true if IssuedDocumentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of IssuedDocumentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuedDocumentDetails input)
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
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.IssuedTo == input.IssuedTo ||
                    (this.IssuedTo != null &&
                    this.IssuedTo.Equals(input.IssuedTo))
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
                    this.AcceptedAtUtc == input.AcceptedAtUtc ||
                    (this.AcceptedAtUtc != null &&
                    this.AcceptedAtUtc.Equals(input.AcceptedAtUtc))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.DocumentType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                }
                if (this.IssuedTo != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedTo.GetHashCode();
                }
                if (this.IssuedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedAtUtc.GetHashCode();
                }
                if (this.ExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAtUtc.GetHashCode();
                }
                if (this.AcceptedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptedAtUtc.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
