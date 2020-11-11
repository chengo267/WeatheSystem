using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WeatherSystem
{
    class City
    {
        private string m_CityName;

        public City(string cityName)
        {
            city = cityName;
        }
        public string city
        {
            get { return m_CityName; }
            set { m_CityName = value; }
        }

        public bool isCity()
        {
            
            if ((city.Length <= 1) || (!Regex.IsMatch(city, @"^[a-zA-Z ]+$")))
            {
                return false;
            }
            return true;
        }
    }
}
