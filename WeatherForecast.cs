using System;

namespace ReactBack
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string contactPerson { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string phoneNumber { get; set; }

    }
}
