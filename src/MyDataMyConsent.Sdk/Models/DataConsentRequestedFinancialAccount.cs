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
using OpenAPIDateConverter = MyDataMyConsent.Sdk.Client.OpenAPIDateConverter;

namespace MyDataMyConsent.Sdk.Models
{
    /// <summary>
    /// DataConsentRequestedFinancialAccount
    /// </summary>
    [DataContract(Name = "DataConsentRequestedFinancialAccount")]
    public partial class DataConsentRequestedFinancialAccount : IEquatable<DataConsentRequestedFinancialAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentRequestedFinancialAccount" /> class.
        /// </summary>
        /// <param name="customKey">customKey.</param>
        /// <param name="drn">drn.</param>
        /// <param name="accountTypeId">accountTypeId.</param>
        /// <param name="accountIdentifier">accountIdentifier.</param>
        public DataConsentRequestedFinancialAccount(string? customKey = default(string?), string? drn = default(string?), Guid? accountTypeId = default(Guid?), Guid? accountIdentifier = default(Guid?))
        {
            this.CustomKey = customKey;
            this.Drn = drn;
            this.AccountTypeId = accountTypeId;
            this.AccountIdentifier = accountIdentifier;
        }

        /// <summary>
        /// Gets or Sets CustomKey
        /// </summary>
        [DataMember(Name = "custom_key", EmitDefaultValue = true)]
        public string? CustomKey { get; set; }

        /// <summary>
        /// Gets or Sets Drn
        /// </summary>
        [DataMember(Name = "drn", EmitDefaultValue = true)]
        public string? Drn { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeId
        /// </summary>
        [DataMember(Name = "accountTypeId", EmitDefaultValue = true)]
        public Guid? AccountTypeId { get; set; }

        /// <summary>
        /// Gets or Sets AccountIdentifier
        /// </summary>
        [DataMember(Name = "accountIdentifier", EmitDefaultValue = true)]
        public Guid? AccountIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataConsentRequestedFinancialAccount {\n");
            sb.Append("  CustomKey: ").Append(CustomKey).Append("\n");
            sb.Append("  Drn: ").Append(Drn).Append("\n");
            sb.Append("  AccountTypeId: ").Append(AccountTypeId).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
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
            return this.Equals(input as DataConsentRequestedFinancialAccount);
        }

        /// <summary>
        /// Returns true if DataConsentRequestedFinancialAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentRequestedFinancialAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentRequestedFinancialAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomKey == input.CustomKey ||
                    (this.CustomKey != null &&
                    this.CustomKey.Equals(input.CustomKey))
                ) && 
                (
                    this.Drn == input.Drn ||
                    (this.Drn != null &&
                    this.Drn.Equals(input.Drn))
                ) && 
                (
                    this.AccountTypeId == input.AccountTypeId ||
                    (this.AccountTypeId != null &&
                    this.AccountTypeId.Equals(input.AccountTypeId))
                ) && 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
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
                if (this.CustomKey != null)
                {
                    hashCode = (hashCode * 59) + this.CustomKey.GetHashCode();
                }
                if (this.Drn != null)
                {
                    hashCode = (hashCode * 59) + this.Drn.GetHashCode();
                }
                if (this.AccountTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountTypeId.GetHashCode();
                }
                if (this.AccountIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.AccountIdentifier.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
