using System;

namespace age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
       Console.Write(" type your age :");
int born_year = Convert.ToInt32(Console.ReadLine());
int this_year = 2021;
int you_age =  this_year - born_year;
Console.WriteLine($" your born year {you_age} ");
        }
    }
}
