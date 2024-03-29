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
    /// SipInvestmentInformation
    /// </summary>
    [DataContract(Name = "SipInvestmentInformation")]
    public partial class SipInvestmentInformation : IEquatable<SipInvestmentInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SipInvestmentInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SipInvestmentInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SipInvestmentInformation" /> class.
        /// </summary>
        /// <param name="instalmentAmount">instalmentAmount (required).</param>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="completedInstalments">completedInstalments (required).</param>
        /// <param name="investmentValue">investmentValue (required).</param>
        /// <param name="lastInstalmentDate">lastInstalmentDate.</param>
        /// <param name="nextInstalmentDate">nextInstalmentDate.</param>
        public SipInvestmentInformation(double instalmentAmount = default(double), string frequency = default(string), double completedInstalments = default(double), double investmentValue = default(double), DateTime lastInstalmentDate = default(DateTime), DateTime nextInstalmentDate = default(DateTime))
        {
            this.InstalmentAmount = instalmentAmount;
            // to ensure "frequency" is required (not null)
            if (frequency == null)
            {
                throw new ArgumentNullException("frequency is a required property for SipInvestmentInformation and cannot be null");
            }
            this.Frequency = frequency;
            this.CompletedInstalments = completedInstalments;
            this.InvestmentValue = investmentValue;
            this.LastInstalmentDate = lastInstalmentDate;
            this.NextInstalmentDate = nextInstalmentDate;
        }

        /// <summary>
        /// Gets or Sets InstalmentAmount
        /// </summary>
        [DataMember(Name = "instalment_amount", IsRequired = true, EmitDefaultValue = true)]
        public double InstalmentAmount { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or Sets CompletedInstalments
        /// </summary>
        [DataMember(Name = "completed_instalments", IsRequired = true, EmitDefaultValue = true)]
        public double CompletedInstalments { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentValue
        /// </summary>
        [DataMember(Name = "investment_value", IsRequired = true, EmitDefaultValue = true)]
        public double InvestmentValue { get; set; }

        /// <summary>
        /// Gets or Sets LastInstalmentDate
        /// </summary>
        [DataMember(Name = "last_instalment_date", EmitDefaultValue = false)]
        public DateTime LastInstalmentDate { get; set; }

        /// <summary>
        /// Gets or Sets NextInstalmentDate
        /// </summary>
        [DataMember(Name = "next_instalment_date", EmitDefaultValue = false)]
        public DateTime NextInstalmentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SipInvestmentInformation {\n");
            sb.Append("  InstalmentAmount: ").Append(InstalmentAmount).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  CompletedInstalments: ").Append(CompletedInstalments).Append("\n");
            sb.Append("  InvestmentValue: ").Append(InvestmentValue).Append("\n");
            sb.Append("  LastInstalmentDate: ").Append(LastInstalmentDate).Append("\n");
            sb.Append("  NextInstalmentDate: ").Append(NextInstalmentDate).Append("\n");
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
            return this.Equals(input as SipInvestmentInformation);
        }

        /// <summary>
        /// Returns true if SipInvestmentInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of SipInvestmentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SipInvestmentInformation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstalmentAmount == input.InstalmentAmount ||
                    this.InstalmentAmount.Equals(input.InstalmentAmount)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.CompletedInstalments == input.CompletedInstalments ||
                    this.CompletedInstalments.Equals(input.CompletedInstalments)
                ) && 
                (
                    this.InvestmentValue == input.InvestmentValue ||
                    this.InvestmentValue.Equals(input.InvestmentValue)
                ) && 
                (
                    this.LastInstalmentDate == input.LastInstalmentDate ||
                    (this.LastInstalmentDate != null &&
                    this.LastInstalmentDate.Equals(input.LastInstalmentDate))
                ) && 
                (
                    this.NextInstalmentDate == input.NextInstalmentDate ||
                    (this.NextInstalmentDate != null &&
                    this.NextInstalmentDate.Equals(input.NextInstalmentDate))
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
                hashCode = (hashCode * 59) + this.InstalmentAmount.GetHashCode();
                if (this.Frequency != null)
                {
                    hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CompletedInstalments.GetHashCode();
                hashCode = (hashCode * 59) + this.InvestmentValue.GetHashCode();
                if (this.LastInstalmentDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastInstalmentDate.GetHashCode();
                }
                if (this.NextInstalmentDate != null)
                {
                    hashCode = (hashCode * 59) + this.NextInstalmentDate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
