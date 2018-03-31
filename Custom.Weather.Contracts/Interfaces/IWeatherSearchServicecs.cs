using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Custom.Weather.Contracts.Interfaces
{
    public interface IWeatherSearchService
    {
        Task<SearchResponse> SearchAsync(SearchRequest searchRequest);
    }
}
