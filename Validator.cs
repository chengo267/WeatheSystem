using System;
using System.Text.RegularExpressions;

namespace WeatherSystem
{
    class Validator
    {
        public void InputValidation(string inp)
        {
            if ((inp.Length <= 1) || (!Regex.IsMatch(inp, @"^[a-zA-Z ]+$")))
            {
                throw new Exception("Invalid Input");
            }
            return;
        }
    }
}
