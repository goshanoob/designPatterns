using System;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver
    {
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Update()
        {
            Console.WriteLine($"Текущая температура {weatherData.GetTemperature()}");
            Console.WriteLine($"Текущая влажность {weatherData.GetHumidity()}");
            Console.WriteLine($"Текущее давление {weatherData.GetPressure()}");
        }
    }
}