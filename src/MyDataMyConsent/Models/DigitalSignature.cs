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
    /// DigitalSignature
    /// </summary>
    [DataContract(Name = "DigitalSignature")]
    public partial class DigitalSignature : IEquatable<DigitalSignature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalSignature" /> class.
        /// </summary>
        /// <param name="signedBy">signedBy.</param>
        /// <param name="certIssuedBy">certIssuedBy.</param>
        /// <param name="validFrom">validFrom.</param>
        /// <param name="validTill">validTill.</param>
        /// <param name="reason">reason.</param>
        /// <param name="location">location.</param>
        /// <param name="sha1Digest">sha1Digest.</param>
        public DigitalSignature(string signedBy = default(string), string certIssuedBy = default(string), DateTime validFrom = default(DateTime), DateTime validTill = default(DateTime), string reason = default(string), string location = default(string), string sha1Digest = default(string))
        {
            this.SignedBy = signedBy;
            this.CertIssuedBy = certIssuedBy;
            this.ValidFrom = validFrom;
            this.ValidTill = validTill;
            this.Reason = reason;
            this.Location = location;
            this.Sha1Digest = sha1Digest;
        }

        /// <summary>
        /// Gets or Sets SignedBy
        /// </summary>
        [DataMember(Name = "signedBy", EmitDefaultValue = true)]
        public string SignedBy { get; set; }

        /// <summary>
        /// Gets or Sets CertIssuedBy
        /// </summary>
        [DataMember(Name = "certIssuedBy", EmitDefaultValue = true)]
        public string CertIssuedBy { get; set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name = "validFrom", EmitDefaultValue = false)]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets ValidTill
        /// </summary>
        [DataMember(Name = "validTill", EmitDefaultValue = false)]
        public DateTime ValidTill { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Sha1Digest
        /// </summary>
        [DataMember(Name = "sha1Digest", EmitDefaultValue = true)]
        public string Sha1Digest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DigitalSignature {\n");
            sb.Append("  SignedBy: ").Append(SignedBy).Append("\n");
            sb.Append("  CertIssuedBy: ").Append(CertIssuedBy).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidTill: ").Append(ValidTill).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Sha1Digest: ").Append(Sha1Digest).Append("\n");
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
            return this.Equals(input as DigitalSignature);
        }

        /// <summary>
        /// Returns true if DigitalSignature instances are equal
        /// </summary>
        /// <param name="input">Instance of DigitalSignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DigitalSignature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignedBy == input.SignedBy ||
                    (this.SignedBy != null &&
                    this.SignedBy.Equals(input.SignedBy))
                ) && 
                (
                    this.CertIssuedBy == input.CertIssuedBy ||
                    (this.CertIssuedBy != null &&
                    this.CertIssuedBy.Equals(input.CertIssuedBy))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidTill == input.ValidTill ||
                    (this.ValidTill != null &&
                    this.ValidTill.Equals(input.ValidTill))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Sha1Digest == input.Sha1Digest ||
                    (this.Sha1Digest != null &&
                    this.Sha1Digest.Equals(input.Sha1Digest))
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
                if (this.SignedBy != null)
                {
                    hashCode = (hashCode * 59) + this.SignedBy.GetHashCode();
                }
                if (this.CertIssuedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CertIssuedBy.GetHashCode();
                }
                if (this.ValidFrom != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFrom.GetHashCode();
                }
                if (this.ValidTill != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTill.GetHashCode();
                }
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.Sha1Digest != null)
                {
                    hashCode = (hashCode * 59) + this.Sha1Digest.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
