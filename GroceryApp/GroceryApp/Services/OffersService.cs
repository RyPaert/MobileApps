using Models;

namespace Services
{
    public partial class OffersService : BaseApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OffersService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<Offer>> GetActiveOffersAsync()
        {
            var response = await HttpClient.GetAsync("/masters/offers");
            return await HandleApiResponseAsync(response, Enumerable.Empty<Offer>());
        }
    }
}
