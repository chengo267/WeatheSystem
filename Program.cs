using System;

namespace WeatherSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherCaller weatherCaller = new WeatherCaller();
            Validator validator = new Validator();
            
            Console.WriteLine("Enter a city name to get the current weather in it.\nFor exit type 'exit'");
            string city = Console.ReadLine();
            
            while(city != "exit")
            {
                try
                {
                   validator.InputValidation(city);
                   Console.WriteLine(weatherCaller.get(city));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                city = Console.ReadLine();
            }

        }
    }
}
