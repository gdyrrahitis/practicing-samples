using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApiToTestsOn.MessageHandlers
{
    public class CustomHeaderHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (HttpMethod.Post == request.Method && request.Headers.Contains("X-MY-CUSTOM"))
            {
                return base.SendAsync(request, cancellationToken);
            }

            var task = new TaskCompletionSource<HttpResponseMessage>();
            task.SetResult(new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Content = new StringContent("Should include the X-MY-CUSTOM header")
            });
            return task.Task;
        }
    }
}