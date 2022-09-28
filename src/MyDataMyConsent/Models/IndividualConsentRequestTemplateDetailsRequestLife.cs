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
    /// IndividualConsentRequestTemplateDetailsRequestLife
    /// </summary>
    [DataContract(Name = "IndividualConsentRequestTemplateDetails_requestLife")]
    public partial class IndividualConsentRequestTemplateDetailsRequestLife : IEquatable<IndividualConsentRequestTemplateDetailsRequestLife>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualConsentRequestTemplateDetailsRequestLife" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndividualConsentRequestTemplateDetailsRequestLife() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualConsentRequestTemplateDetailsRequestLife" /> class.
        /// </summary>
        /// <param name="unit">Life unit. Example: days, hours, minutes. (required).</param>
        /// <param name="value">Life value in number. (required).</param>
        public IndividualConsentRequestTemplateDetailsRequestLife(string unit = default(string), string value = default(string))
        {
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for IndividualConsentRequestTemplateDetailsRequestLife and cannot be null");
            }
            this.Unit = unit;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for IndividualConsentRequestTemplateDetailsRequestLife and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Life unit. Example: days, hours, minutes.
        /// </summary>
        /// <value>Life unit. Example: days, hours, minutes.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = true)]
        public string Unit { get; set; }

        /// <summary>
        /// Life value in number.
        /// </summary>
        /// <value>Life value in number.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndividualConsentRequestTemplateDetailsRequestLife {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as IndividualConsentRequestTemplateDetailsRequestLife);
        }

        /// <summary>
        /// Returns true if IndividualConsentRequestTemplateDetailsRequestLife instances are equal
        /// </summary>
        /// <param name="input">Instance of IndividualConsentRequestTemplateDetailsRequestLife to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndividualConsentRequestTemplateDetailsRequestLife input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
