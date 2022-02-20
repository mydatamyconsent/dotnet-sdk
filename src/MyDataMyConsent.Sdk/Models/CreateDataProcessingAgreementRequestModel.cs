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
    /// CreateDataProcessingAgreementRequestModel
    /// </summary>
    [DataContract(Name = "CreateDataProcessingAgreementRequestModel")]
    public partial class CreateDataProcessingAgreementRequestModel : IEquatable<CreateDataProcessingAgreementRequestModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataProcessingAgreementRequestModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDataProcessingAgreementRequestModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataProcessingAgreementRequestModel" /> class.
        /// </summary>
        /// <param name="version">version (required).</param>
        /// <param name="body">body (required).</param>
        /// <param name="attachmentUrl">attachmentUrl (required).</param>
        public CreateDataProcessingAgreementRequestModel(string version = default(string), string body = default(string), string attachmentUrl = default(string))
        {
            this._Version = version;
            this.Body = body;
            this.AttachmentUrl = attachmentUrl;
        }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentUrl
        /// </summary>
        [DataMember(Name = "attachmentUrl", IsRequired = true, EmitDefaultValue = false)]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDataProcessingAgreementRequestModel {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
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
            return this.Equals(input as CreateDataProcessingAgreementRequestModel);
        }

        /// <summary>
        /// Returns true if CreateDataProcessingAgreementRequestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDataProcessingAgreementRequestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDataProcessingAgreementRequestModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.AttachmentUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentUrl.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
