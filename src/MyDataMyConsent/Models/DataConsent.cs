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
    /// Data Consent details.
    /// </summary>
    [DataContract(Name = "DataConsent")]
    public partial class DataConsent : IEquatable<DataConsent>
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public DataConsentStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataConsent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsent" /> class.
        /// </summary>
        /// <param name="id">Data consent id. (required).</param>
        /// <param name="requestId">Data consent request id. (required).</param>
        /// <param name="templateId">Consent template id..</param>
        /// <param name="title">Consent title. (required).</param>
        /// <param name="description">Consent description. (required).</param>
        /// <param name="purpose">Consent purpose..</param>
        /// <param name="status">status (required).</param>
        /// <param name="transactionId">Transaction id..</param>
        /// <param name="approvedAtUtc">Consent approval datetime in UTC timezone. (required).</param>
        /// <param name="dataAccessExpiresAtUtc">Data access expiration datetime in UTC timezone. (required).</param>
        /// <param name="revokedAtUtc">Consent revocation datetime in UTC timezone..</param>
        /// <param name="collectables">List of supported collectible types. (required).</param>
        /// <param name="identifiers">Consented identity details..</param>
        /// <param name="documents">List of consented documents..</param>
        public DataConsent(Guid id = default(Guid), Guid requestId = default(Guid), Guid? templateId = default(Guid?), string title = default(string), string description = default(string), string purpose = default(string), DataConsentStatus status = default(DataConsentStatus), string transactionId = default(string), DateTime approvedAtUtc = default(DateTime), DateTime dataAccessExpiresAtUtc = default(DateTime), DateTime? revokedAtUtc = default(DateTime?), List<CollectibleTypes> collectables = default(List<CollectibleTypes>), Object identifiers = default(Object), List<DataConsentDocument> documents = default(List<DataConsentDocument>))
        {
            this.Id = id;
            this.RequestId = requestId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for DataConsent and cannot be null");
            }
            this.Title = title;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for DataConsent and cannot be null");
            }
            this.Description = description;
            this.Status = status;
            this.ApprovedAtUtc = approvedAtUtc;
            this.DataAccessExpiresAtUtc = dataAccessExpiresAtUtc;
            // to ensure "collectables" is required (not null)
            if (collectables == null)
            {
                throw new ArgumentNullException("collectables is a required property for DataConsent and cannot be null");
            }
            this.Collectables = collectables;
            this.TemplateId = templateId;
            this.Purpose = purpose;
            this.TransactionId = transactionId;
            this.RevokedAtUtc = revokedAtUtc;
            this.Identifiers = identifiers;
            this.Documents = documents;
        }

        /// <summary>
        /// Data consent id.
        /// </summary>
        /// <value>Data consent id.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Data consent request id.
        /// </summary>
        /// <value>Data consent request id.</value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = false)]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Consent template id.
        /// </summary>
        /// <value>Consent template id.</value>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// Consent title.
        /// </summary>
        /// <value>Consent title.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Consent description.
        /// </summary>
        /// <value>Consent description.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Consent purpose.
        /// </summary>
        /// <value>Consent purpose.</value>
        [DataMember(Name = "purpose", EmitDefaultValue = true)]
        public string Purpose { get; set; }

        /// <summary>
        /// Transaction id.
        /// </summary>
        /// <value>Transaction id.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Consent approval datetime in UTC timezone.
        /// </summary>
        /// <value>Consent approval datetime in UTC timezone.</value>
        [DataMember(Name = "approvedAtUtc", IsRequired = true, EmitDefaultValue = false)]
        public DateTime ApprovedAtUtc { get; set; }

        /// <summary>
        /// Data access expiration datetime in UTC timezone.
        /// </summary>
        /// <value>Data access expiration datetime in UTC timezone.</value>
        [DataMember(Name = "dataAccessExpiresAtUtc", IsRequired = true, EmitDefaultValue = false)]
        public DateTime DataAccessExpiresAtUtc { get; set; }

        /// <summary>
        /// Consent revocation datetime in UTC timezone.
        /// </summary>
        /// <value>Consent revocation datetime in UTC timezone.</value>
        [DataMember(Name = "revokedAtUtc", EmitDefaultValue = true)]
        public DateTime? RevokedAtUtc { get; set; }

        /// <summary>
        /// List of supported collectible types.
        /// </summary>
        /// <value>List of supported collectible types.</value>
        [DataMember(Name = "collectables", IsRequired = true, EmitDefaultValue = false)]
        public List<CollectibleTypes> Collectables { get; set; }

        /// <summary>
        /// Consented identity details.
        /// </summary>
        /// <value>Consented identity details.</value>
        [DataMember(Name = "identifiers", EmitDefaultValue = true)]
        public Object Identifiers { get; set; }

        /// <summary>
        /// List of consented documents.
        /// </summary>
        /// <value>List of consented documents.</value>
        [DataMember(Name = "documents", EmitDefaultValue = true)]
        public List<DataConsentDocument> Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataConsent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ApprovedAtUtc: ").Append(ApprovedAtUtc).Append("\n");
            sb.Append("  DataAccessExpiresAtUtc: ").Append(DataAccessExpiresAtUtc).Append("\n");
            sb.Append("  RevokedAtUtc: ").Append(RevokedAtUtc).Append("\n");
            sb.Append("  Collectables: ").Append(Collectables).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return this.Equals(input as DataConsent);
        }

        /// <summary>
        /// Returns true if DataConsent instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsent input)
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
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.ApprovedAtUtc == input.ApprovedAtUtc ||
                    (this.ApprovedAtUtc != null &&
                    this.ApprovedAtUtc.Equals(input.ApprovedAtUtc))
                ) && 
                (
                    this.DataAccessExpiresAtUtc == input.DataAccessExpiresAtUtc ||
                    (this.DataAccessExpiresAtUtc != null &&
                    this.DataAccessExpiresAtUtc.Equals(input.DataAccessExpiresAtUtc))
                ) && 
                (
                    this.RevokedAtUtc == input.RevokedAtUtc ||
                    (this.RevokedAtUtc != null &&
                    this.RevokedAtUtc.Equals(input.RevokedAtUtc))
                ) && 
                (
                    this.Collectables == input.Collectables ||
                    this.Collectables != null &&
                    input.Collectables != null &&
                    this.Collectables.SequenceEqual(input.Collectables)
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    (this.Identifiers != null &&
                    this.Identifiers.Equals(input.Identifiers))
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
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
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Purpose != null)
                {
                    hashCode = (hashCode * 59) + this.Purpose.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.ApprovedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovedAtUtc.GetHashCode();
                }
                if (this.DataAccessExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.DataAccessExpiresAtUtc.GetHashCode();
                }
                if (this.RevokedAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.RevokedAtUtc.GetHashCode();
                }
                if (this.Collectables != null)
                {
                    hashCode = (hashCode * 59) + this.Collectables.GetHashCode();
                }
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.Documents != null)
                {
                    hashCode = (hashCode * 59) + this.Documents.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}