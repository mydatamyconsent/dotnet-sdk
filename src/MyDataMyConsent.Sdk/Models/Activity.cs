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
    /// Activity
    /// </summary>
    [DataContract(Name = "Activity")]
    public partial class Activity : IEquatable<Activity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="actorName">actorName.</param>
        /// <param name="description">description.</param>
        /// <param name="actorProfileUrl">actorProfileUrl.</param>
        /// <param name="dateTimeUtc">dateTimeUtc.</param>
        public Activity(string actorName = default(string), string description = default(string), string actorProfileUrl = default(string), DateTime dateTimeUtc = default(DateTime))
        {
            this.ActorName = actorName;
            this.Description = description;
            this.ActorProfileUrl = actorProfileUrl;
            this.DateTimeUtc = dateTimeUtc;
        }

        /// <summary>
        /// Gets or Sets ActorName
        /// </summary>
        [DataMember(Name = "actorName", EmitDefaultValue = true)]
        public string ActorName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ActorProfileUrl
        /// </summary>
        [DataMember(Name = "actorProfileUrl", EmitDefaultValue = true)]
        public string ActorProfileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeUtc
        /// </summary>
        [DataMember(Name = "dateTimeUtc", EmitDefaultValue = false)]
        public DateTime DateTimeUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  ActorName: ").Append(ActorName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActorProfileUrl: ").Append(ActorProfileUrl).Append("\n");
            sb.Append("  DateTimeUtc: ").Append(DateTimeUtc).Append("\n");
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
            return this.Equals(input as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="input">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActorName == input.ActorName ||
                    (this.ActorName != null &&
                    this.ActorName.Equals(input.ActorName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ActorProfileUrl == input.ActorProfileUrl ||
                    (this.ActorProfileUrl != null &&
                    this.ActorProfileUrl.Equals(input.ActorProfileUrl))
                ) && 
                (
                    this.DateTimeUtc == input.DateTimeUtc ||
                    (this.DateTimeUtc != null &&
                    this.DateTimeUtc.Equals(input.DateTimeUtc))
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
                if (this.ActorName != null)
                {
                    hashCode = (hashCode * 59) + this.ActorName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ActorProfileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActorProfileUrl.GetHashCode();
                }
                if (this.DateTimeUtc != null)
                {
                    hashCode = (hashCode * 59) + this.DateTimeUtc.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}