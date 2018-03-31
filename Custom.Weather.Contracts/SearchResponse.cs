using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.Weather.Contracts
{
    public class SearchResponse
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public string Tempurature { get; set; }

        public string Pressure { get; set; }

        public string Humidity { get; set; }

        public string TempMin { get; set; }

        public string TempMax { get; set; }

        public string WindSpeed { get; set; }

    }
}
