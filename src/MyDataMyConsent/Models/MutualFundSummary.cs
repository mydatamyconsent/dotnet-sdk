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
    /// MutualFundSummary
    /// </summary>
    [DataContract(Name = "MutualFundSummary")]
    public partial class MutualFundSummary : IEquatable<MutualFundSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MutualFundSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundSummary" /> class.
        /// </summary>
        /// <param name="investment">investment (required).</param>
        /// <param name="investmentValue">investmentValue (required).</param>
        /// <param name="currentValue">currentValue (required).</param>
        public MutualFundSummary(MutualFundInvestment investment = default(MutualFundInvestment), double investmentValue = default(double), double currentValue = default(double))
        {
            // to ensure "investment" is required (not null)
            if (investment == null)
            {
                throw new ArgumentNullException("investment is a required property for MutualFundSummary and cannot be null");
            }
            this.Investment = investment;
            this.InvestmentValue = investmentValue;
            this.CurrentValue = currentValue;
        }

        /// <summary>
        /// Gets or Sets Investment
        /// </summary>
        [DataMember(Name = "investment", IsRequired = true, EmitDefaultValue = true)]
        public MutualFundInvestment Investment { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentValue
        /// </summary>
        [DataMember(Name = "investmentValue", IsRequired = true, EmitDefaultValue = true)]
        public double InvestmentValue { get; set; }

        /// <summary>
        /// Gets or Sets CurrentValue
        /// </summary>
        [DataMember(Name = "currentValue", IsRequired = true, EmitDefaultValue = true)]
        public double CurrentValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MutualFundSummary {\n");
            sb.Append("  Investment: ").Append(Investment).Append("\n");
            sb.Append("  InvestmentValue: ").Append(InvestmentValue).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
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
            return this.Equals(input as MutualFundSummary);
        }

        /// <summary>
        /// Returns true if MutualFundSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MutualFundSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutualFundSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Investment == input.Investment ||
                    (this.Investment != null &&
                    this.Investment.Equals(input.Investment))
                ) && 
                (
                    this.InvestmentValue == input.InvestmentValue ||
                    this.InvestmentValue.Equals(input.InvestmentValue)
                ) && 
                (
                    this.CurrentValue == input.CurrentValue ||
                    this.CurrentValue.Equals(input.CurrentValue)
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
                if (this.Investment != null)
                {
                    hashCode = (hashCode * 59) + this.Investment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvestmentValue.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentValue.GetHashCode();
                return hashCode;
            }
        }

    }

}
