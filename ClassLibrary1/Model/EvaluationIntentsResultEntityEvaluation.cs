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
    /// Rasa NLU entity evaluation
    /// </summary>
    [DataContract]
    public partial class EvaluationIntentsResultEntityEvaluation : IEquatable<EvaluationIntentsResultEntityEvaluation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationIntentsResultEntityEvaluation" /> class.
        /// </summary>
        /// <param name="extractorName">extractorName.</param>
        public EvaluationIntentsResultEntityEvaluation(EvaluationIntentsResultEntityEvaluationExtractorName extractorName = default(EvaluationIntentsResultEntityEvaluationExtractorName))
        {
            this.ExtractorName = extractorName;
        }

        /// <summary>
        /// Gets or Sets ExtractorName
        /// </summary>
        [DataMember(Name = "extractor_name", EmitDefaultValue = false)]
        public EvaluationIntentsResultEntityEvaluationExtractorName ExtractorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationIntentsResultEntityEvaluation {\n");
            sb.Append("  ExtractorName: ").Append(ExtractorName).Append("\n");
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
            return this.Equals(input as EvaluationIntentsResultEntityEvaluation);
        }

        /// <summary>
        /// Returns true if EvaluationIntentsResultEntityEvaluation instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationIntentsResultEntityEvaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationIntentsResultEntityEvaluation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ExtractorName == input.ExtractorName ||
                    (this.ExtractorName != null &&
                    this.ExtractorName.Equals(input.ExtractorName))
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
                if (this.ExtractorName != null)
                    hashCode = hashCode * 59 + this.ExtractorName.GetHashCode();
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
