// <copyright file="FacebookAppExtensionsTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookAppExtensions</summary>
    [PexClass(typeof(FacebookAppExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookAppExtensionsTest
    {
        /// <summary>Test stub for Api(FacebookAppBase, String, String)</summary>
        [PexMethod, PexAllowedException(typeof(FacebookApiException))]
        public object Api(
            FacebookAppBase app,
            string id,
            string path
        )
        {
            object result = FacebookAppExtensions.Api(app, id, path);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Api(FacebookAppBase, String, String)
        }

        /// <summary>Test stub for Api(FacebookAppBase, String, String, HttpMethod)</summary>
        [PexMethod, PexAllowedException(typeof(FacebookApiException))]
        public object Api01(
            FacebookAppBase app,
            string id,
            string path,
            HttpMethod httpMethod
        )
        {
            object result = FacebookAppExtensions.Api(app, id, path, httpMethod);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Api01(FacebookAppBase, String, String, HttpMethod)
        }

        /// <summary>Test stub for Api(FacebookAppBase, String, String, Object)</summary>
        [PexMethod]
        public object Api02(
            FacebookAppBase app,
            string id,
            string path,
            object parameters
        )
        {
            object result = FacebookAppExtensions.Api(app, id, path, parameters);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Api02(FacebookAppBase, String, String, Object)
        }

        /// <summary>Test stub for Api(FacebookAppBase, String, String, Object, HttpMethod)</summary>
        [PexMethod]
        public object Api03(
            FacebookAppBase app,
            string id,
            string path,
            object parameters,
            HttpMethod httpMethod
        )
        {
            object result = FacebookAppExtensions.Api(app, id, path, parameters, httpMethod)
              ;
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Api03(FacebookAppBase, String, String, Object, HttpMethod)
        }

        /// <summary>Test stub for Fql(FacebookApp, String)</summary>
        [PexMethod]
        public object Fql(FacebookApp app, string query)
        {
            object result = FacebookAppExtensions.Fql(app, query);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Fql(FacebookApp, String)
        }

        /// <summary>Test stub for Fql(FacebookApp, String[])</summary>
        [PexMethod]
        public object Fql01(FacebookApp app, string[] queries)
        {
            object result = FacebookAppExtensions.Fql(app, queries);
            return result;
            // TODO: add assertions to method FacebookAppExtensionsTest.Fql01(FacebookApp, String[])
        }
    }
}
