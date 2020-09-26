using System;

namespace WebAPIWithMerge
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Khanhnh { get; } = "I'm Khanh";

        public string Khanh_An { get; } = "Con gai An";

        public string cho { get; } = "Cho";
    }
}
