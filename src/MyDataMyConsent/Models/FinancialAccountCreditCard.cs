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
    /// FinancialAccountCreditCard
    /// </summary>
    [DataContract(Name = "FinancialAccountCreditCard")]
    public partial class FinancialAccountCreditCard : IEquatable<FinancialAccountCreditCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccountCreditCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinancialAccountCreditCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccountCreditCard" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="balance">balance (required).</param>
        /// <param name="profile">profile (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="maskedAccountNumber">maskedAccountNumber (required).</param>
        /// <param name="linkedAccountRef">linkedAccountRef (required).</param>
        /// <param name="version">version (required).</param>
        public FinancialAccountCreditCard(string type = default(string), string id = default(string), string name = default(string), string identifier = default(string), double balance = default(double), CreditCardProfile profile = default(CreditCardProfile), CreditCardSummary summary = default(CreditCardSummary), string maskedAccountNumber = default(string), string linkedAccountRef = default(string), float version = default(float))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Name = name;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Identifier = identifier;
            this.Balance = balance;
            // to ensure "profile" is required (not null)
            if (profile == null)
            {
                throw new ArgumentNullException("profile is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Profile = profile;
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new ArgumentNullException("summary is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.Summary = summary;
            // to ensure "maskedAccountNumber" is required (not null)
            if (maskedAccountNumber == null)
            {
                throw new ArgumentNullException("maskedAccountNumber is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.MaskedAccountNumber = maskedAccountNumber;
            // to ensure "linkedAccountRef" is required (not null)
            if (linkedAccountRef == null)
            {
                throw new ArgumentNullException("linkedAccountRef is a required property for FinancialAccountCreditCard and cannot be null");
            }
            this.LinkedAccountRef = linkedAccountRef;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = true)]
        public double Balance { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", IsRequired = true, EmitDefaultValue = true)]
        public CreditCardProfile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = true)]
        public CreditCardSummary Summary { get; set; }

        /// <summary>
        /// Gets or Sets MaskedAccountNumber
        /// </summary>
        [DataMember(Name = "masked_account_number", IsRequired = true, EmitDefaultValue = true)]
        public string MaskedAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets LinkedAccountRef
        /// </summary>
        [DataMember(Name = "linked_account_ref", IsRequired = true, EmitDefaultValue = true)]
        public string LinkedAccountRef { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public float _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FinancialAccountCreditCard {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  MaskedAccountNumber: ").Append(MaskedAccountNumber).Append("\n");
            sb.Append("  LinkedAccountRef: ").Append(LinkedAccountRef).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as FinancialAccountCreditCard);
        }

        /// <summary>
        /// Returns true if FinancialAccountCreditCard instances are equal
        /// </summary>
        /// <param name="input">Instance of FinancialAccountCreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialAccountCreditCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
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
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.MaskedAccountNumber == input.MaskedAccountNumber ||
                    (this.MaskedAccountNumber != null &&
                    this.MaskedAccountNumber.Equals(input.MaskedAccountNumber))
                ) && 
                (
                    this.LinkedAccountRef == input.LinkedAccountRef ||
                    (this.LinkedAccountRef != null &&
                    this.LinkedAccountRef.Equals(input.LinkedAccountRef))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                if (this.Profile != null)
                {
                    hashCode = (hashCode * 59) + this.Profile.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.MaskedAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.MaskedAccountNumber.GetHashCode();
                }
                if (this.LinkedAccountRef != null)
                {
                    hashCode = (hashCode * 59) + this.LinkedAccountRef.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
