using System;

namespace age_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
       Console.WriteLine(" type your age ? ");
int input = Console.ReadLine();
int born_year = Int32.Parse(input);
int this_year = 2021;
int you_age =  this_year - born_year;
Console.WriteLine($" your born year {you_age} ");
        }
    }
}
