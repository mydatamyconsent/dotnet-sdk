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
    /// DataConsentRequestedDocument
    /// </summary>
    [DataContract(Name = "DataConsentRequestedDocument")]
    public partial class DataConsentRequestedDocument : IEquatable<DataConsentRequestedDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentRequestedDocument" /> class.
        /// </summary>
        /// <param name="drn">drn.</param>
        /// <param name="fromDatetime">fromDatetime.</param>
        /// <param name="toDatetime">toDatetime.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="documentTypeId">documentTypeId.</param>
        /// <param name="documentIdentifier">documentIdentifier.</param>
        public DataConsentRequestedDocument(string drn = default(string), DateTime fromDatetime = default(DateTime), DateTime toDatetime = default(DateTime), Guid providerId = default(Guid), string documentTypeId = default(string), string documentIdentifier = default(string))
        {
            this.Drn = drn;
            this.FromDatetime = fromDatetime;
            this.ToDatetime = toDatetime;
            this.ProviderId = providerId;
            this.DocumentTypeId = documentTypeId;
            this.DocumentIdentifier = documentIdentifier;
        }

        /// <summary>
        /// Gets or Sets Drn
        /// </summary>
        [DataMember(Name = "drn", EmitDefaultValue = true)]
        public string Drn { get; set; }

        /// <summary>
        /// Gets or Sets FromDatetime
        /// </summary>
        [DataMember(Name = "fromDatetime", EmitDefaultValue = false)]
        public DateTime FromDatetime { get; set; }

        /// <summary>
        /// Gets or Sets ToDatetime
        /// </summary>
        [DataMember(Name = "toDatetime", EmitDefaultValue = false)]
        public DateTime ToDatetime { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public Guid ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTypeId
        /// </summary>
        [DataMember(Name = "documentTypeId", EmitDefaultValue = true)]
        public string DocumentTypeId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentIdentifier
        /// </summary>
        [DataMember(Name = "documentIdentifier", EmitDefaultValue = true)]
        public string DocumentIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataConsentRequestedDocument {\n");
            sb.Append("  Drn: ").Append(Drn).Append("\n");
            sb.Append("  FromDatetime: ").Append(FromDatetime).Append("\n");
            sb.Append("  ToDatetime: ").Append(ToDatetime).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  DocumentTypeId: ").Append(DocumentTypeId).Append("\n");
            sb.Append("  DocumentIdentifier: ").Append(DocumentIdentifier).Append("\n");
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
            return this.Equals(input as DataConsentRequestedDocument);
        }

        /// <summary>
        /// Returns true if DataConsentRequestedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentRequestedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentRequestedDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Drn == input.Drn ||
                    (this.Drn != null &&
                    this.Drn.Equals(input.Drn))
                ) && 
                (
                    this.FromDatetime == input.FromDatetime ||
                    (this.FromDatetime != null &&
                    this.FromDatetime.Equals(input.FromDatetime))
                ) && 
                (
                    this.ToDatetime == input.ToDatetime ||
                    (this.ToDatetime != null &&
                    this.ToDatetime.Equals(input.ToDatetime))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.DocumentTypeId == input.DocumentTypeId ||
                    (this.DocumentTypeId != null &&
                    this.DocumentTypeId.Equals(input.DocumentTypeId))
                ) && 
                (
                    this.DocumentIdentifier == input.DocumentIdentifier ||
                    (this.DocumentIdentifier != null &&
                    this.DocumentIdentifier.Equals(input.DocumentIdentifier))
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
                if (this.Drn != null)
                    hashCode = hashCode * 59 + this.Drn.GetHashCode();
                if (this.FromDatetime != null)
                    hashCode = hashCode * 59 + this.FromDatetime.GetHashCode();
                if (this.ToDatetime != null)
                    hashCode = hashCode * 59 + this.ToDatetime.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.DocumentTypeId != null)
                    hashCode = hashCode * 59 + this.DocumentTypeId.GetHashCode();
                if (this.DocumentIdentifier != null)
                    hashCode = hashCode * 59 + this.DocumentIdentifier.GetHashCode();
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
