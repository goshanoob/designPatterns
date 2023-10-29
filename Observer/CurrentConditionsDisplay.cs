using System;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private WeatherData weatherData;

        private float currentTemperature;
        private float currentHumidity;
        private float currentPressure;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Update()
        {
            currentTemperature = weatherData.GetTemperature();
            currentHumidity = weatherData.GetHumidity();
            currentPressure = weatherData.GetPressure();

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Текущая температура {currentTemperature}");
            Console.WriteLine($"Текущая влажность {currentHumidity}");
            Console.WriteLine($"Текущее давление {currentPressure}");
        }
    }
}