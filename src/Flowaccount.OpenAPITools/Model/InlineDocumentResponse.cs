/* 
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2-oas3
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
using OpenAPIDateConverter = Flowaccount.OpenAPITools.Client.OpenAPIDateConverter;

namespace Flowaccount.OpenAPITools.Model
{
    /// <summary>
    /// InlineDocumentResponse
    /// </summary>
    [DataContract]
    public partial class InlineDocumentResponse : DocumentResponse,  IEquatable<InlineDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDocumentResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        public InlineDocumentResponse(InlineDocument data = default(InlineDocument), bool status = default(bool), string message = default(string), int code = default(int), string documentStructureType = default(string)) : base(status, message, code, documentStructureType)
        {
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public InlineDocument Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineDocumentResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as InlineDocumentResponse);
        }

        /// <summary>
        /// Returns true if InlineDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineDocumentResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                int hashCode = base.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
