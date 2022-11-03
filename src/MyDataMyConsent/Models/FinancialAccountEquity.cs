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
    /// FinancialAccountEquity
    /// </summary>
    [DataContract(Name = "FinancialAccountEquity")]
    public partial class FinancialAccountEquity : IEquatable<FinancialAccountEquity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccountEquity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FinancialAccountEquity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialAccountEquity" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="issuerName">issuerName (required).</param>
        /// <param name="exchange">exchange (required).</param>
        /// <param name="isin">isin (required).</param>
        /// <param name="units">units (required).</param>
        /// <param name="investmentValue">investmentValue (required).</param>
        /// <param name="currentValue">currentValue (required).</param>
        /// <param name="currencyCode">currencyCode (required).</param>
        /// <param name="holder">holder (required).</param>
        /// <param name="transactions">transactions (required).</param>
        public FinancialAccountEquity(string type = default(string), string id = default(string), string name = default(string), string issuerName = default(string), string exchange = default(string), string isin = default(string), long units = default(long), double investmentValue = default(double), double currentValue = default(double), string currencyCode = default(string), Holder holder = default(Holder), bool transactions = default(bool))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Name = name;
            // to ensure "issuerName" is required (not null)
            if (issuerName == null)
            {
                throw new ArgumentNullException("issuerName is a required property for FinancialAccountEquity and cannot be null");
            }
            this.IssuerName = issuerName;
            // to ensure "exchange" is required (not null)
            if (exchange == null)
            {
                throw new ArgumentNullException("exchange is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Exchange = exchange;
            // to ensure "isin" is required (not null)
            if (isin == null)
            {
                throw new ArgumentNullException("isin is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Isin = isin;
            this.Units = units;
            this.InvestmentValue = investmentValue;
            this.CurrentValue = currentValue;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new ArgumentNullException("currencyCode is a required property for FinancialAccountEquity and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            // to ensure "holder" is required (not null)
            if (holder == null)
            {
                throw new ArgumentNullException("holder is a required property for FinancialAccountEquity and cannot be null");
            }
            this.Holder = holder;
            this.Transactions = transactions;
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
        /// Gets or Sets IssuerName
        /// </summary>
        [DataMember(Name = "issuer_name", IsRequired = true, EmitDefaultValue = true)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name = "exchange", IsRequired = true, EmitDefaultValue = true)]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or Sets Isin
        /// </summary>
        [DataMember(Name = "isin", IsRequired = true, EmitDefaultValue = true)]
        public string Isin { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public long Units { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentValue
        /// </summary>
        [DataMember(Name = "investment_value", IsRequired = true, EmitDefaultValue = true)]
        public double InvestmentValue { get; set; }

        /// <summary>
        /// Gets or Sets CurrentValue
        /// </summary>
        [DataMember(Name = "current_value", IsRequired = true, EmitDefaultValue = true)]
        public double CurrentValue { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currency_code", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Holder
        /// </summary>
        [DataMember(Name = "holder", IsRequired = true, EmitDefaultValue = true)]
        public Holder Holder { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = true)]
        public bool Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FinancialAccountEquity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  InvestmentValue: ").Append(InvestmentValue).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Holder: ").Append(Holder).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as FinancialAccountEquity);
        }

        /// <summary>
        /// Returns true if FinancialAccountEquity instances are equal
        /// </summary>
        /// <param name="input">Instance of FinancialAccountEquity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinancialAccountEquity input)
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
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.InvestmentValue == input.InvestmentValue ||
                    this.InvestmentValue.Equals(input.InvestmentValue)
                ) && 
                (
                    this.CurrentValue == input.CurrentValue ||
                    this.CurrentValue.Equals(input.CurrentValue)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Holder == input.Holder ||
                    (this.Holder != null &&
                    this.Holder.Equals(input.Holder))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions.Equals(input.Transactions)
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
                if (this.IssuerName != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerName.GetHashCode();
                }
                if (this.Exchange != null)
                {
                    hashCode = (hashCode * 59) + this.Exchange.GetHashCode();
                }
                if (this.Isin != null)
                {
                    hashCode = (hashCode * 59) + this.Isin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                hashCode = (hashCode * 59) + this.InvestmentValue.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentValue.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Holder != null)
                {
                    hashCode = (hashCode * 59) + this.Holder.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                return hashCode;
            }
        }

    }

}
