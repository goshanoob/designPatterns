using System;

namespace Observer
{
    public class StatisticDisplay : IObserver
    {
        private WeatherData weatherData;

        public StatisticDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Update()
        {
            Console.WriteLine($"Среднее значение температуры {GetAverageTemperature()}");
            Console.WriteLine($"Среднее значение влажности {GetAverageHumitiry()}");
            Console.WriteLine($"Среднее значение давления {GetAveragePressure()}");
        }

        private float GetAverageTemperature()
        {
            return WeatherData.GetRandomValue();
        }

        private float GetAverageHumitiry()
        {
            return WeatherData.GetRandomValue();
        }

        private float GetAveragePressure()
        {
            return WeatherData.GetRandomValue();
        }
    }
}