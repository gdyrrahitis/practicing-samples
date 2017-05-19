namespace WebApiToTestsOn.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Http.Controllers;

    public class CustomValuesController : IHttpController
    {
        public Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        {
            if (IsRequestMethodGet(controllerContext))
            {
                IEnumerable<string> values;
                if (controllerContext.Request.Headers.TryGetValues("X-Number", out values))
                {
                    try
                    {
                        int count;
                        if (int.TryParse(values.SingleOrDefault(), out count))
                        {
                            var list = Enumerable.Repeat(string.Empty, count);
                            return Task.FromResult(controllerContext.Request.CreateResponse(HttpStatusCode.OK, list));
                        }
                    }
                    catch (Exception ex)
                    {
                        return
                            Task.FromResult(controllerContext.Request.CreateErrorResponse(
                                HttpStatusCode.InternalServerError, ex));
                    }

                    return Task.FromResult(controllerContext.Request.CreateResponse(HttpStatusCode.BadRequest));
                }

                return Task.FromResult(controllerContext.Request.CreateResponse(HttpStatusCode.BadRequest));
            }

            return Task.FromResult(controllerContext.Request.CreateResponse(HttpStatusCode.MethodNotAllowed));
        }

        private static bool IsRequestMethodGet(HttpControllerContext controllerContext)
        {
            return controllerContext.Request.Method == HttpMethod.Get;
        }
    }
}