namespace Web.Api.Samples.RouteConstraints
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Web.Http;
    using System.Web.Http.Routing;

    public class OptionalRegexRouteConstraint : IHttpRouteConstraint
    {
        private readonly string _pattern;

        public OptionalRegexRouteConstraint(string pattern)
        {
            _pattern = pattern;
        }

        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values,
            HttpRouteDirection routeDirection)
        {
            var parameter = values[parameterName];
            if (parameter != RouteParameter.Optional)
            {
                var regex = new Regex($"^{_pattern}$");
                return regex.IsMatch(parameter.ToString());
            }
            return true;
        }
    }
}