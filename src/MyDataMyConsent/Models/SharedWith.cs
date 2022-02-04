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
    /// SharedWith
    /// </summary>
    [DataContract(Name = "SharedWith")]
    public partial class SharedWith : IEquatable<SharedWith>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedWith" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="receiverId">receiverId.</param>
        /// <param name="name">name.</param>
        /// <param name="contactNumber">contactNumber.</param>
        /// <param name="profileUrl">profileUrl.</param>
        /// <param name="expiresAtUtc">expiresAtUtc.</param>
        public SharedWith(Guid id = default(Guid), Guid receiverId = default(Guid), string name = default(string), string contactNumber = default(string), string profileUrl = default(string), DateTime? expiresAtUtc = default(DateTime?))
        {
            this.Id = id;
            this.ReceiverId = receiverId;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.ProfileUrl = profileUrl;
            this.ExpiresAtUtc = expiresAtUtc;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverId
        /// </summary>
        [DataMember(Name = "receiverId", EmitDefaultValue = false)]
        public Guid ReceiverId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name = "contactNumber", EmitDefaultValue = true)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets ProfileUrl
        /// </summary>
        [DataMember(Name = "profileUrl", EmitDefaultValue = true)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAtUtc
        /// </summary>
        [DataMember(Name = "expiresAtUtc", EmitDefaultValue = true)]
        public DateTime? ExpiresAtUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SharedWith {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReceiverId: ").Append(ReceiverId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  ExpiresAtUtc: ").Append(ExpiresAtUtc).Append("\n");
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
            return this.Equals(input as SharedWith);
        }

        /// <summary>
        /// Returns true if SharedWith instances are equal
        /// </summary>
        /// <param name="input">Instance of SharedWith to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedWith input)
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
                    this.ReceiverId == input.ReceiverId ||
                    (this.ReceiverId != null &&
                    this.ReceiverId.Equals(input.ReceiverId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
                ) && 
                (
                    this.ExpiresAtUtc == input.ExpiresAtUtc ||
                    (this.ExpiresAtUtc != null &&
                    this.ExpiresAtUtc.Equals(input.ExpiresAtUtc))
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
                if (this.ReceiverId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ContactNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ContactNumber.GetHashCode();
                }
                if (this.ProfileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileUrl.GetHashCode();
                }
                if (this.ExpiresAtUtc != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAtUtc.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
