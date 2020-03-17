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
    /// InlineDocumentAllOf
    /// </summary>
    [DataContract]
    public partial class InlineDocumentAllOf :  IEquatable<InlineDocumentAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDocumentAllOf" /> class.
        /// </summary>
        /// <param name="discountType">รูปแบบส่วนลดในเอกสาร กรณีใช้รูปแบบ Inline ส่วนลด หรือ ภาษี แยกตามรายการสินค้า &lt;br&gt; สามารถเลือกรูปแบบส่วนลดได้ &lt;br&gt; 1 &#x3D;  เปอร์เซ็นต์ &lt;br&gt; 3 &#x3D; จำนวน (บาท) (default to 1).</param>
        /// <param name="useInlineDiscount">inline discount ใช้งานส่วนลด แยกตามรายการสินค้า (default to true).</param>
        /// <param name="useInlineVat">inline vat ใช้งานส่วนลดและภาษี แยกตามรายการสินค้า.</param>
        /// <param name="exemptAmount">ยอดขายที่ยกเว้นภาษีมูลค่าเพิ่ม (default to 0M).</param>
        /// <param name="vatableAmount">ยอดขายที่คิดภาษีมูลค่าเพิ่ม (default to 0M).</param>
        /// <param name="items">รายการสินค้าใช้งานสำหรับเอกสาร Simple.</param>
        /// <param name="documentReference">สำหรับอัพเกรดเอกสาร โดยอ้างอิงเอกสารต้นทาง (ยกเว้นเอกสารใบเสนอราคา).</param>
        public InlineDocumentAllOf(int discountType = 1, bool useInlineDiscount = true, bool useInlineVat = default(bool), decimal? exemptAmount = 0M, decimal? vatableAmount = 0M, List<InlineProductItem> items = default(List<InlineProductItem>), List<UpgradeDocument> documentReference = default(List<UpgradeDocument>))
        {
            this.ExemptAmount = exemptAmount;
            this.VatableAmount = vatableAmount;
            // use default value if no "discountType" provided
            if (discountType == null)
            {
                this.DiscountType = 1;
            }
            else
            {
                this.DiscountType = discountType;
            }
            // use default value if no "useInlineDiscount" provided
            if (useInlineDiscount == null)
            {
                this.UseInlineDiscount = true;
            }
            else
            {
                this.UseInlineDiscount = useInlineDiscount;
            }
            this.UseInlineVat = useInlineVat;
            // use default value if no "exemptAmount" provided
            if (exemptAmount == null)
            {
                this.ExemptAmount = 0M;
            }
            else
            {
                this.ExemptAmount = exemptAmount;
            }
            // use default value if no "vatableAmount" provided
            if (vatableAmount == null)
            {
                this.VatableAmount = 0M;
            }
            else
            {
                this.VatableAmount = vatableAmount;
            }
            this.Items = items;
            this.DocumentReference = documentReference;
        }
        
        /// <summary>
        /// รูปแบบส่วนลดในเอกสาร กรณีใช้รูปแบบ Inline ส่วนลด หรือ ภาษี แยกตามรายการสินค้า &lt;br&gt; สามารถเลือกรูปแบบส่วนลดได้ &lt;br&gt; 1 &#x3D;  เปอร์เซ็นต์ &lt;br&gt; 3 &#x3D; จำนวน (บาท)
        /// </summary>
        /// <value>รูปแบบส่วนลดในเอกสาร กรณีใช้รูปแบบ Inline ส่วนลด หรือ ภาษี แยกตามรายการสินค้า &lt;br&gt; สามารถเลือกรูปแบบส่วนลดได้ &lt;br&gt; 1 &#x3D;  เปอร์เซ็นต์ &lt;br&gt; 3 &#x3D; จำนวน (บาท)</value>
        [DataMember(Name="discountType", EmitDefaultValue=true)]
        public int DiscountType { get; set; }

        /// <summary>
        /// inline discount ใช้งานส่วนลด แยกตามรายการสินค้า
        /// </summary>
        /// <value>inline discount ใช้งานส่วนลด แยกตามรายการสินค้า</value>
        [DataMember(Name="useInlineDiscount", EmitDefaultValue=true)]
        public bool UseInlineDiscount { get; set; }

        /// <summary>
        /// inline vat ใช้งานส่วนลดและภาษี แยกตามรายการสินค้า
        /// </summary>
        /// <value>inline vat ใช้งานส่วนลดและภาษี แยกตามรายการสินค้า</value>
        [DataMember(Name="useInlineVat", EmitDefaultValue=true)]
        public bool UseInlineVat { get; set; }

        /// <summary>
        /// ยอดขายที่ยกเว้นภาษีมูลค่าเพิ่ม
        /// </summary>
        /// <value>ยอดขายที่ยกเว้นภาษีมูลค่าเพิ่ม</value>
        [DataMember(Name="exemptAmount", EmitDefaultValue=true)]
        public decimal? ExemptAmount { get; set; }

        /// <summary>
        /// ยอดขายที่คิดภาษีมูลค่าเพิ่ม
        /// </summary>
        /// <value>ยอดขายที่คิดภาษีมูลค่าเพิ่ม</value>
        [DataMember(Name="vatableAmount", EmitDefaultValue=true)]
        public decimal? VatableAmount { get; set; }

        /// <summary>
        /// รายการสินค้าใช้งานสำหรับเอกสาร Simple
        /// </summary>
        /// <value>รายการสินค้าใช้งานสำหรับเอกสาร Simple</value>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<InlineProductItem> Items { get; set; }

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
            sb.Append("class InlineDocumentAllOf {\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  UseInlineDiscount: ").Append(UseInlineDiscount).Append("\n");
            sb.Append("  UseInlineVat: ").Append(UseInlineVat).Append("\n");
            sb.Append("  ExemptAmount: ").Append(ExemptAmount).Append("\n");
            sb.Append("  VatableAmount: ").Append(VatableAmount).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  DocumentReference: ").Append(DocumentReference).Append("\n");
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
            return this.Equals(input as InlineDocumentAllOf);
        }

        /// <summary>
        /// Returns true if InlineDocumentAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineDocumentAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineDocumentAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiscountType == input.DiscountType ||
                    (this.DiscountType != null &&
                    this.DiscountType.Equals(input.DiscountType))
                ) && 
                (
                    this.UseInlineDiscount == input.UseInlineDiscount ||
                    (this.UseInlineDiscount != null &&
                    this.UseInlineDiscount.Equals(input.UseInlineDiscount))
                ) && 
                (
                    this.UseInlineVat == input.UseInlineVat ||
                    (this.UseInlineVat != null &&
                    this.UseInlineVat.Equals(input.UseInlineVat))
                ) && 
                (
                    this.ExemptAmount == input.ExemptAmount ||
                    (this.ExemptAmount != null &&
                    this.ExemptAmount.Equals(input.ExemptAmount))
                ) && 
                (
                    this.VatableAmount == input.VatableAmount ||
                    (this.VatableAmount != null &&
                    this.VatableAmount.Equals(input.VatableAmount))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
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
                int hashCode = 41;
                if (this.DiscountType != null)
                    hashCode = hashCode * 59 + this.DiscountType.GetHashCode();
                if (this.UseInlineDiscount != null)
                    hashCode = hashCode * 59 + this.UseInlineDiscount.GetHashCode();
                if (this.UseInlineVat != null)
                    hashCode = hashCode * 59 + this.UseInlineVat.GetHashCode();
                if (this.ExemptAmount != null)
                    hashCode = hashCode * 59 + this.ExemptAmount.GetHashCode();
                if (this.VatableAmount != null)
                    hashCode = hashCode * 59 + this.VatableAmount.GetHashCode();
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
            yield break;
        }
    }

}
