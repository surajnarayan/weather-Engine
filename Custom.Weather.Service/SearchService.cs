using Custom.Weather.Contracts.Interfaces;
using System;
using Custom.Weather.Contracts;
using System.Threading.Tasks;

namespace Custom.Weather.Service
{
    public class SearchService : IWeatherSearchService
    {
        public Task<SearchResponse> SearchAsync(SearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }
    }
}
