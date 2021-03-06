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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Flowaccount.OpenAPITools.Client.OpenAPIDateConverter;

namespace Flowaccount.OpenAPITools.Model
{
    /// <summary>
    /// SendEmail
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "DocumentStructureType")]
    [JsonSubtypes.KnownSubType(typeof(SendEmailSimple), "SendEmailSimple")]
    [JsonSubtypes.KnownSubType(typeof(SendEmailCoppies), "SendEmailCoppies")]
    public partial class SendEmail :  IEquatable<SendEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail" /> class.
        /// </summary>
        /// <param name="documentId">documentId หรือ recordId ของเอกสารที่ต้องการส่งอีเมล (required).</param>
        /// <param name="fromemail">ใส่อีเมลผู้ส่ง &lt;br&gt; &lt;ex&gt;Example: myemail@email.com&lt;/ex&gt; (required).</param>
        /// <param name="toemail">ใส่อีเมลผู้รับ &lt;br&gt; &lt;ex&gt;Example: contact@email.com&lt;/ex&gt; (required).</param>
        /// <param name="cCMyself">ส่งสำเนาหาตนเอง (default to true).</param>
        /// <param name="ccEmail">สำเนา (CC) &lt;br&gt; &lt;ex&gt;Example: cc@email.com&lt;/ex&gt;.</param>
        /// <param name="bccEmail">สำเนาลับ (BCC) &lt;br&gt; &lt;ex&gt;Example: bcc@email.com&lt;/ex&gt;.</param>
        /// <param name="subject">หัวข้อ / ชื่อเรื่อง  (required).</param>
        /// <param name="message">ข้อความ เนื้อหาของ email.</param>
        public SendEmail(long documentId = default(long), string fromemail = default(string), string toemail = default(string), bool cCMyself = true, string ccEmail = default(string), string bccEmail = default(string), string subject = default(string), string message = default(string))
        {
            // to ensure "documentId" is required (not null)
            if (documentId == null)
            {
                throw new InvalidDataException("documentId is a required property for SendEmail and cannot be null");
            }
            else
            {
                this.DocumentId = documentId;
            }
            
            // to ensure "fromemail" is required (not null)
            if (fromemail == null)
            {
                throw new InvalidDataException("fromemail is a required property for SendEmail and cannot be null");
            }
            else
            {
                this.Fromemail = fromemail;
            }
            
            // to ensure "toemail" is required (not null)
            if (toemail == null)
            {
                throw new InvalidDataException("toemail is a required property for SendEmail and cannot be null");
            }
            else
            {
                this.Toemail = toemail;
            }
            
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for SendEmail and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            
            // use default value if no "cCMyself" provided
            if (cCMyself == null)
            {
                this.CCMyself = true;
            }
            else
            {
                this.CCMyself = cCMyself;
            }
            this.CcEmail = ccEmail;
            this.BccEmail = bccEmail;
            this.Message = message;
        }
        
        /// <summary>
        /// documentId หรือ recordId ของเอกสารที่ต้องการส่งอีเมล
        /// </summary>
        /// <value>documentId หรือ recordId ของเอกสารที่ต้องการส่งอีเมล</value>
        [DataMember(Name="documentId", EmitDefaultValue=true)]
        public long DocumentId { get; set; }

        /// <summary>
        /// ใส่อีเมลผู้ส่ง &lt;br&gt; &lt;ex&gt;Example: myemail@email.com&lt;/ex&gt;
        /// </summary>
        /// <value>ใส่อีเมลผู้ส่ง &lt;br&gt; &lt;ex&gt;Example: myemail@email.com&lt;/ex&gt;</value>
        [DataMember(Name="fromemail", EmitDefaultValue=true)]
        public string Fromemail { get; set; }

        /// <summary>
        /// ใส่อีเมลผู้รับ &lt;br&gt; &lt;ex&gt;Example: contact@email.com&lt;/ex&gt;
        /// </summary>
        /// <value>ใส่อีเมลผู้รับ &lt;br&gt; &lt;ex&gt;Example: contact@email.com&lt;/ex&gt;</value>
        [DataMember(Name="toemail", EmitDefaultValue=true)]
        public string Toemail { get; set; }

        /// <summary>
        /// ส่งสำเนาหาตนเอง
        /// </summary>
        /// <value>ส่งสำเนาหาตนเอง</value>
        [DataMember(Name="cCMyself", EmitDefaultValue=true)]
        public bool CCMyself { get; set; }

        /// <summary>
        /// สำเนา (CC) &lt;br&gt; &lt;ex&gt;Example: cc@email.com&lt;/ex&gt;
        /// </summary>
        /// <value>สำเนา (CC) &lt;br&gt; &lt;ex&gt;Example: cc@email.com&lt;/ex&gt;</value>
        [DataMember(Name="ccEmail", EmitDefaultValue=true)]
        public string CcEmail { get; set; }

        /// <summary>
        /// สำเนาลับ (BCC) &lt;br&gt; &lt;ex&gt;Example: bcc@email.com&lt;/ex&gt;
        /// </summary>
        /// <value>สำเนาลับ (BCC) &lt;br&gt; &lt;ex&gt;Example: bcc@email.com&lt;/ex&gt;</value>
        [DataMember(Name="bccEmail", EmitDefaultValue=true)]
        public string BccEmail { get; set; }

        /// <summary>
        /// หัวข้อ / ชื่อเรื่อง 
        /// </summary>
        /// <value>หัวข้อ / ชื่อเรื่อง </value>
        [DataMember(Name="subject", EmitDefaultValue=true)]
        public string Subject { get; set; }

        /// <summary>
        /// ข้อความ เนื้อหาของ email
        /// </summary>
        /// <value>ข้อความ เนื้อหาของ email</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendEmail {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Fromemail: ").Append(Fromemail).Append("\n");
            sb.Append("  Toemail: ").Append(Toemail).Append("\n");
            sb.Append("  CCMyself: ").Append(CCMyself).Append("\n");
            sb.Append("  CcEmail: ").Append(CcEmail).Append("\n");
            sb.Append("  BccEmail: ").Append(BccEmail).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as SendEmail);
        }

        /// <summary>
        /// Returns true if SendEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.Fromemail == input.Fromemail ||
                    (this.Fromemail != null &&
                    this.Fromemail.Equals(input.Fromemail))
                ) && 
                (
                    this.Toemail == input.Toemail ||
                    (this.Toemail != null &&
                    this.Toemail.Equals(input.Toemail))
                ) && 
                (
                    this.CCMyself == input.CCMyself ||
                    (this.CCMyself != null &&
                    this.CCMyself.Equals(input.CCMyself))
                ) && 
                (
                    this.CcEmail == input.CcEmail ||
                    (this.CcEmail != null &&
                    this.CcEmail.Equals(input.CcEmail))
                ) && 
                (
                    this.BccEmail == input.BccEmail ||
                    (this.BccEmail != null &&
                    this.BccEmail.Equals(input.BccEmail))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.Fromemail != null)
                    hashCode = hashCode * 59 + this.Fromemail.GetHashCode();
                if (this.Toemail != null)
                    hashCode = hashCode * 59 + this.Toemail.GetHashCode();
                if (this.CCMyself != null)
                    hashCode = hashCode * 59 + this.CCMyself.GetHashCode();
                if (this.CcEmail != null)
                    hashCode = hashCode * 59 + this.CcEmail.GetHashCode();
                if (this.BccEmail != null)
                    hashCode = hashCode * 59 + this.BccEmail.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
