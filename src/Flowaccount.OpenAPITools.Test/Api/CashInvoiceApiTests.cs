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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Flowaccount.OpenAPITools.Client;
using Flowaccount.OpenAPITools.Api;
using Flowaccount.OpenAPITools.Model;

namespace Flowaccount.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing CashInvoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CashInvoiceApiTests
    {
        private CashInvoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CashInvoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CashInvoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CashInvoiceApi
            //Assert.IsInstanceOf(typeof(CashInvoiceApi), instance);
        }

        
        /// <summary>
        /// Test CashInvoicesEmailDocumentPost
        /// </summary>
        [Test]
        public void CashInvoicesEmailDocumentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //SendEmailCoppies sendEmailCoppies = null;
            //var response = instance.CashInvoicesEmailDocumentPost(authorization, sendEmailCoppies);
            //Assert.IsInstanceOf(typeof(SendEmailResponse), response, "response is SendEmailResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesGet
        /// </summary>
        [Test]
        public void CashInvoicesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currentPage = null;
            //string pageSize = null;
            //string authorization = null;
            //string sortBy = null;
            //string filter = null;
            //var response = instance.CashInvoicesGet(currentPage, pageSize, authorization, sortBy, filter);
            //Assert.IsInstanceOf(typeof(InlineDocumentResponse), response, "response is InlineDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesIdAttachmentPost
        /// </summary>
        [Test]
        public void CashInvoicesIdAttachmentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //System.IO.Stream file = null;
            //var response = instance.CashInvoicesIdAttachmentPost(authorization, id, file);
            //Assert.IsInstanceOf(typeof(AttachmentResponse), response, "response is AttachmentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesIdDelete
        /// </summary>
        [Test]
        public void CashInvoicesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //var response = instance.CashInvoicesIdDelete(authorization, id);
            //Assert.IsInstanceOf(typeof(DeleteResponse), response, "response is DeleteResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesIdGet
        /// </summary>
        [Test]
        public void CashInvoicesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //var response = instance.CashInvoicesIdGet(authorization, id);
            //Assert.IsInstanceOf(typeof(InlineDocumentResponse), response, "response is InlineDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesIdPaymentPost
        /// </summary>
        [Test]
        public void CashInvoicesIdPaymentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //PaymentDocument paymentDocument = null;
            //var response = instance.CashInvoicesIdPaymentPost(authorization, id, paymentDocument);
            //Assert.IsInstanceOf(typeof(InlineDocumentResponse), response, "response is InlineDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesIdStatusKeyStatusIdPost
        /// </summary>
        [Test]
        public void CashInvoicesIdStatusKeyStatusIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //string statusId = null;
            //var response = instance.CashInvoicesIdStatusKeyStatusIdPost(authorization, id, statusId);
            //Assert.IsInstanceOf(typeof(InlineDocumentResponse), response, "response is InlineDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesInlinePost
        /// </summary>
        [Test]
        public void CashInvoicesInlinePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //InlineDocument inlineDocument = null;
            //var response = instance.CashInvoicesInlinePost(authorization, inlineDocument);
            //Assert.IsInstanceOf(typeof(InlineDocumentResponse), response, "response is InlineDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesPost
        /// </summary>
        [Test]
        public void CashInvoicesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //SimpleDocument simpleDocument = null;
            //var response = instance.CashInvoicesPost(authorization, simpleDocument);
            //Assert.IsInstanceOf(typeof(SimpleDocumentResponse), response, "response is SimpleDocumentResponse");
        }
        
        /// <summary>
        /// Test CashInvoicesSharedocumentPost
        /// </summary>
        [Test]
        public void CashInvoicesSharedocumentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //ShareDocument shareDocument = null;
            //var response = instance.CashInvoicesSharedocumentPost(authorization, shareDocument);
            //Assert.IsInstanceOf(typeof(ShareDocumentResponse), response, "response is ShareDocumentResponse");
        }
        
    }

}
