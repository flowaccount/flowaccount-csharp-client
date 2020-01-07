
# Flowaccount.OpenAPITools.Model.InlineDocumentAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UseInlineDiscount** | **bool** | ใช้งาน inline discount ส่วนลดแยกตามรายการสินค้า | [optional] [default to true]
**UseInlineVat** | **bool** | ใช้ inline vat ส่วนลดและภาษี แยกตามรายการสินค้า | [optional] 
**ExemptAmount** | **decimal?** | ยอดขายที่ยกเว้นภาษีมูลค่าเพิ่ม | [optional] [default to 0M]
**VatableAmount** | **decimal?** | ยอดขายที่คิดภาษีมูลค่าเพิ่ม | [optional] [default to 0M]
**Items** | [**List&lt;InlineProductItem&gt;**](InlineProductItem.md) |  | [optional] 
**DocumentReferences** | [**List&lt;UpgradeDocument&gt;**](UpgradeDocument.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

