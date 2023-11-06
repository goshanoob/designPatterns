using System;
using System.Linq;

namespace Observer
{
    public class StatisticDisplay : IObserver, IDisplay
    {
        private WeatherData weatherData;
        private float[] temperatureHistory = { };
        private float[] humidityHistory = { };
        private float[] pressureHistory = { };

        public StatisticDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Update()
        {
            var length = temperatureHistory.Length;
            var tmpTemperatures = new float[length + 1];
            var tmpHumidity = new float[length + 1];
            var tmpPressure = new float[length + 1];

            temperatureHistory.CopyTo(tmpTemperatures, 0);
            humidityHistory.CopyTo(tmpHumidity, 0);
            pressureHistory.CopyTo(tmpPressure, 0);

            tmpTemperatures[length] = weatherData.GetTemperature();
            tmpHumidity[length] = weatherData.GetHumidity();
            tmpPressure[length] = weatherData.GetPressure();

            temperatureHistory = tmpTemperatures;
            humidityHistory = tmpHumidity;
            pressureHistory = tmpPressure;
            
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Среднее значение температуры {GetAverageValue(temperatureHistory)}");
            Console.WriteLine($"Среднее значение влажности {GetAverageValue(humidityHistory)}");
            Console.WriteLine($"Среднее значение давления {GetAverageValue(pressureHistory)}");
        }

        private float GetAverageValue(float[] history)
        {
            return history.Sum(item => item) / history.Length;
        }
    }
}