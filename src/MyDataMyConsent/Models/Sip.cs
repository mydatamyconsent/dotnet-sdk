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
    /// Sip
    /// </summary>
    [DataContract(Name = "Sip")]
    public partial class Sip : IEquatable<Sip>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sip" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="investmentValue">investmentValue (required).</param>
        /// <param name="currentValue">currentValue (required).</param>
        /// <param name="currencyCode">currencyCode (required).</param>
        /// <param name="planInfo">planInfo (required).</param>
        /// <param name="investmentInfo">investmentInfo (required).</param>
        /// <param name="holder">holder (required).</param>
        /// <param name="transactions">transactions (required).</param>
        public Sip(string id = default(string), string name = default(string), double investmentValue = default(double), double currentValue = default(double), string currencyCode = default(string), SipPlanInformation planInfo = default(SipPlanInformation), SipInvestmentInformation investmentInfo = default(SipInvestmentInformation), Holder holder = default(Holder), bool transactions = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Sip and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Sip and cannot be null");
            }
            this.Name = name;
            this.InvestmentValue = investmentValue;
            this.CurrentValue = currentValue;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new ArgumentNullException("currencyCode is a required property for Sip and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            // to ensure "planInfo" is required (not null)
            if (planInfo == null)
            {
                throw new ArgumentNullException("planInfo is a required property for Sip and cannot be null");
            }
            this.PlanInfo = planInfo;
            // to ensure "investmentInfo" is required (not null)
            if (investmentInfo == null)
            {
                throw new ArgumentNullException("investmentInfo is a required property for Sip and cannot be null");
            }
            this.InvestmentInfo = investmentInfo;
            // to ensure "holder" is required (not null)
            if (holder == null)
            {
                throw new ArgumentNullException("holder is a required property for Sip and cannot be null");
            }
            this.Holder = holder;
            this.Transactions = transactions;
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
        /// Gets or Sets PlanInfo
        /// </summary>
        [DataMember(Name = "plan_info", IsRequired = true, EmitDefaultValue = true)]
        public SipPlanInformation PlanInfo { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentInfo
        /// </summary>
        [DataMember(Name = "investment_info", IsRequired = true, EmitDefaultValue = true)]
        public SipInvestmentInformation InvestmentInfo { get; set; }

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
            sb.Append("class Sip {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InvestmentValue: ").Append(InvestmentValue).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  PlanInfo: ").Append(PlanInfo).Append("\n");
            sb.Append("  InvestmentInfo: ").Append(InvestmentInfo).Append("\n");
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
            return this.Equals(input as Sip);
        }

        /// <summary>
        /// Returns true if Sip instances are equal
        /// </summary>
        /// <param name="input">Instance of Sip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sip input)
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
                    this.PlanInfo == input.PlanInfo ||
                    (this.PlanInfo != null &&
                    this.PlanInfo.Equals(input.PlanInfo))
                ) && 
                (
                    this.InvestmentInfo == input.InvestmentInfo ||
                    (this.InvestmentInfo != null &&
                    this.InvestmentInfo.Equals(input.InvestmentInfo))
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
                if (this.PlanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PlanInfo.GetHashCode();
                }
                if (this.InvestmentInfo != null)
                {
                    hashCode = (hashCode * 59) + this.InvestmentInfo.GetHashCode();
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
