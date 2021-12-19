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
    /// OrganizationType
    /// </summary>
    [DataContract(Name = "OrganizationType")]
    public partial class OrganizationType : IEquatable<OrganizationType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="typeName">typeName.</param>
        /// <param name="elfCode">elfCode.</param>
        /// <param name="country">country.</param>
        public OrganizationType(Guid id = default(Guid), Guid countryId = default(Guid), string typeName = default(string), string elfCode = default(string), Country country = default(Country))
        {
            this.Id = id;
            this.CountryId = countryId;
            this.TypeName = typeName;
            this.ElfCode = elfCode;
            this.Country = country;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "countryId", EmitDefaultValue = false)]
        public Guid CountryId { get; set; }

        /// <summary>
        /// Gets or Sets TypeName
        /// </summary>
        [DataMember(Name = "typeName", EmitDefaultValue = true)]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or Sets ElfCode
        /// </summary>
        [DataMember(Name = "elfCode", EmitDefaultValue = true)]
        public string ElfCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public Country Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  ElfCode: ").Append(ElfCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as OrganizationType);
        }

        /// <summary>
        /// Returns true if OrganizationType instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationType input)
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
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.ElfCode == input.ElfCode ||
                    (this.ElfCode != null &&
                    this.ElfCode.Equals(input.ElfCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.TypeName != null)
                    hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.ElfCode != null)
                    hashCode = hashCode * 59 + this.ElfCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
