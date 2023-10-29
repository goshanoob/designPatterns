using System;
using System.Collections.Generic;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private List<IObserver> observers = new List<IObserver>();

        #region ISubject implementation

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            observers.ForEach(observer => observer.Update());
        }

        #endregion

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

        public void MeasurementsChanged(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            NotifyObservers();
        }
    }
}