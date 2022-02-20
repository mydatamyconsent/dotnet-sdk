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
    /// UserDocumentDetailsDto
    /// </summary>
    [DataContract(Name = "UserDocumentDetailsDto")]
    public partial class UserDocumentDetailsDto : IEquatable<UserDocumentDetailsDto>
    {

        /// <summary>
        /// Gets or Sets CategoryType
        /// </summary>
        [DataMember(Name = "categoryType", EmitDefaultValue = false)]
        public DocumentCategoryType? CategoryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDocumentDetailsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="categoryType">categoryType.</param>
        /// <param name="typeId">typeId.</param>
        /// <param name="typeName">typeName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="issuerName">issuerName.</param>
        /// <param name="storageUrl">storageUrl.</param>
        /// <param name="isQuickAccessEnabled">isQuickAccessEnabled.</param>
        /// <param name="isOwner">isOwner.</param>
        /// <param name="digitalSignatureDetails">digitalSignatureDetails.</param>
        /// <param name="ownerId">ownerId.</param>
        public UserDocumentDetailsDto(Guid id = default(Guid), DocumentCategoryType? categoryType = default(DocumentCategoryType?), Guid typeId = default(Guid), string? typeName = default(string?), string? fullName = default(string?), string? identifier = default(string?), Guid? accountId = default(Guid?), Guid issuerId = default(Guid), string? issuerName = default(string?), string? storageUrl = default(string?), bool isQuickAccessEnabled = default(bool), bool isOwner = default(bool), List<DigitalSignature> digitalSignatureDetails = default(List<DigitalSignature>), Guid ownerId = default(Guid))
        {
            this.Id = id;
            this.CategoryType = categoryType;
            this.TypeId = typeId;
            this.TypeName = typeName;
            this.FullName = fullName;
            this.Identifier = identifier;
            this.AccountId = accountId;
            this.IssuerId = issuerId;
            this.IssuerName = issuerName;
            this.StorageUrl = storageUrl;
            this.IsQuickAccessEnabled = isQuickAccessEnabled;
            this.IsOwner = isOwner;
            this.DigitalSignatureDetails = digitalSignatureDetails;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name = "typeId", EmitDefaultValue = false)]
        public Guid TypeId { get; set; }

        /// <summary>
        /// Gets or Sets TypeName
        /// </summary>
        [DataMember(Name = "typeName", EmitDefaultValue = true)]
        public string? TypeName { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = true)]
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = true)]
        public string? Identifier { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public Guid? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = false)]
        public Guid IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerName
        /// </summary>
        [DataMember(Name = "issuerName", EmitDefaultValue = true)]
        public string? IssuerName { get; set; }

        /// <summary>
        /// Gets or Sets StorageUrl
        /// </summary>
        [DataMember(Name = "storageUrl", EmitDefaultValue = true)]
        public string? StorageUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsQuickAccessEnabled
        /// </summary>
        [DataMember(Name = "isQuickAccessEnabled", EmitDefaultValue = true)]
        public bool IsQuickAccessEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name = "isOwner", EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Gets or Sets DigitalSignatureDetails
        /// </summary>
        [DataMember(Name = "digitalSignatureDetails", EmitDefaultValue = true)]
        public List<DigitalSignature> DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserDocumentDetailsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  StorageUrl: ").Append(StorageUrl).Append("\n");
            sb.Append("  IsQuickAccessEnabled: ").Append(IsQuickAccessEnabled).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  DigitalSignatureDetails: ").Append(DigitalSignatureDetails).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as UserDocumentDetailsDto);
        }

        /// <summary>
        /// Returns true if UserDocumentDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDocumentDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDocumentDetailsDto input)
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
                    this.CategoryType == input.CategoryType ||
                    this.CategoryType.Equals(input.CategoryType)
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))
                ) && 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
                ) && 
                (
                    this.StorageUrl == input.StorageUrl ||
                    (this.StorageUrl != null &&
                    this.StorageUrl.Equals(input.StorageUrl))
                ) && 
                (
                    this.IsQuickAccessEnabled == input.IsQuickAccessEnabled ||
                    this.IsQuickAccessEnabled.Equals(input.IsQuickAccessEnabled)
                ) && 
                (
                    this.IsOwner == input.IsOwner ||
                    this.IsOwner.Equals(input.IsOwner)
                ) && 
                (
                    this.DigitalSignatureDetails == input.DigitalSignatureDetails ||
                    this.DigitalSignatureDetails != null &&
                    input.DigitalSignatureDetails != null &&
                    this.DigitalSignatureDetails.SequenceEqual(input.DigitalSignatureDetails)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
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
                hashCode = (hashCode * 59) + this.CategoryType.GetHashCode();
                if (this.TypeId != null)
                {
                    hashCode = (hashCode * 59) + this.TypeId.GetHashCode();
                }
                if (this.TypeName != null)
                {
                    hashCode = (hashCode * 59) + this.TypeName.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.IssuerId != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerId.GetHashCode();
                }
                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }
                if (this.StorageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StorageUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsQuickAccessEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IsOwner.GetHashCode();
                if (this.DigitalSignatureDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DigitalSignatureDetails.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
