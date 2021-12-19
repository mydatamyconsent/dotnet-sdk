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
    /// DataConsentRfaFilter
    /// </summary>
    [DataContract(Name = "DataConsentRfaFilter")]
    public partial class DataConsentRfaFilter : IEquatable<DataConsentRfaFilter>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FilterType
        /// </summary>
        [DataMember(Name = "filterType", EmitDefaultValue = false)]
        public FilterType? FilterType { get; set; }

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public Operator? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataConsentRfaFilter" /> class.
        /// </summary>
        /// <param name="filterType">filterType.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="value">value.</param>
        public DataConsentRfaFilter(FilterType? filterType = default(FilterType?), Operator? _operator = default(Operator?), string value = default(string))
        {
            this.FilterType = filterType;
            this.Operator = _operator;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataConsentRfaFilter {\n");
            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DataConsentRfaFilter);
        }

        /// <summary>
        /// Returns true if DataConsentRfaFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of DataConsentRfaFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataConsentRfaFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterType == input.FilterType ||
                    this.FilterType.Equals(input.FilterType)
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
