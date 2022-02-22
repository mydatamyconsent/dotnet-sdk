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
    /// DocumentReceiver
    /// </summary>
    [DataContract(Name = "DocumentReceiver")]
    public partial class DocumentReceiver : IEquatable<DocumentReceiver>
    {

        /// <summary>
        /// Gets or Sets IdentificationStrategy
        /// </summary>
        [DataMember(Name = "identificationStrategy", IsRequired = true, EmitDefaultValue = false)]
        public IdentificationStrategy IdentificationStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentReceiver" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentReceiver() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentReceiver" /> class.
        /// </summary>
        /// <param name="identifiers">identifiers (required).</param>
        /// <param name="identificationStrategy">identificationStrategy (required).</param>
        public DocumentReceiver(List<StringStringKeyValuePair> identifiers = default(List<StringStringKeyValuePair>), IdentificationStrategy identificationStrategy = default(IdentificationStrategy))
        {
            // to ensure "identifiers" is required (not null)
            if (identifiers == null) {
                throw new ArgumentNullException("identifiers is a required property for DocumentReceiver and cannot be null");
            }
            this.Identifiers = identifiers;
            this.IdentificationStrategy = identificationStrategy;
        }

        /// <summary>
        /// Gets or Sets Identifiers
        /// </summary>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = false)]
        public List<StringStringKeyValuePair> Identifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentReceiver {\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  IdentificationStrategy: ").Append(IdentificationStrategy).Append("\n");
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
            return this.Equals(input as DocumentReceiver);
        }

        /// <summary>
        /// Returns true if DocumentReceiver instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentReceiver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentReceiver input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.IdentificationStrategy == input.IdentificationStrategy ||
                    this.IdentificationStrategy.Equals(input.IdentificationStrategy)
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
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IdentificationStrategy.GetHashCode();
                return hashCode;
            }
        }

    }

}
