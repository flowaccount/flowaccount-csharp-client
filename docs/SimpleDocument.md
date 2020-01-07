
# Flowaccount.OpenAPITools.Model.SimpleDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordId** | **long** | id ของเอกสาร | [optional] [default to 0]
**DocumentSerial** | **string** | เลขที่เอกสาร | [optional] 
**ContactCode** | **string** | รหัส ผู้ติดต่อ/ผู้จำหน่าย | [optional] 
**ContactName** | **string** | ชื่อบริษัท | 
**ContactAddress** | **string** | ที่อยู่ ผู้ติดต่อ/ผู้จำหน่าย | [optional] 
**ContactTaxId** | **string** | เลขประจำตัวผู้เสียภาษี ผู้ติิดต่อ/ผู้จำหน่าย | [optional] 
**ContactBranch** | **string** | สำนักงาน/สาขา | [optional] 
**ContactPerson** | **string** | ชื่อผู้ติดต่อ | [optional] 
**ContactEmail** | **string** | อีเมลผู้ติดต่อ | [optional] 
**ContactNumber** | **string** | เบอร์มือถือผู้ติดต่อ | [optional] 
**ContactZipCode** | **string** | รหัสไปรษณีย์ติดต่อ | [optional] 
**ContactGroup** | **int** | ประผู้ติดต่อ 1 &#x3D; บุคคลธรรมดา / 3 &#x3D; นิติบุคคล | [optional] [default to 1]
**PublishedOn** | **DateTime** | วันที่เอกสาร รูปแบบ yyyy-MM-dd | 
**CreditType** | **int** | รูปแบบเครดิต: 1 &#x3D; เครดิต (วัน) / 3 &#x3D; เงินสด  / 5 &#x3D; เครดิต (ไม่แสดงวันที่ครบกำหนด) | [optional] [default to 1]
**CreditDays** | **int** | จำนวนวันที่ให้เครดิต | [optional] [default to 0]
**DueDate** | **DateTime** | วันครบกำหนดเอกสาร รูปแบบ yyyy-MM-dd | 
**SalesName** | **string** | ชื่อผู้สร้างเอกสาร หรือ ชื่อพนักงานขาย | [optional] [default to "email creator"]
**ProjectName** | **string** | ชื่อโปรเจค | [optional] 
**Reference** | **string** | เลขที่อ้างอิง หรือ เลขที่เอกสารที่เกี่ยวข้อง | [optional] 
**IsVatInclusive** | **bool** | มูลค่าเอกสารรวมภาษีแล้วหรือไม่ | [optional] [default to false]
**DiscountType** | **int** | รูปแบบส่วนลด 1 &#x3D;  เปอร์เซ็นต์ / 3 &#x3D; จำนวน (บาท) | [optional] [default to 1]
**DiscountPercentage** | **int** | มูลค่าส่วนลดเป็นเปอร์เซ็นต์ | [optional] [default to 0]
**DiscountAmount** | **decimal** | มูลค่าส่วนลดเป็นจำนวน | [optional] [default to 0M]
**SubTotal** | **decimal** | มูลค่ารวมเป็นเงิน | [optional] [default to 0M]
**TotalAfterDiscount** | **decimal** | มูลค่าหลังหักส่วนลด | 
**GrandTotal** | **decimal** | มูลค่าท้ายเอกสาร (รวม vat เสมอ) | 
**TotalWithoutVat** | **decimal** | มูลค่าเอกสารก่อนภาษี | [optional] 
**VatAmount** | **decimal** | ภาษีมูลค่าเพิ่ม | [optional] 
**DocumentShowWithholdingTax** | **bool** | แสดงหรือไแสดง หักณที่จ่ายท้ายบิล | [optional] [default to false]
**DocumentWithholdingTaxPercentage** | **int** | ภาษี ณ ที่จ่าย (%) | [optional] [default to 0]
**DocumentWithholdingTaxAmount** | **decimal** | มูลค่าภาษีหักณที่จ่าย | [optional] 
**Remarks** | **string** |  | [optional] 
**InternalNotes** | **string** | โน๊ตภายในบริษัท | [optional] 
**ShowSignatureOrStamp** | **bool** | ลายเซ็นอิเล็กทรอนิกส์และตรายาง | [optional] [default to true]
**PaymentMethod** | **int** | วิธีการชำระ 1 &#x3D; เงินสด / 3 &#x3D; เช็ค /  5 &#x3D; โอนเงิน , 7 &#x3D; เครดิต | [optional] [default to 0]
**PaymentDate** | **DateTime** | วันที่รับชำระเงิน รูปแบบ yyyy-MM-dd | [optional] 
**PaymentRemarks** | **string** | รายละเอียดการเก็บเงิน | [optional] 
**BankAccountName** | **string** | ชื่อธนาคาร | [optional] 
**BankAccountNumber** | **string** | เลขที่ธนาคาร/บัตรเคดิต(สำหรับ MethodPayment : 5, 7) | [optional] 
**Collected** | **decimal** | จำนวนเงินที่เก็บ | [optional] 
**WithheldAmount** | **decimal** | ยอดหัก ณ ที่จ่าย | [optional] 
**WithheldPercentage** | **int** | หัก ณ ที่จ่าย | [optional] 
**Fee** | **decimal** | ค่าธรรมเนียม | [optional] 
**DocumentStructureType** | **string** |  | 
**Items** | [**List&lt;SimpleProductItem&gt;**](SimpleProductItem.md) |  | [optional] 
**DocumentReferences** | [**List&lt;UpgradeDocument&gt;**](UpgradeDocument.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

