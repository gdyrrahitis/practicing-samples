namespace WebApiToTestsOn.Tests.Controllers.CustomValuesControllerTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Controllers;
    using System.Web.Http.Hosting;
    using Newtonsoft.Json;
    using NUnit.Framework;
    using WebApiToTestsOn.Controllers;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class ExecuteAsync
    {
        private const int Times = 10;
        private const string HttpLocalhostApiCustomvalues = "http://localhost/api/customvalues/";
        private CustomValuesController _controller;
        private readonly List<string> _expected = Enumerable.Repeat(string.Empty, Times).ToList();

        [SetUp]
        public void Setup()
        {
            _controller = new CustomValuesController();
        }

        [Test]
        public async Task ReturnsACollectionOfStringBasedOnNumberOnHeaders()
        {
            // Arrange
            var headerValue = _expected.Count.ToString();
            var controllerContext = SetupHttpConfigurationRequestAndContextWithHeaderConfigurable(headerValue);

            // Act
            var result = await _controller.ExecuteAsync(controllerContext, CancellationToken.None);
            var content = JsonConvert.DeserializeObject<List<string>>(await result.Content.ReadAsStringAsync());

            // Assert
            IsNotNull(result);
            AreEqual(HttpStatusCode.OK, result.StatusCode);
            IsNotNull(content);
            AreEqual(_expected.Count, content.Count);
        }

        private HttpControllerContext SetupHttpConfigurationRequestAndContextWithHeaderConfigurable(string headerValue)
        {
            var configuration = SetupHttpConfiguration();
            var request = SetupHttpRequestMessageWIthConfiguration(configuration);
            SetupRequestHeaderValue(request, headerValue);
            var controllerContext = SetupHttpControllerContext(request, configuration);
            return controllerContext;
        }

        private static HttpConfiguration SetupHttpConfiguration()
        {
            var configuration = new HttpConfiguration();
            configuration.EnsureInitialized();
            return configuration;
        }

        private static HttpRequestMessage SetupHttpRequestMessageWIthConfiguration(HttpConfiguration configuration)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, HttpLocalhostApiCustomvalues);
            request.Properties[HttpPropertyKeys.HttpConfigurationKey] = configuration;
            return request;
        }

        private static void SetupRequestHeaderValue(HttpRequestMessage request, string value)
        {
            request.Headers.Add("X-Number", value);
        }

        private static HttpControllerContext SetupHttpControllerContext(HttpRequestMessage request,
            HttpConfiguration configuration)
        {
            var controllerContext = new HttpControllerContext
            {
                Request = request,
                Configuration = configuration
            };
            return controllerContext;
        }

        [Test]
        public async Task NotValidHeaderValueReturnsBadRequest()
        {
            // Arrange
            const string headerValue = "not valid";
            var controllerContext = SetupHttpConfigurationRequestAndContextWithHeaderConfigurable(headerValue);

            // Act
            var result = await _controller.ExecuteAsync(controllerContext, CancellationToken.None);

            // Assert
            IsNotNull(result);
            AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
            IsNull(result.Content);
        }

        [Test]
        public async Task NoHeaderSetReturnsBadRequest()
        {
            // Arrange
            var configuration = SetupHttpConfiguration();
            var request = SetupHttpRequestMessageWIthConfiguration(configuration);
            var controllerContext = SetupHttpControllerContext(request, configuration);

            // Act
            var result = await _controller.ExecuteAsync(controllerContext, CancellationToken.None);

            // Assert
            IsNotNull(result);
            AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
            IsNull(result.Content);
        }

        [Test]
        public async Task MultipleValuesInHeaderReturnServerError()
        {
            // Arrange
            var configuration = SetupHttpConfiguration();
            var request = SetupHttpRequestMessageWIthConfiguration(configuration);
            SetupRequestHeaderValue(request, "1");
            SetupRequestHeaderValue(request, "2");
            var controllerContext = SetupHttpControllerContext(request, configuration);

            // Act
            var result = await _controller.ExecuteAsync(controllerContext, CancellationToken.None);

            // Assert
            IsNotNull(result);
            AreEqual(HttpStatusCode.InternalServerError, result.StatusCode);
            IsNotNull(result.Content);
        }

        [Test]
        [TestCase("GET", true)]
        [TestCase("POST", false)]
        [TestCase("PUT", false)]
        [TestCase("DELETE", false)]
        [TestCase("PATCH", false)]
        [TestCase("OPTIONS", false)]
        [TestCase("HEAD", false)]
        [TestCase("TRACE", false)]
        public async Task OnlyGetIsAllowed(string method, bool allowed)
        {
            // Arrange
            var configuration = SetupHttpConfiguration();
            var request = SetupHttpRequestMessageWithMethodAndConfiguration(new HttpMethod(method), configuration);
            SetupRequestHeaderValue(request, _expected.Count.ToString());
            var controllerContext = SetupHttpControllerContext(request, configuration);

            // Act
            var result = await _controller.ExecuteAsync(controllerContext, CancellationToken.None);

            // Assert
            IsNotNull(result);
            if (allowed)
            {
                var content = JsonConvert.DeserializeObject<List<string>>(await result.Content.ReadAsStringAsync());
                AreEqual(HttpStatusCode.OK, result.StatusCode);
                IsNotNull(content);
                AreEqual(_expected.Count, content.Count);
            }
            else
            {
                AreEqual(HttpStatusCode.MethodNotAllowed, result.StatusCode);
                IsNull(result.Content);
            }
        }

        private static HttpRequestMessage SetupHttpRequestMessageWithMethodAndConfiguration(HttpMethod method, HttpConfiguration configuration)
        {
            var request = new HttpRequestMessage(method, HttpLocalhostApiCustomvalues);
            request.Properties[HttpPropertyKeys.HttpConfigurationKey] = configuration;
            return request;
        }
    }
}