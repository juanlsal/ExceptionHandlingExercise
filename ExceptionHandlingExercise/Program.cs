using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '5', '8', '3', '1', '9', '6', 'j', 'l', 's' };
            var numbers = new List<int>();
            var str = "";
            foreach (var i in arr)
            {
                int number;
                str = i.ToString();
                try
                {
                    number = int.Parse(str);
                    numbers.Add(number);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"unable to parse {i}");
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}