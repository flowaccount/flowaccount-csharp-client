# Flowaccount.OpenAPITools.Api.ReportApi

All URIs are relative to *https://openapi.flowaccount.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportCultureSalePost**](ReportApi.md#reportculturesalepost) | **POST** /report/{culture}/sale | 



## ReportCultureSalePost

> System.IO.Stream ReportCultureSalePost (string culture, string authorization)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Flowaccount.OpenAPITools.Api;
using Flowaccount.OpenAPITools.Client;
using Flowaccount.OpenAPITools.Model;

namespace Example
{
    public class ReportCultureSalePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://openapi.flowaccount.com/v1";
            var apiInstance = new ReportApi(Configuration.Default);
            var culture = culture_example;  // string |  (default to "en, th")
            var authorization = authorization_example;  // string |  (default to "Bearer accessToken")

            try
            {
                System.IO.Stream result = apiInstance.ReportCultureSalePost(culture, authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportApi.ReportCultureSalePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **culture** | **string**|  | [default to &quot;en, th&quot;]
 **authorization** | **string**|  | [default to &quot;Bearer accessToken&quot;]

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/vnd.ms-excel

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 200 response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

