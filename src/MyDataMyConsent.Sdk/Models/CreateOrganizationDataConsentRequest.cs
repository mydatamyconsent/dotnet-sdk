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
    /// Organization Data Consent Request.
    /// </summary>
    [DataContract(Name = "CreateOrganizationDataConsentRequest")]
    public partial class CreateOrganizationDataConsentRequest : IEquatable<CreateOrganizationDataConsentRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationDataConsentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrganizationDataConsentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationDataConsentRequest" /> class.
        /// </summary>
        /// <param name="consentTemplateId">consentTemplateId.</param>
        /// <param name="receiver">receiver (required).</param>
        public CreateOrganizationDataConsentRequest(Guid consentTemplateId = default(Guid), Receiver receiver = default(Receiver))
        {
            // to ensure "receiver" is required (not null)
            if (receiver == null) {
                throw new ArgumentNullException("receiver is a required property for CreateOrganizationDataConsentRequest and cannot be null");
            }
            this.Receiver = receiver;
            this.ConsentTemplateId = consentTemplateId;
        }

        /// <summary>
        /// Gets or Sets ConsentTemplateId
        /// </summary>
        [DataMember(Name = "consentTemplateId", EmitDefaultValue = false)]
        public Guid ConsentTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = false)]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrganizationDataConsentRequest {\n");
            sb.Append("  ConsentTemplateId: ").Append(ConsentTemplateId).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
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
            return this.Equals(input as CreateOrganizationDataConsentRequest);
        }

        /// <summary>
        /// Returns true if CreateOrganizationDataConsentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrganizationDataConsentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrganizationDataConsentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsentTemplateId == input.ConsentTemplateId ||
                    (this.ConsentTemplateId != null &&
                    this.ConsentTemplateId.Equals(input.ConsentTemplateId))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
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
                if (this.ConsentTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsentTemplateId.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}