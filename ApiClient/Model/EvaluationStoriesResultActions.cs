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
using OpenAPIDateConverter = Vevro.Rasa.ApiClient.Client.OpenAPIDateConverter;

namespace Vevro.Rasa.ApiClient.Model
{
    /// <summary>
    /// EvaluationStoriesResultActions
    /// </summary>
    [DataContract]
    public partial class EvaluationStoriesResultActions : IEquatable<EvaluationStoriesResultActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStoriesResultActions" /> class.
        /// </summary>
        /// <param name="action">Name of the actual action.</param>
        /// <param name="predicted">Name of the predicted action.</param>
        /// <param name="policy">Machine-learning policy used in the prediction.</param>
        /// <param name="confidence">Confidence score of the prediction.</param>
        public EvaluationStoriesResultActions(string action = default(string), string predicted = default(string), string policy = default(string), string confidence = default(string))
        {
            this.Action = action;
            this.Predicted = predicted;
            this.Policy = policy;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Name of the actual action
        /// </summary>
        /// <value>Name of the actual action</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Name of the predicted action
        /// </summary>
        /// <value>Name of the predicted action</value>
        [DataMember(Name = "predicted", EmitDefaultValue = false)]
        public string Predicted { get; set; }

        /// <summary>
        /// Machine-learning policy used in the prediction
        /// </summary>
        /// <value>Machine-learning policy used in the prediction</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Confidence score of the prediction
        /// </summary>
        /// <value>Confidence score of the prediction</value>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        public string Confidence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationStoriesResultActions {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Predicted: ").Append(Predicted).Append("\n");
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
            return this.Equals(input as EvaluationStoriesResultActions);
        }

        /// <summary>
        /// Returns true if EvaluationStoriesResultActions instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationStoriesResultActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationStoriesResultActions input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) &&
                (
                    this.Predicted == input.Predicted ||
                    (this.Predicted != null &&
                    this.Predicted.Equals(input.Predicted))
                ) &&
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) &&
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Predicted != null)
                    hashCode = hashCode * 59 + this.Predicted.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Confidence != null)
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
