
# Flowaccount.OpenAPITools.Model.ExpenseInlineDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentSerial** | **string** | เลขที่เอกสาร | [optional] 
**ContactCode** | **string** | รหัส ผู้ติดต่อ/ผู้จำหน่าย | [optional] 
**ContactName** | **string** | ชื่อบริษัท | 
**ContactAddress** | **string** | ที่อยู่ ผู้ติดต่อ/ผู้จำหน่าย | [optional] 
**ContactTaxId** | **string** | เลขประจำตัวผู้เสียภาษี ผู้ติดต่อ/ผู้จำหน่าย | [optional] 
**ContactBranch** | **string** | สำนักงาน/สาขา | [optional] 
**ContactPerson** | **string** | ชื่อผู้ติดต่อ | [optional] 
**ContactEmail** | **string** | อีเมลผู้ติดต่อ | [optional] 
**ContactNumber** | **string** | เบอร์มือถือผู้ติดต่อ | [optional] 
**ContactZipCode** | **string** | รหัสไปรษณีย์ผู้ติดต่อ | [optional] 
**PublishedOn** | **DateTime** | วันที่เอกสาร รูปแบบ yyyy-MM-dd | 
**CreditType** | **int** | รูปแบบเครดิต: 1 &#x3D; เครดิต (วัน) / 5 &#x3D; เครดิต (ไม่แสดงวันที่ครบกำหนด) | [optional] [default to 1]
**CreditDays** | **int** | จำนวนวันที่ให้เครดิต | [optional] [default to 0]
**DueDate** | **DateTime** | วันครบกำหนดเอกสาร รูปแบบ yyyy-MM-dd | [optional] 
**SalesName** | **string** | พนักงานขาย | [optional] 
**ProjectName** | **string** | ชื่อโปรเจค | [optional] 
**Reference** | **string** | เลขที่อ้างอิง | [optional] 
**IsVatInclusive** | **bool** | มูลค่าเอกสารรวมภาษีแล้วหรือไม่ | [optional] [default to false]
**DiscountType** | **int** | รูปแบบส่วนลดสินค้าแต่ละรายการ: 1 &#x3D; รูปแบบเปอร์เซ็นต์ (%) / 3 &#x3D; รูปแบบจำนวนเงิน (฿) | [optional] [default to 1]
**Items** | [**List&lt;ExpenseInlineProductItem&gt;**](ExpenseInlineProductItem.md) |  | [optional] 
**SubTotal** | **decimal** | รวมยอดขาย | 
**DiscountAmount** | **decimal** | ส่วนลดรวม | [optional] [default to 0M]
**TotalAfterDiscount** | **decimal** | ยอดขายหลังหักส่วนลดรวม | 
**ExemptAmount** | **decimal** | ยอดขายที่ยกเว้นภาษีมูลค่าเพิ่ม | [optional] [default to 0M]
**VatableAmount** | **decimal** | ยอดขายที่คิดภาษีมูลค่าเพิ่ม | [optional] [default to 0M]
**VatAmount** | **decimal** | ภาษีมูลค่าเพิ่ม | [optional] [default to 0M]
**GrandTotal** | **decimal** | รวมทั้งสิ้น | 
**Remarks** | **string** | หมายเหตุ | [optional] 
**InternalNotes** | **string** | โน๊ตภายในบริษัท | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

