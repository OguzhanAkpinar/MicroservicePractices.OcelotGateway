namespace ECommerceBase.GateWay
{
    public class RequestLogger : DelegatingHandler
    {
        private readonly ILogger<RequestLogger> _logger;

        public RequestLogger(ILogger<RequestLogger> logger)
        {
            _logger = logger;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Request [{request.Method}] - {request.RequestUri}");
            return base.SendAsync(request, cancellationToken);
        }
    }
}
