
# Flowaccount.OpenAPITools.Model.ExpenseDocument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
**PublishedOn** | **DateTime** | วันที่เอกสาร รูปแบบ yyyy-MM-dd | 
**CreditType** | **int** | รูปแบบเครดิต: 1 &#x3D; เครดิต (วัน) / 5 &#x3D; เครดิต (ไม่แสดงวันที่ครบกำหนด) | [optional] [default to 1]
**CreditDays** | **int** | จำนวนวันที่ให้เครดิต | [optional] [default to 0]
**DueDate** | **DateTime** | วันครบกำหนดเอกสาร รูปแบบ yyyy-MM-dd | [optional] 
**SalesName** | **string** | พนักงานขาย | [optional] 
**ProjectName** | **string** | ชื่อโปรเจค | [optional] 
**Reference** | **string** | เลขที่อ้างอิง | [optional] 
**IsVatInclusive** | **bool** | ราคาสินค้ารวมภาษีมูลค่าเพิ่มหรือไม่ | [optional] [default to false]
**Items** | [**List&lt;ExpenseSimpleProductItem&gt;**](ExpenseSimpleProductItem.md) |  | [optional] 
**SubTotal** | **decimal** | ยอดขายรวม | 
**DiscountPercentage** | **int** | ส่วนลด (%) | [optional] 
**DiscountAmount** | **decimal** | ส่วนลดรวม | [optional] 
**TotalAfterDiscount** | **decimal** | ยอดขายหลังหักส่วนลด | 
**IsVat** | **bool** | ยอดขายหลังหักส่วนลดรวมภาษีมูลค่าเพิ่มหรือไม่ | [optional] [default to false]
**VatAmount** | **decimal** | ภาษีมูลค่าเพิ่ม | [optional] 
**GrandTotal** | **decimal** | รวมทั้งสิ้น | 
**Remarks** | **string** | หมายเหตุ | [optional] 
**InternalNotes** | **string** | โน๊ตภายในบริษัท | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

