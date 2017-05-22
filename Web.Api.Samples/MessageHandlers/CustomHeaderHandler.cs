namespace Web.Api.Samples.MessageHandlers
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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