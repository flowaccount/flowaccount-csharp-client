# Flowaccount.OpenAPITools - the C# library for the FlowAccount Open API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2-oas3
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Flowaccount.OpenAPITools.Api;
using Flowaccount.OpenAPITools.Client;
using Flowaccount.OpenAPITools.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Flowaccount.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Flowaccount.OpenAPITools.Api;
using Flowaccount.OpenAPITools.Client;
using Flowaccount.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://openapi.flowaccount.com/v1";
            var apiInstance = new AuthenticationApi(Configuration.Default);
            var contentType = contentType_example;  // string |  (default to "application/x-www-form-urlencoded")
            var grantType = grantType_example;  // string |  (optional) 
            var scope = scope_example;  // string |  (optional) 
            var clientId = clientId_example;  // string |  (optional) 
            var clientSecret = clientSecret_example;  // string |  (optional) 

            try
            {
                // Generate Access Token
                AuthenResponse result = apiInstance.TokenPost(contentType, grantType, scope, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.TokenPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://openapi.flowaccount.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**TokenPost**](docs/AuthenticationApi.md#tokenpost) | **POST** /token | Generate Access Token
*BillingNotesApi* | [**BillingNotesEmailDocumentPost**](docs/BillingNotesApi.md#billingnotesemaildocumentpost) | **POST** /billing-notes/email-document | Send Email billing notes document
*BillingNotesApi* | [**BillingNotesGet**](docs/BillingNotesApi.md#billingnotesget) | **GET** /billing-notes | List all billing notes documents.
*BillingNotesApi* | [**BillingNotesIdAttachmentPost**](docs/BillingNotesApi.md#billingnotesidattachmentpost) | **POST** /billing-notes/{id}/attachment | Add Attachment to billing notes
*BillingNotesApi* | [**BillingNotesIdGet**](docs/BillingNotesApi.md#billingnotesidget) | **GET** /billing-notes/{id} | Get billing notes document
*BillingNotesApi* | [**BillingNotesIdStatusKeyStatusIdPost**](docs/BillingNotesApi.md#billingnotesidstatuskeystatusidpost) | **POST** /billing-notes/{id}/status-key/{statusId} | change status document billing notes
*BillingNotesApi* | [**BillingNotesInlinePost**](docs/BillingNotesApi.md#billingnotesinlinepost) | **POST** /billing-notes/inline | Create billing notes document with discount and tax inline.
*BillingNotesApi* | [**BillingNotesPost**](docs/BillingNotesApi.md#billingnotespost) | **POST** /billing-notes | Create billing notes document.
*BillingNotesApi* | [**BillingNotesSharedocumentPost**](docs/BillingNotesApi.md#billingnotessharedocumentpost) | **POST** /billing-notes/sharedocument | Share Document billing notes
*CashInvoiceApi* | [**CashInvoicesGet**](docs/CashInvoiceApi.md#cashinvoicesget) | **GET** /cash-invoices | List all documents
*CashInvoiceApi* | [**CashInvoicesIdDelete**](docs/CashInvoiceApi.md#cashinvoicesiddelete) | **DELETE** /cash-invoices/{id} | Delete document
*CashInvoiceApi* | [**CashInvoicesIdGet**](docs/CashInvoiceApi.md#cashinvoicesidget) | **GET** /cash-invoices/{id} | Get document
*CashInvoiceApi* | [**CashInvoicesIdPut**](docs/CashInvoiceApi.md#cashinvoicesidput) | **PUT** /cash-invoices/{id} | Update document
*CashInvoiceApi* | [**CashInvoicesPost**](docs/CashInvoiceApi.md#cashinvoicespost) | **POST** /cash-invoices | Create Document
*ExpenseApi* | [**ExpensesCategoriesAccountingGet**](docs/ExpenseApi.md#expensescategoriesaccountingget) | **GET** /expenses/categories/accounting | Accounting categorys
*ExpenseApi* | [**ExpensesCategoriesBusinessGet**](docs/ExpenseApi.md#expensescategoriesbusinessget) | **GET** /expenses/categories/business | Business categorys
*ExpenseApi* | [**ExpensesGet**](docs/ExpenseApi.md#expensesget) | **GET** /expenses | List expense documents.
*ExpenseApi* | [**ExpensesIdAttachmentPost**](docs/ExpenseApi.md#expensesidattachmentpost) | **POST** /expenses/{id}/attachment | Add Attachment to expense
*ExpenseApi* | [**ExpensesIdGet**](docs/ExpenseApi.md#expensesidget) | **GET** /expenses/{id} | Get expense document
*ExpenseApi* | [**ExpensesIdInlineGet**](docs/ExpenseApi.md#expensesidinlineget) | **GET** /expenses/{id}/inline | Get expense document
*ExpenseApi* | [**ExpensesInlinePost**](docs/ExpenseApi.md#expensesinlinepost) | **POST** /expenses/inline | Create expense document with discount and tax inline.
*ExpenseApi* | [**ExpensesPost**](docs/ExpenseApi.md#expensespost) | **POST** /expenses | Create expense document.
*QuotationsApi* | [**QuotationsEmailDocumentPost**](docs/QuotationsApi.md#quotationsemaildocumentpost) | **POST** /quotations/email-document | Send Email quotations document
*QuotationsApi* | [**QuotationsGet**](docs/QuotationsApi.md#quotationsget) | **GET** /quotations | List all quotations documents.
*QuotationsApi* | [**QuotationsIdAttachmentPost**](docs/QuotationsApi.md#quotationsidattachmentpost) | **POST** /quotations/{id}/attachment | Add Attachment to quotations
*QuotationsApi* | [**QuotationsIdGet**](docs/QuotationsApi.md#quotationsidget) | **GET** /quotations/{id} | Get quotations document
*QuotationsApi* | [**QuotationsIdStatusKeyStatusIdPost**](docs/QuotationsApi.md#quotationsidstatuskeystatusidpost) | **POST** /quotations/{id}/status-key/{statusId} | change status document quotations
*QuotationsApi* | [**QuotationsInlinePost**](docs/QuotationsApi.md#quotationsinlinepost) | **POST** /quotations/inline | Create quotations document with discount and tax inline.
*QuotationsApi* | [**QuotationsPost**](docs/QuotationsApi.md#quotationspost) | **POST** /quotations | Create quotations document.
*QuotationsApi* | [**QuotationsSharedocumentPost**](docs/QuotationsApi.md#quotationssharedocumentpost) | **POST** /quotations/sharedocument | Share Document quotations
*ReportApi* | [**ReportCultureSalePost**](docs/ReportApi.md#reportculturesalepost) | **POST** /report/{culture}/sale | 
*TaxInvoiceApi* | [**TaxInvoicesEmailDocumentPost**](docs/TaxInvoiceApi.md#taxinvoicesemaildocumentpost) | **POST** /tax-invoices/email-document | Send Email tax invoice document
*TaxInvoiceApi* | [**TaxInvoicesGet**](docs/TaxInvoiceApi.md#taxinvoicesget) | **GET** /tax-invoices | List tax invocie documents.
*TaxInvoiceApi* | [**TaxInvoicesIdAttachmentPost**](docs/TaxInvoiceApi.md#taxinvoicesidattachmentpost) | **POST** /tax-invoices/{id}/attachment | Add Attachment to Tax Invoice
*TaxInvoiceApi* | [**TaxInvoicesIdGet**](docs/TaxInvoiceApi.md#taxinvoicesidget) | **GET** /tax-invoices/{id} | Get document
*TaxInvoiceApi* | [**TaxInvoicesIdInlinePut**](docs/TaxInvoiceApi.md#taxinvoicesidinlineput) | **PUT** /tax-invoices/{id}/inline | Update document
*TaxInvoiceApi* | [**TaxInvoicesIdPut**](docs/TaxInvoiceApi.md#taxinvoicesidput) | **PUT** /tax-invoices/{id} | Update document
*TaxInvoiceApi* | [**TaxInvoicesIdStatusKeyStatusIdPost**](docs/TaxInvoiceApi.md#taxinvoicesidstatuskeystatusidpost) | **POST** /tax-invoices/{id}/status-key/{statusId} | change status document tax invoices
*TaxInvoiceApi* | [**TaxInvoicesInlinePost**](docs/TaxInvoiceApi.md#taxinvoicesinlinepost) | **POST** /tax-invoices/inline | Create tax invocie document with discount and tax inline.
*TaxInvoiceApi* | [**TaxInvoicesPost**](docs/TaxInvoiceApi.md#taxinvoicespost) | **POST** /tax-invoices | Create tax invocie document.
*TaxInvoiceApi* | [**TaxInvoicesSharedocumentPost**](docs/TaxInvoiceApi.md#taxinvoicessharedocumentpost) | **POST** /tax-invoices/sharedocument | Share Document tax invoice


## Documentation for Models

 - [Model.AuthenResponse](docs/AuthenResponse.md)
 - [Model.BusinessCategory](docs/BusinessCategory.md)
 - [Model.Document](docs/Document.md)
 - [Model.DocumentResponse](docs/DocumentResponse.md)
 - [Model.ExpenseDocument](docs/ExpenseDocument.md)
 - [Model.ExpenseDocumentResponse](docs/ExpenseDocumentResponse.md)
 - [Model.ExpenseInlineDocument](docs/ExpenseInlineDocument.md)
 - [Model.ExpenseInlineProductItem](docs/ExpenseInlineProductItem.md)
 - [Model.ExpenseSimpleProductItem](docs/ExpenseSimpleProductItem.md)
 - [Model.ExpensenlineDocumentResponse](docs/ExpensenlineDocumentResponse.md)
 - [Model.InlineDocument](docs/InlineDocument.md)
 - [Model.InlineDocumentAllOf](docs/InlineDocumentAllOf.md)
 - [Model.InlineDocumentResponse](docs/InlineDocumentResponse.md)
 - [Model.InlineDocumentResponseAllOf](docs/InlineDocumentResponseAllOf.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.InlineObject3](docs/InlineObject3.md)
 - [Model.InlineObject4](docs/InlineObject4.md)
 - [Model.InlineProductItem](docs/InlineProductItem.md)
 - [Model.InlineProductItemAllOf](docs/InlineProductItemAllOf.md)
 - [Model.ProductItem](docs/ProductItem.md)
 - [Model.ReferencedByMe](docs/ReferencedByMe.md)
 - [Model.ReferencedToMe](docs/ReferencedToMe.md)
 - [Model.SendEmail](docs/SendEmail.md)
 - [Model.SendEmailCoppies](docs/SendEmailCoppies.md)
 - [Model.SendEmailCoppiesAllOf](docs/SendEmailCoppiesAllOf.md)
 - [Model.SendEmailResponse](docs/SendEmailResponse.md)
 - [Model.SendEmailSimple](docs/SendEmailSimple.md)
 - [Model.ShareDocument](docs/ShareDocument.md)
 - [Model.ShareDocumentResponse](docs/ShareDocumentResponse.md)
 - [Model.SimpleDocument](docs/SimpleDocument.md)
 - [Model.SimpleDocumentAllOf](docs/SimpleDocumentAllOf.md)
 - [Model.SimpleDocumentResponse](docs/SimpleDocumentResponse.md)
 - [Model.SimpleDocumentResponseAllOf](docs/SimpleDocumentResponseAllOf.md)
 - [Model.SimpleProductItem](docs/SimpleProductItem.md)
 - [Model.StatusResponse](docs/StatusResponse.md)
 - [Model.UpgradeDocument](docs/UpgradeDocument.md)


## Documentation for Authorization

All endpoints do not require authorization.
