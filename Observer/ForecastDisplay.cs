using System;
using System.Collections.Generic;

namespace Observer
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private WeatherData weatherData;
        private List<float> temperatureHistory = new List<float>();
        private List<float> humidityHistory = new List<float>();
        private List<float> pressureHistory = new List<float>();

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Update()
        {
            temperatureHistory.Add(weatherData.GetTemperature());
            humidityHistory.Add(weatherData.GetHumidity());
            pressureHistory.Add(weatherData.GetPressure());
            
            Display();
        }

        public void Display()
        {
            if (temperatureHistory.Count < 2)
            {
                Console.WriteLine($"Не хватает наблюдений для прогноза.");
                return;
            }
            
            Console.WriteLine($"Прогноз температуры {GetForecastValue(temperatureHistory)}");
            Console.WriteLine($"Прогноз влажности {GetForecastValue(humidityHistory)}");
            Console.WriteLine($"Прогноз давления {GetForecastValue(pressureHistory)}");
        }

        // Прогнозирование с помощью линейного тренда.
        // https://bookaa.ru/operatsionnyy-menedzhment/postroenie-linejnogo-trenda.html
        private float GetForecastValue(List<float> history)
        {
            var count = history.Count;
            var sumX = 0f;
            var sumX2 = 0f;
            var sumY = 0f;
            var sum = 0f;

            for (var x = 1; x <= count; x++)
            {
                sumX += x;
                sumX2 += x * x;
                sumY += history[x - 1];
                sum += x * history[x - 1];
            }

            var srX = sumX / count;
            var srY = sumY / count;
            var b = (sum - count * srX * srY) / (sumX2 - count * srX * srX);
            var a = srY - b * srX;
            
            return  a + b * (count + 1);
        }
    }
}