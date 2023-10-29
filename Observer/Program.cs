using System;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var weather = new WeatherData();
            var heatIndex = new HeatIndexDisplay(weather);

            weather.AddObserver(new CurrentConditionsDisplay(weather));
            weather.AddObserver(new StatisticDisplay(weather));
            weather.AddObserver(new ForecastDisplay(weather));
            weather.AddObserver(heatIndex);

            weather.MeasurementsChanged(19f, 0.12f, 777f);
            Console.WriteLine("");
            weather.MeasurementsChanged(30f, 0.44f, 717f);
            Console.WriteLine("");
            weather.RemoveObserver(heatIndex);
            weather.MeasurementsChanged(40, 0.66f, 698f);
        }
    }
}