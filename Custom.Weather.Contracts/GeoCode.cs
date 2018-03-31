using System;

namespace Custom.Weather.Contracts
{
    public class GeoCode
    {
        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        public GeoCode(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
