using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.Weather.Contracts
{
    public class SearchRequest
    {
        public string Name { get; set; }

        public GeoCode Coordinates { get; set; }
    }
}
