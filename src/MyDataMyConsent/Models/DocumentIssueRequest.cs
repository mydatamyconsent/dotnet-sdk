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
    /// DocumentIssueRequest : Document Issue Request.
    /// </summary>
    [DataContract(Name = "DocumentIssueRequest")]
    public partial class DocumentIssueRequest : IEquatable<DocumentIssueRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIssueRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentIssueRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIssueRequest" /> class.
        /// </summary>
        /// <param name="documentTypeId">Document type id. (required).</param>
        /// <param name="identifier">Document identifier. (required).</param>
        /// <param name="description">Document description. (required).</param>
        /// <param name="receiver">receiver (required).</param>
        /// <param name="paymentRequest">paymentRequest.</param>
        /// <param name="issuedAtUtc">Datetime of issue in UTC timezone. (required).</param>
        /// <param name="validFromUtc">Valid from datetime in UTC timezone. (required).</param>
        /// <param name="expiresAtUtc">Datetime of expiry in UTC timezone..</param>
        /// <param name="metadata">Metadata..</param>
        public DocumentIssueRequest(string documentTypeId = default(string), string identifier = default(string), string description = default(string), DocumentIssueRequestReceiver receiver = default(DocumentIssueRequestReceiver), DocumentIssueRequestPaymentRequest paymentRequest = default(DocumentIssueRequestPaymentRequest), DateTime issuedAtUtc = default(DateTime), DateTime validFromUtc = default(DateTime), DateTime expiresAtUtc = default(DateTime), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            // to ensure "documentTypeId" is required (not null)
            if (documentTypeId == null)
            {
                throw new ArgumentNullException("documentTypeId is a required property for DocumentIssueRequest and cannot be null");
            }
            this.DocumentTypeId = documentTypeId;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for DocumentIssueRequest and cannot be null");
            }
            this.Identifier = identifier;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for DocumentIssueRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "receiver" is required (not null)
            if (receiver == null)
            {
                throw new ArgumentNullException("receiver is a required property for DocumentIssueRequest and cannot be null");
            }
            this.Receiver = receiver;
            this.IssuedAtUtc = issuedAtUtc;
            this.ValidFromUtc = validFromUtc;
            this.PaymentRequest = paymentRequest;
            this.ExpiresAtUtc = expiresAtUtc;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Document type id.
        /// </summary>
        /// <value>Document type id.</value>
        [DataMember(Name = "documentTypeId", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentTypeId { get; set; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        /// <value>Document identifier.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Document description.
        /// </summary>
        /// <value>Document description.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = true)]
        public DocumentIssueRequestReceiver Receiver { get; set; }

        /// <summary>
        /// Gets or Sets PaymentRequest
        /// </summary>
        [DataMember(Name = "paymentRequest", EmitDefaultValue = false)]
        public DocumentIssueRequestPaymentRequest PaymentRequest { get; set; }

        /// <summary>
        /// Datetime of issue in UTC timezone.
        /// </summary>
        /// <value>Datetime of issue in UTC timezone.</value>
        [DataMember(Name = "issuedAtUtc", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IssuedAtUtc { get; set; }

        /// <summary>
        /// Valid from datetime in UTC timezone.
        /// </summary>
        /// <value>Valid from datetime in UTC timezone.</value>
        [DataMember(Name = "validFromUtc", IsRequired = true, EmitDefaultValue = true)]
        public DateTime ValidFromUtc { get; set; }

        /// <summary>
        /// Datetime of expiry in UTC timezone.
        /// </summary>
        /// <value>Datetime of expiry in UTC timezone.</value>
        [DataMember(Name = "expiresAtUtc", EmitDefaultValue = false)]
        public DateTime ExpiresAtUtc { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        /// <value>Metadata.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentIssueRequest {\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  PaymentRequest: ").Append(PaymentRequest).Append("\n");
            sb.Append("  IssuedAtUtc: ").Append(IssuedAtUtc).Append("\n");
            sb.Append("  ValidFromUtc: ").Append(ValidFromUtc).Append("\n");
            sb.Append("  ExpiresAtUtc: ").Append(ExpiresAtUtc).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as DocumentIssueRequest);
        }

        /// <summary>
        /// Returns true if DocumentIssueRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentIssueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentIssueRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.PaymentRequest == input.PaymentRequest ||
                    (this.PaymentRequest != null &&
                    this.PaymentRequest.Equals(input.PaymentRequest))
                ) && 
                (
                    this.IssuedAtUtc == input.IssuedAtUtc ||
                    (this.IssuedAtUtc != null &&
                    this.IssuedAtUtc.Equals(input.IssuedAtUtc))
                ) && 
                (
                    this.ValidFromUtc == input.ValidFromUtc ||
                    (this.ValidFromUtc != null &&
                    this.ValidFromUtc.Equals(input.ValidFromUtc))
                ) && 
                (
                    this.ExpiresAtUtc == input.ExpiresAtUtc ||
                    (this.ExpiresAtUtc != null &&
                    this.ExpiresAtUtc.Equals(input.ExpiresAtUtc))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.DocumentTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentTypeId.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.PaymentRequest != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentRequest.GetHashCode();
                }
                if (this.IssuedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedAtUtc.GetHashCode();
                }
                if (this.ValidFromUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFromUtc.GetHashCode();
                }
                if (this.ExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAtUtc.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
