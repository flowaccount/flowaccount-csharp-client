
# Flowaccount.OpenAPITools.Model.InlineProductItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentStructureType** | **string** |  | 
**Type** | **int** | ประเภทสินค้า 1 &#x3D; บริการ, 3 &#x3D; สินค้าไม่นับส๊อก, 5 &#x3D; สินค้านับสต๊ฮก | [optional] [default to 1]
**Name** | **string** | ชื่อสินค้า | 
**Description** | **string** | รายละเอียดสินค้า | [optional] 
**Quantity** | **decimal** | จำนวนสินค้า | 
**UnitName** | **string** | หน่วยสินค้า | [optional] 
**PricePerUnit** | **decimal** | ราคาสินค้าต่อหน่วย | 
**Total** | **decimal** | ราคารวมสินค้า | 
**DiscountAmountPercentage** | **int** | ส่วนลดสินค้า (%) | [optional] [default to 0]
**DiscountAmount** | **decimal** | ส่วนลดสินค้า | [optional] [default to 0M]
**VatRate** | **int** | ภาษี: 7 &#x3D; 7% / 0 &#x3D; 0% / -1 &#x3D; ยกเว้นภาษี | [optional] [default to 7]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

