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
    /// NLU parser information. If set, message will not be passed through NLU, but instead this parsing information will be used.
    /// </summary>
    [DataContract]
    public partial class ParseResult : IEquatable<ParseResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParseResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseResult" /> class.
        /// </summary>
        /// <param name="entities">Parsed entities.</param>
        /// <param name="intent">intent.</param>
        /// <param name="intentRanking">Scores of all intents.</param>
        /// <param name="text">Text of the message (required).</param>
        public ParseResult(List<Entity> entities = default(List<Entity>), Intent intent = default(Intent), List<Intent> intentRanking = default(List<Intent>), string text = default(string))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for ParseResult and cannot be null");
            }
            else
            {
                this.Text = text;
            }

            this.Entities = entities;
            this.Intent = intent;
            this.IntentRanking = intentRanking;
        }

        /// <summary>
        /// Parsed entities
        /// </summary>
        /// <value>Parsed entities</value>
        [DataMember(Name = "entities", EmitDefaultValue = false)]
        public List<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [DataMember(Name = "intent", EmitDefaultValue = false)]
        public Intent Intent { get; set; }

        /// <summary>
        /// Scores of all intents
        /// </summary>
        /// <value>Scores of all intents</value>
        [DataMember(Name = "intent_ranking", EmitDefaultValue = false)]
        public List<Intent> IntentRanking { get; set; }

        /// <summary>
        /// Text of the message
        /// </summary>
        /// <value>Text of the message</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseResult {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  IntentRanking: ").Append(IntentRanking).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as ParseResult);
        }

        /// <summary>
        /// Returns true if ParseResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ParseResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) &&
                (
                    this.Intent == input.Intent ||
                    (this.Intent != null &&
                    this.Intent.Equals(input.Intent))
                ) &&
                (
                    this.IntentRanking == input.IntentRanking ||
                    this.IntentRanking != null &&
                    input.IntentRanking != null &&
                    this.IntentRanking.SequenceEqual(input.IntentRanking)
                ) &&
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.Intent != null)
                    hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.IntentRanking != null)
                    hashCode = hashCode * 59 + this.IntentRanking.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
