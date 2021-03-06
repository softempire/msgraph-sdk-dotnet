﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Core.Test.Extensions
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Net.Http;

    [TestClass]
    public class RequestExtensionsTests
    {
        [TestMethod]
        public void IsBuffered_Get()
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, "http://example.com");
            var response = httpRequest.IsBuffered();

            Assert.IsTrue(response, "Unexpected content type");
        }
        [TestMethod]
        public void IsBuffered_PostWithNoContent()
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, "http://example.com");
            var response = httpRequest.IsBuffered();

            Assert.IsTrue(response, "Unexpected content type");
        }
        [TestMethod]
        public void IsBuffered_PostWithBufferStringContent()
        {
            byte[] data = new byte[] { 1, 2, 3, 4, 5 };
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, "http://example.com");
            httpRequest.Content = new ByteArrayContent(data);
            var response = httpRequest.IsBuffered();

            Assert.IsTrue(response, "Unexpected content type");
        }

        [TestMethod]
        public void IsBuffered_PutWithStreamStringContent()
        {
            var stringContent = new StringContent("Hello World");
            var byteArrayContent = new ByteArrayContent(new byte[] { 1, 2, 3, 4, 5 });
            var mutliformDataContent = new MultipartFormDataContent();
            mutliformDataContent.Add(stringContent);
            mutliformDataContent.Add(byteArrayContent);

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Put, "http://example.com");
            httpRequest.Content = mutliformDataContent;
            httpRequest.Content.Headers.ContentLength = -1;
            var response = httpRequest.IsBuffered();

            Assert.IsFalse(response, "Unexpected content type");
        }

        [TestMethod]
        public void IsBuffered_PatchWithStreamStringContent()
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(new HttpMethod("PATCH"), "http://example.com");
            httpRequest.Content = new StringContent("Hello World");
            httpRequest.Content.Headers.ContentLength = null;
            var response = httpRequest.IsBuffered();

            Assert.IsFalse(response, "Unexpected content type");
        }
    }
}
