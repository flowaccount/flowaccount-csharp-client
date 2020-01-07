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
    /// ReferencedByMe
    /// </summary>
    [DataContract]
    public partial class ReferencedByMe :  IEquatable<ReferencedByMe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedByMe" /> class.
        /// </summary>
        /// <param name="referenceId">ID เอกสารฉบับนี้.</param>
        /// <param name="referenceDocumentType">ประเภทของเอกสารฉบับนี้.</param>
        /// <param name="referenceDocumentSerial">เลขที่เอกสารฉบับนี้.</param>
        /// <param name="documentId">ID เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้.</param>
        /// <param name="documentSerial">เลขที่เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้.</param>
        /// <param name="type">type (default to 1).</param>
        public ReferencedByMe(int referenceId = default(int), int referenceDocumentType = default(int), string referenceDocumentSerial = default(string), int documentId = default(int), int documentSerial = default(int), int type = 1)
        {
            this.ReferenceId = referenceId;
            this.ReferenceDocumentType = referenceDocumentType;
            this.ReferenceDocumentSerial = referenceDocumentSerial;
            this.DocumentId = documentId;
            this.DocumentSerial = documentSerial;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = 1;
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// ID เอกสารฉบับนี้
        /// </summary>
        /// <value>ID เอกสารฉบับนี้</value>
        [DataMember(Name="referenceId", EmitDefaultValue=true)]
        public int ReferenceId { get; set; }

        /// <summary>
        /// ประเภทของเอกสารฉบับนี้
        /// </summary>
        /// <value>ประเภทของเอกสารฉบับนี้</value>
        [DataMember(Name="referenceDocumentType", EmitDefaultValue=true)]
        public int ReferenceDocumentType { get; set; }

        /// <summary>
        /// เลขที่เอกสารฉบับนี้
        /// </summary>
        /// <value>เลขที่เอกสารฉบับนี้</value>
        [DataMember(Name="referenceDocumentSerial", EmitDefaultValue=true)]
        public string ReferenceDocumentSerial { get; set; }

        /// <summary>
        /// ID เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้
        /// </summary>
        /// <value>ID เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้</value>
        [DataMember(Name="documentId", EmitDefaultValue=true)]
        public int DocumentId { get; set; }

        /// <summary>
        /// เลขที่เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้
        /// </summary>
        /// <value>เลขที่เอกสารต้นทางที่อ้างอิง ถึง เอกสารฉบับนี้</value>
        [DataMember(Name="documentSerial", EmitDefaultValue=true)]
        public int DocumentSerial { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public int Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencedByMe {\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  ReferenceDocumentType: ").Append(ReferenceDocumentType).Append("\n");
            sb.Append("  ReferenceDocumentSerial: ").Append(ReferenceDocumentSerial).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentSerial: ").Append(DocumentSerial).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ReferencedByMe);
        }

        /// <summary>
        /// Returns true if ReferencedByMe instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencedByMe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencedByMe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.ReferenceDocumentType == input.ReferenceDocumentType ||
                    (this.ReferenceDocumentType != null &&
                    this.ReferenceDocumentType.Equals(input.ReferenceDocumentType))
                ) && 
                (
                    this.ReferenceDocumentSerial == input.ReferenceDocumentSerial ||
                    (this.ReferenceDocumentSerial != null &&
                    this.ReferenceDocumentSerial.Equals(input.ReferenceDocumentSerial))
                ) && 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.DocumentSerial == input.DocumentSerial ||
                    (this.DocumentSerial != null &&
                    this.DocumentSerial.Equals(input.DocumentSerial))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.ReferenceDocumentType != null)
                    hashCode = hashCode * 59 + this.ReferenceDocumentType.GetHashCode();
                if (this.ReferenceDocumentSerial != null)
                    hashCode = hashCode * 59 + this.ReferenceDocumentSerial.GetHashCode();
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.DocumentSerial != null)
                    hashCode = hashCode * 59 + this.DocumentSerial.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
