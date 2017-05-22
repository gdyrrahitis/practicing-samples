namespace Web.Api.Samples.MessageHandlers
{
    using System.Diagnostics;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LogginHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Trace.WriteLine($"Incoming request: {request.Method} {request.RequestUri.AbsoluteUri}");
            return await base.SendAsync(request, cancellationToken).ContinueWith((task) =>
            {
                Trace.WriteLine($"Response to user");
                return task.Result;
            });
        }
    }
}