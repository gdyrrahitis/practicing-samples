namespace WebApiToTestsOn.Tests.RouteConstraints
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Routing;
    using NUnit.Framework;
    using WebApiToTestsOn.RouteConstraints;

    [TestFixture]
    public class OptionalRegexParameterTests
    {
        [Test]
        [TestCase("values", 5, true)]
        [TestCase("users", 45, true)]
        [TestCase("users", "$OPTIONAL$", true)]
        [TestCase("users", "ffaw", false)]
        public void OptionnalRegexParameter_IsMatch_Integers_Test(string controllerName, object parameter, bool expect)
        {
            // Arrange
            var pattern = @"\d+";
            var routeConstraint = new OptionalRegexRouteConstraint(pattern);
            var requestMessage = new HttpRequestMessage();
            var httpRoute = new HttpRoute("api/{controller}/{id}", new HttpRouteValueDictionary(new { controller = "values", id = RouteParameter.Optional }));
            parameter = Equals("$OPTIONAL$", parameter) ? RouteParameter.Optional : parameter;

            // Act
            var result = routeConstraint.Match(requestMessage, httpRoute, "id", new Dictionary<string, object> { { "controller", controllerName }, { "id", parameter } }, HttpRouteDirection.UriResolution);

            // Assert
            Assert.AreEqual(expect, result);
        }

        [Test]
        [TestCase("values", 5, false)]
        [TestCase("users", 45, false)]
        [TestCase("users", "$OPTIONAL$", true)]
        [TestCase("users", "CA761232-ED42-11CE-BACD-00AA0057B223", true)]
        [TestCase("users", "7e395569-3e8f-4113-91d5-687f10d50218", true)]
        [TestCase("users", "ffaw", false)]
        public void OptionnalRegexParameter_IsMatch_OnlyGuid_Test(string controllerName, object parameter, bool expect)
        {
            // Arrange
            var pattern = @"([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}";
            var routeConstraint = new OptionalRegexRouteConstraint(pattern);
            var requestMessage = new HttpRequestMessage();
            var httpRoute = new HttpRoute("api/{controller}/{id}", new HttpRouteValueDictionary(new { controller = "values", id = RouteParameter.Optional }));
            parameter = Equals("$OPTIONAL$", parameter) ? RouteParameter.Optional : parameter;
            Guid val;
            parameter = Guid.TryParse(parameter.ToString(), out val) ? val: parameter;

            // Act
            var result = routeConstraint.Match(requestMessage, httpRoute, "id", new Dictionary<string, object> { { "controller", controllerName }, { "id", parameter } }, HttpRouteDirection.UriResolution);

            // Assert
            Assert.AreEqual(expect, result);
        }
    }
}
