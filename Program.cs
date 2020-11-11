using System;
using System.Threading;

namespace WeatherSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherCaller weatherCaller = new WeatherCaller();
            
            Console.WriteLine("Enter a city name to get the current weather in it.\n For exit type 'exit'");
            string newCity = Console.ReadLine();
            
            while(newCity != "exit")
            {
                City city = new City(newCity);
                if (city.isCity())
                {
                   Console.WriteLine(weatherCaller.get(city.city).GetAwaiter().GetResult());
                }
                else
                {
                    Console.WriteLine("This is not a city, try again");
                }
                newCity = Console.ReadLine();
            }

        }
    }
}
