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
    /// SendEmailCoppiesAllOf
    /// </summary>
    [DataContract]
    public partial class SendEmailCoppiesAllOf :  IEquatable<SendEmailCoppiesAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailCoppiesAllOf" /> class.
        /// </summary>
        /// <param name="doCopy">ส่งต้นฉบับ พร้อม สำเนา (default to true).</param>
        public SendEmailCoppiesAllOf(bool doCopy = true)
        {
            // use default value if no "doCopy" provided
            if (doCopy == null)
            {
                this.DoCopy = true;
            }
            else
            {
                this.DoCopy = doCopy;
            }
        }
        
        /// <summary>
        /// ส่งต้นฉบับ พร้อม สำเนา
        /// </summary>
        /// <value>ส่งต้นฉบับ พร้อม สำเนา</value>
        [DataMember(Name="doCopy", EmitDefaultValue=true)]
        public bool DoCopy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendEmailCoppiesAllOf {\n");
            sb.Append("  DoCopy: ").Append(DoCopy).Append("\n");
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
            return this.Equals(input as SendEmailCoppiesAllOf);
        }

        /// <summary>
        /// Returns true if SendEmailCoppiesAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEmailCoppiesAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEmailCoppiesAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DoCopy == input.DoCopy ||
                    (this.DoCopy != null &&
                    this.DoCopy.Equals(input.DoCopy))
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
                if (this.DoCopy != null)
                    hashCode = hashCode * 59 + this.DoCopy.GetHashCode();
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
