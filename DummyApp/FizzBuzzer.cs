using System;
using System.Collections.Generic;
using System.Text;

namespace DummyApp
{
    public class FizzBuzzer
    {
        public static string Getvalue(int input)
        {
            string output = "";
            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Fuzz";
            }

            output += input.ToString();
            return output;
        }
    }
}
