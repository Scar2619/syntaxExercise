using System;

namespace syntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}


            //inferred typing
            //var answer = 4;
            //if (answer < 9)
            //{
            //    Console.WriteLine("answer" + " is less than nine.");
            //}
            //else
            //{
            //    Console.WriteLine("answer" + " is greater than or equal to nine");
            //}


            //string interpolation
            //var answer = 4;

            //if (answer < 9)
            //{
            //    Console.WriteLine($"{answer} is less than nine.");
            //}
            //else
            //{
            //    Console.WriteLine($"{answer} is greater than nine");
            //}


            //ternary
            var answer = 4;
            Console.WriteLine((answer < 9) ? $"{answer} is less than nine." : $"answer is greater than nine.");
        }
    }
}

