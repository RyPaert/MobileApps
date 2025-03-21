using System.Text.Json;
using Constants;
using GroceryApp.Shared.Dtos;
using Models;

namespace Services
{
    public class OffersService : BaseApiService
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
        public class ProductsService : BaseApiService
        {
            public ProductsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
            {
            }
            public async Task<IEnumerable<ProductDto>> GetPopularProductsAsync()
            {
                var response = await HttpClient.GetAsync("/popular-products");
                return await HandleApiResponseAsync(response, Enumerable.Empty<ProductDto>());
            }
        }
    }
}
