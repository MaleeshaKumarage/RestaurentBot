/* 
 * Rasa - Server Endpoints
 *
 * The Rasa server provides endpoints to retrieve trackers of conversations as well as endpoints to modify them. Additionally, endpoints for training and testing models are provided.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ApiClient.Client.OpenAPIDateConverter;

namespace ApiClient.Model
{
    /// <summary>
    /// ActionRequest
    /// </summary>
    [DataContract]
    public partial class ActionRequest : IEquatable<ActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequest" /> class.
        /// </summary>
        /// <param name="name">Name of the action to be executed. (required).</param>
        /// <param name="policy">Name of the policy that predicted the action (optional)..</param>
        /// <param name="confidence">Confidence of the prediction (optional)..</param>
        public ActionRequest(string name = default(string), string policy = default(string), decimal confidence = default(decimal))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ActionRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Policy = policy;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Name of the action to be executed.
        /// </summary>
        /// <value>Name of the action to be executed.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the policy that predicted the action (optional).
        /// </summary>
        /// <value>Name of the policy that predicted the action (optional).</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Confidence of the prediction (optional).
        /// </summary>
        /// <value>Confidence of the prediction (optional).</value>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        public decimal Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionRequest);
        }

        /// <summary>
        /// Returns true if ActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) &&
                (
                    this.Confidence == input.Confidence ||
                    this.Confidence.Equals(input.Confidence)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                hashCode = hashCode * 59 + this.Confidence.GetHashCode();
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
