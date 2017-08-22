using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application that asks the user for an integer
            //If that number is divisible by 3, "Fizz" should print
            //If that number is divisible by 5, "Buzz" should print
            //If that number is divisible by both, "FizzBuzz" should print


            //My answer
            //Console.WriteLine("Please type a number");
            //int typedNumber = int.Parse(Console.ReadLine());

            //if (typedNumber % 3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}


            //Actual answer 
            //Console.WriteLine("Please type a number");
            //int typedNumber = int.Parse(Console.ReadLine());

            //if(typedNumber % 15 == 0)
            //{
            //    Console.WriteLine("FIZZBUZZ");
            //}
            //else if(typedNumber % 3 ==0)
            //{
            //    Console.WriteLine("FIZZ");
            //}
            //else if(typedNumber % 5 == 0)
            //{
            //    Console.WriteLine("buzz");
            //}

            //Jordan's 
            //best to walk employers thru each step, don't rush thru

            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if(userNumber % 3 == 0 && userNumber %5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(userNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(userNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 or 5");
            }
        }
    }
}
