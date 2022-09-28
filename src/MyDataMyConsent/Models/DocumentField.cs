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
    /// DocumentField : Document field of consent request template.
    /// </summary>
    [DataContract(Name = "DocumentField")]
    public partial class DocumentField : IEquatable<DocumentField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentField" /> class.
        /// </summary>
        /// <param name="fieldTitle">Field title. (required).</param>
        /// <param name="fieldSlug">Field slug. (required).</param>
        /// <param name="drns">Field DRNs. (required).</param>
        public DocumentField(string fieldTitle = default(string), string fieldSlug = default(string), List<string> drns = default(List<string>))
        {
            // to ensure "fieldTitle" is required (not null)
            if (fieldTitle == null)
            {
                throw new ArgumentNullException("fieldTitle is a required property for DocumentField and cannot be null");
            }
            this.FieldTitle = fieldTitle;
            // to ensure "fieldSlug" is required (not null)
            if (fieldSlug == null)
            {
                throw new ArgumentNullException("fieldSlug is a required property for DocumentField and cannot be null");
            }
            this.FieldSlug = fieldSlug;
            // to ensure "drns" is required (not null)
            if (drns == null)
            {
                throw new ArgumentNullException("drns is a required property for DocumentField and cannot be null");
            }
            this.Drns = drns;
        }

        /// <summary>
        /// Field title.
        /// </summary>
        /// <value>Field title.</value>
        [DataMember(Name = "fieldTitle", IsRequired = true, EmitDefaultValue = true)]
        public string FieldTitle { get; set; }

        /// <summary>
        /// Field slug.
        /// </summary>
        /// <value>Field slug.</value>
        [DataMember(Name = "fieldSlug", IsRequired = true, EmitDefaultValue = true)]
        public string FieldSlug { get; set; }

        /// <summary>
        /// Field DRNs.
        /// </summary>
        /// <value>Field DRNs.</value>
        [DataMember(Name = "drns", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Drns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentField {\n");
            sb.Append("  FieldTitle: ").Append(FieldTitle).Append("\n");
            sb.Append("  FieldSlug: ").Append(FieldSlug).Append("\n");
            sb.Append("  Drns: ").Append(Drns).Append("\n");
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
            return this.Equals(input as DocumentField);
        }

        /// <summary>
        /// Returns true if DocumentField instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldTitle == input.FieldTitle ||
                    (this.FieldTitle != null &&
                    this.FieldTitle.Equals(input.FieldTitle))
                ) && 
                (
                    this.FieldSlug == input.FieldSlug ||
                    (this.FieldSlug != null &&
                    this.FieldSlug.Equals(input.FieldSlug))
                ) && 
                (
                    this.Drns == input.Drns ||
                    this.Drns != null &&
                    input.Drns != null &&
                    this.Drns.SequenceEqual(input.Drns)
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
                if (this.FieldTitle != null)
                {
                    hashCode = (hashCode * 59) + this.FieldTitle.GetHashCode();
                }
                if (this.FieldSlug != null)
                {
                    hashCode = (hashCode * 59) + this.FieldSlug.GetHashCode();
                }
                if (this.Drns != null)
                {
                    hashCode = (hashCode * 59) + this.Drns.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
