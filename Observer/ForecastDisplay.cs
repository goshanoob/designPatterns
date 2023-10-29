using System;

namespace Observer
{
    public class ForecastDisplay : IObserver
    {
        private readonly WeatherData wheatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.wheatherData = weatherData;
        }

        public void Update()
        {
            Console.WriteLine($"Прогноз температуры {GetTemperatureForecast()}");
            Console.WriteLine($"Прогноз влажности {GetHumidityForecast()}");
            Console.WriteLine($"Прогноз давления {GetPressureForecast()}");
        }

        private float GetTemperatureForecast()
        {
            return WeatherData.GetRandomValue();
        }

        private float GetHumidityForecast()
        {
            return WeatherData.GetRandomValue();
        }

        private float GetPressureForecast()
        {
            return WeatherData.GetRandomValue();
        }
    }
}