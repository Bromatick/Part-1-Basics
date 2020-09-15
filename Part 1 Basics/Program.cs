using System;

namespace Part_1_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("N   N   L"    );
            Console.WriteLine("NN  N   L"    );
            Console.WriteLine("N N N   L"    );
            Console.WriteLine("N  NN   L"    );
            Console.WriteLine("N   N   L"    );
            Console.WriteLine("N   N   L"    );
            Console.WriteLine("N   N   LLLLL");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string firstName = "Niklas";
            string favMovie = "UP";
            Console.WriteLine($"hi my name is {firstName} and my favorite movie is {favMovie}.");
            favMovie = (favMovie.ToUpper());
            Console.WriteLine($"{favMovie}");
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine(favMovie.Replace("A", "@").Replace("E", "3"));
        }
    }
}
