/* 
 * FlowAccount Open API
 *
 * FlowAccount.com โปรแกรมบัญชีออนไลน์ใช้งานง่าย สำหรับธุรกิจที่พึ่งเริ่มต้น   # Introduction **Servers Production**    site: https://www.flowaccount.com    api url: https://openapi.flowaccount.com/v1    **Beta test**   site: http://sandbox-new.flowaccount.com/    api url: https://openapi.flowaccount.com/test
 *
 * The version of the OpenAPI document: 2-oas3
 * Contact: developer@flowaccount.com
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
    /// ExpenseDocumentResponse
    /// </summary>
    [DataContract]
    public partial class ExpenseDocumentResponse :  IEquatable<ExpenseDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseDocumentResponse" /> class.
        /// </summary>
        /// <param name="status">action success.</param>
        /// <param name="message">error message.</param>
        /// <param name="code">error code.</param>
        /// <param name="data">data.</param>
        public ExpenseDocumentResponse(bool status = default(bool), string message = default(string), int code = default(int), Object data = default(Object))
        {
            this.Status = status;
            this.Message = message;
            this.Code = code;
            this.Data = data;
        }
        
        /// <summary>
        /// action success
        /// </summary>
        /// <value>action success</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public bool Status { get; set; }

        /// <summary>
        /// error message
        /// </summary>
        /// <value>error message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// error code
        /// </summary>
        /// <value>error code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public int Code { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public Object Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseDocumentResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as ExpenseDocumentResponse);
        }

        /// <summary>
        /// Returns true if ExpenseDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseDocumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
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
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
            yield break;
        }
    }

}
