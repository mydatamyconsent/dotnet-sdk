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
    /// Country
    /// </summary>
    [DataContract(Name = "Country")]
    public partial class Country : IEquatable<Country>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="iso3">iso3.</param>
        /// <param name="iso2">iso2.</param>
        /// <param name="phoneCode">phoneCode.</param>
        /// <param name="capital">capital.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="flagUrl">flagUrl.</param>
        /// <param name="states">states.</param>
        public Country(Guid id = default(Guid), string name = default(string), string iso3 = default(string), string iso2 = default(string), string phoneCode = default(string), string capital = default(string), string currencyCode = default(string), string currencySymbol = default(string), string flagUrl = default(string), List<CountryState> states = default(List<CountryState>))
        {
            this.Id = id;
            this.Name = name;
            this.Iso3 = iso3;
            this.Iso2 = iso2;
            this.PhoneCode = phoneCode;
            this.Capital = capital;
            this.CurrencyCode = currencyCode;
            this.CurrencySymbol = currencySymbol;
            this.FlagUrl = flagUrl;
            this.States = states;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Iso3
        /// </summary>
        [DataMember(Name = "iso3", EmitDefaultValue = true)]
        public string Iso3 { get; set; }

        /// <summary>
        /// Gets or Sets Iso2
        /// </summary>
        [DataMember(Name = "iso2", EmitDefaultValue = true)]
        public string Iso2 { get; set; }

        /// <summary>
        /// Gets or Sets PhoneCode
        /// </summary>
        [DataMember(Name = "phoneCode", EmitDefaultValue = true)]
        public string PhoneCode { get; set; }

        /// <summary>
        /// Gets or Sets Capital
        /// </summary>
        [DataMember(Name = "capital", EmitDefaultValue = true)]
        public string Capital { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currencyCode", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name = "currencySymbol", EmitDefaultValue = true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets FlagUrl
        /// </summary>
        [DataMember(Name = "flagUrl", EmitDefaultValue = true)]
        public string FlagUrl { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<CountryState> States { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Country {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Iso3: ").Append(Iso3).Append("\n");
            sb.Append("  Iso2: ").Append(Iso2).Append("\n");
            sb.Append("  PhoneCode: ").Append(PhoneCode).Append("\n");
            sb.Append("  Capital: ").Append(Capital).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  FlagUrl: ").Append(FlagUrl).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
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
            return this.Equals(input as Country);
        }

        /// <summary>
        /// Returns true if Country instances are equal
        /// </summary>
        /// <param name="input">Instance of Country to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Country input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Iso3 == input.Iso3 ||
                    (this.Iso3 != null &&
                    this.Iso3.Equals(input.Iso3))
                ) && 
                (
                    this.Iso2 == input.Iso2 ||
                    (this.Iso2 != null &&
                    this.Iso2.Equals(input.Iso2))
                ) && 
                (
                    this.PhoneCode == input.PhoneCode ||
                    (this.PhoneCode != null &&
                    this.PhoneCode.Equals(input.PhoneCode))
                ) && 
                (
                    this.Capital == input.Capital ||
                    (this.Capital != null &&
                    this.Capital.Equals(input.Capital))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.FlagUrl == input.FlagUrl ||
                    (this.FlagUrl != null &&
                    this.FlagUrl.Equals(input.FlagUrl))
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Iso3 != null)
                    hashCode = hashCode * 59 + this.Iso3.GetHashCode();
                if (this.Iso2 != null)
                    hashCode = hashCode * 59 + this.Iso2.GetHashCode();
                if (this.PhoneCode != null)
                    hashCode = hashCode * 59 + this.PhoneCode.GetHashCode();
                if (this.Capital != null)
                    hashCode = hashCode * 59 + this.Capital.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.FlagUrl != null)
                    hashCode = hashCode * 59 + this.FlagUrl.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
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
