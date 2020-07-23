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
    /// TrainingRequest
    /// </summary>
    [DataContract]
    public partial class TrainingRequest : IEquatable<TrainingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrainingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRequest" /> class.
        /// </summary>
        /// <param name="domain">Rasa domain in plain text.</param>
        /// <param name="config">Rasa config in plain text (required).</param>
        /// <param name="nlu">Rasa NLU training data in markdown format.</param>
        /// <param name="stories">Rasa Core stories in markdown format.</param>
        /// <param name="_out">Output directory.</param>
        /// <param name="force">Force a model training even if the data has not changed.</param>
        public TrainingRequest(string domain = default(string), string config = default(string), string nlu = default(string), string stories = default(string), string _out = default(string), bool force = default(bool))
        {
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new InvalidDataException("config is a required property for TrainingRequest and cannot be null");
            }
            else
            {
                this.Config = config;
            }

            this.Domain = domain;
            this.Nlu = nlu;
            this.Stories = stories;
            this.Out = _out;
            this.Force = force;
        }

        /// <summary>
        /// Rasa domain in plain text
        /// </summary>
        /// <value>Rasa domain in plain text</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Rasa config in plain text
        /// </summary>
        /// <value>Rasa config in plain text</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public string Config { get; set; }

        /// <summary>
        /// Rasa NLU training data in markdown format
        /// </summary>
        /// <value>Rasa NLU training data in markdown format</value>
        [DataMember(Name = "nlu", EmitDefaultValue = false)]
        public string Nlu { get; set; }

        /// <summary>
        /// Rasa Core stories in markdown format
        /// </summary>
        /// <value>Rasa Core stories in markdown format</value>
        [DataMember(Name = "stories", EmitDefaultValue = false)]
        public string Stories { get; set; }

        /// <summary>
        /// Output directory
        /// </summary>
        /// <value>Output directory</value>
        [DataMember(Name = "out", EmitDefaultValue = false)]
        public string Out { get; set; }

        /// <summary>
        /// Force a model training even if the data has not changed
        /// </summary>
        /// <value>Force a model training even if the data has not changed</value>
        [DataMember(Name = "force", EmitDefaultValue = false)]
        public bool Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingRequest {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Nlu: ").Append(Nlu).Append("\n");
            sb.Append("  Stories: ").Append(Stories).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
            return this.Equals(input as TrainingRequest);
        }

        /// <summary>
        /// Returns true if TrainingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TrainingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrainingRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) &&
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) &&
                (
                    this.Nlu == input.Nlu ||
                    (this.Nlu != null &&
                    this.Nlu.Equals(input.Nlu))
                ) &&
                (
                    this.Stories == input.Stories ||
                    (this.Stories != null &&
                    this.Stories.Equals(input.Stories))
                ) &&
                (
                    this.Out == input.Out ||
                    (this.Out != null &&
                    this.Out.Equals(input.Out))
                ) &&
                (
                    this.Force == input.Force ||
                    this.Force.Equals(input.Force)
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Nlu != null)
                    hashCode = hashCode * 59 + this.Nlu.GetHashCode();
                if (this.Stories != null)
                    hashCode = hashCode * 59 + this.Stories.GetHashCode();
                if (this.Out != null)
                    hashCode = hashCode * 59 + this.Out.GetHashCode();
                hashCode = hashCode * 59 + this.Force.GetHashCode();
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
