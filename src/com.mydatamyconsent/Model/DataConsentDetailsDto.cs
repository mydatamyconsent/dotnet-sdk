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
    /// DataConsentDetailsDto
    /// </summary>
    [DataContract(Name = "DataConsentDetailsDto")]
    public partial class DataConsentDetailsDto : IEquatable<DataConsentDetailsDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataLifeUnit
        /// </summary>
        [DataMember(Name = "dataLifeUnit", EmitDefaultValue = false)]
        public DataLifeUnit? DataLifeUnit { get; set; }

        /// <summary>
        /// Gets or Sets DataFetchFrequencyUnit
        /// </summary>
        [DataMember(Name = "dataFetchFrequencyUnit", EmitDefaultValue = false)]
        public DataFetchFrequencyUnit? DataFetchFrequencyUnit { get; set; }

        /// <summary>
        /// Gets or Sets DataFetchType
        /// </summary>
        [DataMember(Name = "dataFetchType", EmitDefaultValue = false)]
        public DataFetchType? DataFetchType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DataConsentStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentDetailsDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="requester">requester.</param>
        /// <param name="location">location.</param>
        /// <param name="personalInfoRequested">personalInfoRequested.</param>
        /// <param name="documents">documents.</param>
        /// <param name="financialAccounts">financialAccounts.</param>
        /// <param name="transactionId">transactionId.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="description">description.</param>
        /// <param name="purposeCode">purposeCode.</param>
        /// <param name="purposeLink">purposeLink.</param>
        /// <param name="agreementId">agreementId.</param>
        /// <param name="dataLifeUnit">dataLifeUnit.</param>
        /// <param name="dataLifeValue">dataLifeValue.</param>
        /// <param name="dataFetchFrequencyUnit">dataFetchFrequencyUnit.</param>
        /// <param name="dataFetchFrequencyUnitValue">dataFetchFrequencyUnitValue.</param>
        /// <param name="dataFetchType">dataFetchType.</param>
        /// <param name="status">status.</param>
        /// <param name="approvedAtUtc">approvedAtUtc.</param>
        /// <param name="rejectedAtUtc">rejectedAtUtc.</param>
        /// <param name="expiresAtUtc">expiresAtUtc.</param>
        /// <param name="requestedAtUtc">requestedAtUtc.</param>
        /// <param name="requestedFinancialAccounts">requestedFinancialAccounts.</param>
        /// <param name="requestedDocuments">requestedDocuments.</param>
        /// <param name="requestedHealthData">requestedHealthData.</param>
        /// <param name="requestedIdentityDetails">requestedIdentityDetails.</param>
        public DataConsentDetailsDto(Guid id = default(Guid), DataConsentRequesterDto requester = default(DataConsentRequesterDto), string location = default(string), bool personalInfoRequested = default(bool), int documents = default(int), int financialAccounts = default(int), string transactionId = default(string), string ipAddress = default(string), string description = default(string), string purposeCode = default(string), string purposeLink = default(string), Guid? agreementId = default(Guid?), DataLifeUnit? dataLifeUnit = default(DataLifeUnit?), int dataLifeValue = default(int), DataFetchFrequencyUnit? dataFetchFrequencyUnit = default(DataFetchFrequencyUnit?), int dataFetchFrequencyUnitValue = default(int), DataFetchType? dataFetchType = default(DataFetchType?), DataConsentStatus? status = default(DataConsentStatus?), DateTime? approvedAtUtc = default(DateTime?), DateTime? rejectedAtUtc = default(DateTime?), DateTime expiresAtUtc = default(DateTime), DateTime requestedAtUtc = default(DateTime), List<DataConsentRequestedAccountDto> requestedFinancialAccounts = default(List<DataConsentRequestedAccountDto>), List<DataConsentRequestedDocumentDto> requestedDocuments = default(List<DataConsentRequestedDocumentDto>), List<DataConsentRequestedDocument> requestedHealthData = default(List<DataConsentRequestedDocument>), JsonSchema requestedIdentityDetails = default(JsonSchema))
        {
            this.Id = id;
            this.Requester = requester;
            this.Location = location;
            this.PersonalInfoRequested = personalInfoRequested;
            this.Documents = documents;
            this.FinancialAccounts = financialAccounts;
            this.TransactionId = transactionId;
            this.IpAddress = ipAddress;
            this.Description = description;
            this.PurposeCode = purposeCode;
            this.PurposeLink = purposeLink;
            this.AgreementId = agreementId;
            this.DataLifeUnit = dataLifeUnit;
            this.DataLifeValue = dataLifeValue;
            this.DataFetchFrequencyUnit = dataFetchFrequencyUnit;
            this.DataFetchFrequencyUnitValue = dataFetchFrequencyUnitValue;
            this.DataFetchType = dataFetchType;
            this.Status = status;
            this.ApprovedAtUtc = approvedAtUtc;
            this.RejectedAtUtc = rejectedAtUtc;
            this.ExpiresAtUtc = expiresAtUtc;
            this.RequestedAtUtc = requestedAtUtc;
            this.RequestedFinancialAccounts = requestedFinancialAccounts;
            this.RequestedDocuments = requestedDocuments;
            this.RequestedHealthData = requestedHealthData;
            this.RequestedIdentityDetails = requestedIdentityDetails;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name = "requester", EmitDefaultValue = false)]
        public DataConsentRequesterDto Requester { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets PersonalInfoRequested
        /// </summary>
        [DataMember(Name = "personalInfoRequested", EmitDefaultValue = true)]
        public bool PersonalInfoRequested { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public int Documents { get; set; }

        /// <summary>
        /// Gets or Sets FinancialAccounts
        /// </summary>
        [DataMember(Name = "financialAccounts", EmitDefaultValue = false)]
        public int FinancialAccounts { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ipAddress", EmitDefaultValue = true)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PurposeCode
        /// </summary>
        [DataMember(Name = "purposeCode", EmitDefaultValue = true)]
        public string PurposeCode { get; set; }

        /// <summary>
        /// Gets or Sets PurposeLink
        /// </summary>
        [DataMember(Name = "purposeLink", EmitDefaultValue = true)]
        public string PurposeLink { get; set; }

        /// <summary>
        /// Gets or Sets AgreementId
        /// </summary>
        [DataMember(Name = "agreementId", EmitDefaultValue = true)]
        public Guid? AgreementId { get; set; }

        /// <summary>
        /// Gets or Sets DataLifeValue
        /// </summary>
        [DataMember(Name = "dataLifeValue", EmitDefaultValue = false)]
        public int DataLifeValue { get; set; }

        /// <summary>
        /// Gets or Sets DataFetchFrequencyUnitValue
        /// </summary>
        [DataMember(Name = "dataFetchFrequencyUnitValue", EmitDefaultValue = false)]
        public int DataFetchFrequencyUnitValue { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedAtUtc
        /// </summary>
        [DataMember(Name = "approvedAtUtc", EmitDefaultValue = true)]
        public DateTime? ApprovedAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets RejectedAtUtc
        /// </summary>
        [DataMember(Name = "rejectedAtUtc", EmitDefaultValue = true)]
        public DateTime? RejectedAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAtUtc
        /// </summary>
        [DataMember(Name = "expiresAtUtc", EmitDefaultValue = false)]
        public DateTime ExpiresAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets RequestedAtUtc
        /// </summary>
        [DataMember(Name = "requestedAtUtc", EmitDefaultValue = false)]
        public DateTime RequestedAtUtc { get; set; }

        /// <summary>
        /// Gets or Sets RequestedFinancialAccounts
        /// </summary>
        [DataMember(Name = "requestedFinancialAccounts", EmitDefaultValue = true)]
        public List<DataConsentRequestedAccountDto> RequestedFinancialAccounts { get; set; }

        /// <summary>
        /// Gets or Sets RequestedDocuments
        /// </summary>
        [DataMember(Name = "requestedDocuments", EmitDefaultValue = true)]
        public List<DataConsentRequestedDocumentDto> RequestedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets RequestedHealthData
        /// </summary>
        [DataMember(Name = "requestedHealthData", EmitDefaultValue = true)]
        public List<DataConsentRequestedDocument> RequestedHealthData { get; set; }

        /// <summary>
        /// Gets or Sets RequestedIdentityDetails
        /// </summary>
        [DataMember(Name = "requestedIdentityDetails", EmitDefaultValue = false)]
        public JsonSchema RequestedIdentityDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataConsentDetailsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PersonalInfoRequested: ").Append(PersonalInfoRequested).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  FinancialAccounts: ").Append(FinancialAccounts).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PurposeCode: ").Append(PurposeCode).Append("\n");
            sb.Append("  PurposeLink: ").Append(PurposeLink).Append("\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  DataLifeUnit: ").Append(DataLifeUnit).Append("\n");
            sb.Append("  DataLifeValue: ").Append(DataLifeValue).Append("\n");
            sb.Append("  DataFetchFrequencyUnit: ").Append(DataFetchFrequencyUnit).Append("\n");
            sb.Append("  DataFetchFrequencyUnitValue: ").Append(DataFetchFrequencyUnitValue).Append("\n");
            sb.Append("  DataFetchType: ").Append(DataFetchType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ApprovedAtUtc: ").Append(ApprovedAtUtc).Append("\n");
            sb.Append("  RejectedAtUtc: ").Append(RejectedAtUtc).Append("\n");
            sb.Append("  ExpiresAtUtc: ").Append(ExpiresAtUtc).Append("\n");
            sb.Append("  RequestedAtUtc: ").Append(RequestedAtUtc).Append("\n");
            sb.Append("  RequestedFinancialAccounts: ").Append(RequestedFinancialAccounts).Append("\n");
            sb.Append("  RequestedDocuments: ").Append(RequestedDocuments).Append("\n");
            sb.Append("  RequestedHealthData: ").Append(RequestedHealthData).Append("\n");
            sb.Append("  RequestedIdentityDetails: ").Append(RequestedIdentityDetails).Append("\n");
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
            return this.Equals(input as DataConsentDetailsDto);
        }

        /// <summary>
        /// Returns true if DataConsentDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentDetailsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.PersonalInfoRequested == input.PersonalInfoRequested ||
                    this.PersonalInfoRequested.Equals(input.PersonalInfoRequested)
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents.Equals(input.Documents)
                ) && 
                (
                    this.FinancialAccounts == input.FinancialAccounts ||
                    this.FinancialAccounts.Equals(input.FinancialAccounts)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PurposeCode == input.PurposeCode ||
                    (this.PurposeCode != null &&
                    this.PurposeCode.Equals(input.PurposeCode))
                ) && 
                (
                    this.PurposeLink == input.PurposeLink ||
                    (this.PurposeLink != null &&
                    this.PurposeLink.Equals(input.PurposeLink))
                ) && 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.DataLifeUnit == input.DataLifeUnit ||
                    this.DataLifeUnit.Equals(input.DataLifeUnit)
                ) && 
                (
                    this.DataLifeValue == input.DataLifeValue ||
                    this.DataLifeValue.Equals(input.DataLifeValue)
                ) && 
                (
                    this.DataFetchFrequencyUnit == input.DataFetchFrequencyUnit ||
                    this.DataFetchFrequencyUnit.Equals(input.DataFetchFrequencyUnit)
                ) && 
                (
                    this.DataFetchFrequencyUnitValue == input.DataFetchFrequencyUnitValue ||
                    this.DataFetchFrequencyUnitValue.Equals(input.DataFetchFrequencyUnitValue)
                ) && 
                (
                    this.DataFetchType == input.DataFetchType ||
                    this.DataFetchType.Equals(input.DataFetchType)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ApprovedAtUtc == input.ApprovedAtUtc ||
                    (this.ApprovedAtUtc != null &&
                    this.ApprovedAtUtc.Equals(input.ApprovedAtUtc))
                ) && 
                (
                    this.RejectedAtUtc == input.RejectedAtUtc ||
                    (this.RejectedAtUtc != null &&
                    this.RejectedAtUtc.Equals(input.RejectedAtUtc))
                ) && 
                (
                    this.ExpiresAtUtc == input.ExpiresAtUtc ||
                    (this.ExpiresAtUtc != null &&
                    this.ExpiresAtUtc.Equals(input.ExpiresAtUtc))
                ) && 
                (
                    this.RequestedAtUtc == input.RequestedAtUtc ||
                    (this.RequestedAtUtc != null &&
                    this.RequestedAtUtc.Equals(input.RequestedAtUtc))
                ) && 
                (
                    this.RequestedFinancialAccounts == input.RequestedFinancialAccounts ||
                    this.RequestedFinancialAccounts != null &&
                    input.RequestedFinancialAccounts != null &&
                    this.RequestedFinancialAccounts.SequenceEqual(input.RequestedFinancialAccounts)
                ) && 
                (
                    this.RequestedDocuments == input.RequestedDocuments ||
                    this.RequestedDocuments != null &&
                    input.RequestedDocuments != null &&
                    this.RequestedDocuments.SequenceEqual(input.RequestedDocuments)
                ) && 
                (
                    this.RequestedHealthData == input.RequestedHealthData ||
                    this.RequestedHealthData != null &&
                    input.RequestedHealthData != null &&
                    this.RequestedHealthData.SequenceEqual(input.RequestedHealthData)
                ) && 
                (
                    this.RequestedIdentityDetails == input.RequestedIdentityDetails ||
                    (this.RequestedIdentityDetails != null &&
                    this.RequestedIdentityDetails.Equals(input.RequestedIdentityDetails))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.PersonalInfoRequested.GetHashCode();
                hashCode = hashCode * 59 + this.Documents.GetHashCode();
                hashCode = hashCode * 59 + this.FinancialAccounts.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PurposeCode != null)
                    hashCode = hashCode * 59 + this.PurposeCode.GetHashCode();
                if (this.PurposeLink != null)
                    hashCode = hashCode * 59 + this.PurposeLink.GetHashCode();
                if (this.AgreementId != null)
                    hashCode = hashCode * 59 + this.AgreementId.GetHashCode();
                hashCode = hashCode * 59 + this.DataLifeUnit.GetHashCode();
                hashCode = hashCode * 59 + this.DataLifeValue.GetHashCode();
                hashCode = hashCode * 59 + this.DataFetchFrequencyUnit.GetHashCode();
                hashCode = hashCode * 59 + this.DataFetchFrequencyUnitValue.GetHashCode();
                hashCode = hashCode * 59 + this.DataFetchType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ApprovedAtUtc != null)
                    hashCode = hashCode * 59 + this.ApprovedAtUtc.GetHashCode();
                if (this.RejectedAtUtc != null)
                    hashCode = hashCode * 59 + this.RejectedAtUtc.GetHashCode();
                if (this.ExpiresAtUtc != null)
                    hashCode = hashCode * 59 + this.ExpiresAtUtc.GetHashCode();
                if (this.RequestedAtUtc != null)
                    hashCode = hashCode * 59 + this.RequestedAtUtc.GetHashCode();
                if (this.RequestedFinancialAccounts != null)
                    hashCode = hashCode * 59 + this.RequestedFinancialAccounts.GetHashCode();
                if (this.RequestedDocuments != null)
                    hashCode = hashCode * 59 + this.RequestedDocuments.GetHashCode();
                if (this.RequestedHealthData != null)
                    hashCode = hashCode * 59 + this.RequestedHealthData.GetHashCode();
                if (this.RequestedIdentityDetails != null)
                    hashCode = hashCode * 59 + this.RequestedIdentityDetails.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
