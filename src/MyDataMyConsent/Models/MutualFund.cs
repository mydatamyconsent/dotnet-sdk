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
    /// MutualFund
    /// </summary>
    [DataContract(Name = "MutualFund")]
    public partial class MutualFund : IEquatable<MutualFund>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MutualFund() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFund" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="investmentValue">investmentValue (required).</param>
        /// <param name="currentValue">currentValue (required).</param>
        /// <param name="currencyCode">currencyCode (required).</param>
        /// <param name="amc">amc.</param>
        /// <param name="registrar">registrar.</param>
        /// <param name="fundName">fundName (required).</param>
        /// <param name="isin">isin (required).</param>
        /// <param name="folioNumber">folioNumber (required).</param>
        /// <param name="schemeCode">schemeCode.</param>
        /// <param name="fundType">fundType.</param>
        /// <param name="fundCategory">fundCategory.</param>
        /// <param name="units">units (required).</param>
        /// <param name="lienUnits">lienUnits.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="holder">holder (required).</param>
        /// <param name="transactions">transactions (required).</param>
        public MutualFund(string id = default(string), string name = default(string), double investmentValue = default(double), double currentValue = default(double), string currencyCode = default(string), string amc = default(string), string registrar = default(string), string fundName = default(string), string isin = default(string), string folioNumber = default(string), string schemeCode = default(string), string fundType = default(string), string fundCategory = default(string), double units = default(double), string lienUnits = default(string), DateTime creationDate = default(DateTime), Holder holder = default(Holder), bool transactions = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for MutualFund and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for MutualFund and cannot be null");
            }
            this.Name = name;
            this.InvestmentValue = investmentValue;
            this.CurrentValue = currentValue;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new ArgumentNullException("currencyCode is a required property for MutualFund and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            // to ensure "fundName" is required (not null)
            if (fundName == null)
            {
                throw new ArgumentNullException("fundName is a required property for MutualFund and cannot be null");
            }
            this.FundName = fundName;
            // to ensure "isin" is required (not null)
            if (isin == null)
            {
                throw new ArgumentNullException("isin is a required property for MutualFund and cannot be null");
            }
            this.Isin = isin;
            // to ensure "folioNumber" is required (not null)
            if (folioNumber == null)
            {
                throw new ArgumentNullException("folioNumber is a required property for MutualFund and cannot be null");
            }
            this.FolioNumber = folioNumber;
            this.Units = units;
            // to ensure "holder" is required (not null)
            if (holder == null)
            {
                throw new ArgumentNullException("holder is a required property for MutualFund and cannot be null");
            }
            this.Holder = holder;
            this.Transactions = transactions;
            this.Amc = amc;
            this.Registrar = registrar;
            this.SchemeCode = schemeCode;
            this.FundType = fundType;
            this.FundCategory = fundCategory;
            this.LienUnits = lienUnits;
            this.CreationDate = creationDate;
        }

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
        /// Gets or Sets Amc
        /// </summary>
        [DataMember(Name = "amc", EmitDefaultValue = false)]
        public string Amc { get; set; }

        /// <summary>
        /// Gets or Sets Registrar
        /// </summary>
        [DataMember(Name = "registrar", EmitDefaultValue = false)]
        public string Registrar { get; set; }

        /// <summary>
        /// Gets or Sets FundName
        /// </summary>
        [DataMember(Name = "fund_name", IsRequired = true, EmitDefaultValue = true)]
        public string FundName { get; set; }

        /// <summary>
        /// Gets or Sets Isin
        /// </summary>
        [DataMember(Name = "isin", IsRequired = true, EmitDefaultValue = true)]
        public string Isin { get; set; }

        /// <summary>
        /// Gets or Sets FolioNumber
        /// </summary>
        [DataMember(Name = "folio_number", IsRequired = true, EmitDefaultValue = true)]
        public string FolioNumber { get; set; }

        /// <summary>
        /// Gets or Sets SchemeCode
        /// </summary>
        [DataMember(Name = "scheme_code", EmitDefaultValue = false)]
        public string SchemeCode { get; set; }

        /// <summary>
        /// Gets or Sets FundType
        /// </summary>
        [DataMember(Name = "fund_type", EmitDefaultValue = false)]
        public string FundType { get; set; }

        /// <summary>
        /// Gets or Sets FundCategory
        /// </summary>
        [DataMember(Name = "fund_category", EmitDefaultValue = false)]
        public string FundCategory { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public double Units { get; set; }

        /// <summary>
        /// Gets or Sets LienUnits
        /// </summary>
        [DataMember(Name = "lien_units", EmitDefaultValue = false)]
        public string LienUnits { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creation_date", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

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
            sb.Append("class MutualFund {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InvestmentValue: ").Append(InvestmentValue).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Amc: ").Append(Amc).Append("\n");
            sb.Append("  Registrar: ").Append(Registrar).Append("\n");
            sb.Append("  FundName: ").Append(FundName).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  FolioNumber: ").Append(FolioNumber).Append("\n");
            sb.Append("  SchemeCode: ").Append(SchemeCode).Append("\n");
            sb.Append("  FundType: ").Append(FundType).Append("\n");
            sb.Append("  FundCategory: ").Append(FundCategory).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  LienUnits: ").Append(LienUnits).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
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
            return this.Equals(input as MutualFund);
        }

        /// <summary>
        /// Returns true if MutualFund instances are equal
        /// </summary>
        /// <param name="input">Instance of MutualFund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutualFund input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Amc == input.Amc ||
                    (this.Amc != null &&
                    this.Amc.Equals(input.Amc))
                ) && 
                (
                    this.Registrar == input.Registrar ||
                    (this.Registrar != null &&
                    this.Registrar.Equals(input.Registrar))
                ) && 
                (
                    this.FundName == input.FundName ||
                    (this.FundName != null &&
                    this.FundName.Equals(input.FundName))
                ) && 
                (
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.FolioNumber == input.FolioNumber ||
                    (this.FolioNumber != null &&
                    this.FolioNumber.Equals(input.FolioNumber))
                ) && 
                (
                    this.SchemeCode == input.SchemeCode ||
                    (this.SchemeCode != null &&
                    this.SchemeCode.Equals(input.SchemeCode))
                ) && 
                (
                    this.FundType == input.FundType ||
                    (this.FundType != null &&
                    this.FundType.Equals(input.FundType))
                ) && 
                (
                    this.FundCategory == input.FundCategory ||
                    (this.FundCategory != null &&
                    this.FundCategory.Equals(input.FundCategory))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.LienUnits == input.LienUnits ||
                    (this.LienUnits != null &&
                    this.LienUnits.Equals(input.LienUnits))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvestmentValue.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentValue.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Amc != null)
                {
                    hashCode = (hashCode * 59) + this.Amc.GetHashCode();
                }
                if (this.Registrar != null)
                {
                    hashCode = (hashCode * 59) + this.Registrar.GetHashCode();
                }
                if (this.FundName != null)
                {
                    hashCode = (hashCode * 59) + this.FundName.GetHashCode();
                }
                if (this.Isin != null)
                {
                    hashCode = (hashCode * 59) + this.Isin.GetHashCode();
                }
                if (this.FolioNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FolioNumber.GetHashCode();
                }
                if (this.SchemeCode != null)
                {
                    hashCode = (hashCode * 59) + this.SchemeCode.GetHashCode();
                }
                if (this.FundType != null)
                {
                    hashCode = (hashCode * 59) + this.FundType.GetHashCode();
                }
                if (this.FundCategory != null)
                {
                    hashCode = (hashCode * 59) + this.FundCategory.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.LienUnits != null)
                {
                    hashCode = (hashCode * 59) + this.LienUnits.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
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
