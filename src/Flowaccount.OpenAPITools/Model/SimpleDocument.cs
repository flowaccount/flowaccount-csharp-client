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
    /// SimpleDocument
    /// </summary>
    [DataContract]
    public partial class SimpleDocument : Document,  IEquatable<SimpleDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDocument" /> class.
        /// </summary>
        /// <param name="items">รายการสินค้าใช้งานสำหรับเอกสาร Simple.</param>
        /// <param name="documentReference">สำหรับอัพเกรดเอกสาร โดยอ้างอิงเอกสารต้นทาง (ยกเว้นเอกสารใบเสนอราคา).</param>
        public SimpleDocument(List<SimpleProductItem> items = default(List<SimpleProductItem>), List<UpgradeDocument> documentReference = default(List<UpgradeDocument>), long recordId = 0, string contactCode = default(string), string contactName = default(string), string contactAddress = default(string), string contactTaxId = default(string), string contactBranch = default(string), string contactPerson = default(string), string contactEmail = default(string), string contactNumber = default(string), string contactZipCode = default(string), int contactGroup = 1, DateTime publishedOn = default(DateTime), int creditType = 1, int creditDays = 0, DateTime dueDate = default(DateTime), string salesName = "อีเมล หรือ ชื่อผู้สร้างเอกสาร", string projectName = default(string), string reference = default(string), bool isVatInclusive = false, bool useReceiptDeduction = false, decimal subTotal = 0M, int discountPercentage = 0, decimal discountAmount = 0M, decimal totalAfterDiscount = default(decimal), bool isVat = false, decimal vatAmount = default(decimal), decimal grandTotal = default(decimal), bool documentShowWithholdingTax = false, int documentWithholdingTaxPercentage = 0, decimal documentWithholdingTaxAmount = 0M, int documentDeductionType = 0, decimal documentDeductionAmount = 0M, string remarks = default(string), string internalNotes = default(string), bool showSignatureOrStamp = true, string documentStructureType = default(string)) : base(recordId, contactCode, contactName, contactAddress, contactTaxId, contactBranch, contactPerson, contactEmail, contactNumber, contactZipCode, contactGroup, publishedOn, creditType, creditDays, dueDate, salesName, projectName, reference, isVatInclusive, useReceiptDeduction, subTotal, discountPercentage, discountAmount, totalAfterDiscount, isVat, vatAmount, grandTotal, documentShowWithholdingTax, documentWithholdingTaxPercentage, documentWithholdingTaxAmount, documentDeductionType, documentDeductionAmount, remarks, internalNotes, showSignatureOrStamp, documentStructureType)
        {
            this.Items = items;
            this.DocumentReference = documentReference;
        }
        
        /// <summary>
        /// รายการสินค้าใช้งานสำหรับเอกสาร Simple
        /// </summary>
        /// <value>รายการสินค้าใช้งานสำหรับเอกสาร Simple</value>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<SimpleProductItem> Items { get; set; }

        /// <summary>
        /// สำหรับอัพเกรดเอกสาร โดยอ้างอิงเอกสารต้นทาง (ยกเว้นเอกสารใบเสนอราคา)
        /// </summary>
        /// <value>สำหรับอัพเกรดเอกสาร โดยอ้างอิงเอกสารต้นทาง (ยกเว้นเอกสารใบเสนอราคา)</value>
        [DataMember(Name="documentReference", EmitDefaultValue=true)]
        public List<UpgradeDocument> DocumentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleDocument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  DocumentReference: ").Append(DocumentReference).Append("\n");
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
            return this.Equals(input as SimpleDocument);
        }

        /// <summary>
        /// Returns true if SimpleDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleDocument input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && base.Equals(input) && 
                (
                    this.DocumentReference == input.DocumentReference ||
                    this.DocumentReference != null &&
                    input.DocumentReference != null &&
                    this.DocumentReference.SequenceEqual(input.DocumentReference)
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.DocumentReference != null)
                    hashCode = hashCode * 59 + this.DocumentReference.GetHashCode();
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
