using System;

namespace DotNet5WebApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public float TemperatureC { get; set; }

        public float TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public bool IsFreezing() => TemperatureC == 0;

        public bool IsBelowFreezing()
        {
            return TemperatureC < 0;

        }

        public void emptymethod()
        {
            try
            {

            }
            catch
            {
                throw NotSupportedException();
            }

        }

        public bool IsAboveFreezing => TemperatureC > 0;

        public string Summary { get; set; }

        public enum Test
        {
            a = 1,
            b = 2
        }
    }
}
