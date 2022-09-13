using System;

namespace MethodExercise
{
    
    class Program
    {
        //--------------Exercise 2 methods for each math operator---------------
        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract (int num1, int num2)
            {
            return num1 - num2;
        }
        public static double Divide (double num1, double num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        //------------Params keyword----------------------------
        public static int AddParams(params int[] parameterArrayNumbers)
        {
            int totalAdd = 0;
            foreach (int num in parameterArrayNumbers)
                {
                totalAdd += num;
            }
            return totalAdd;
        }

        static void Main(string[] args)
        {
            //--------------Exercise 2 plug in the integers------------------
            Console.Write($"Let's do some math! ");
            Console.WriteLine();
            Console.Write($"When you add 4 and 5 it equals ");
            Console.WriteLine(Add(4, 5));

            Console.Write($"When you multiply 3 and 5, you get ");
            Console.WriteLine(Multiply(3, 5));

            Console.Write($"When you take away 7 from 3, you get ");
            Console.WriteLine(Subtract(7, 3));

            Console.Write($"When you divide 4 by 2 it equals ");
            Console.WriteLine(Divide(4, 2));

            Console.Write($"Modulus of (4, 9) is ");
            Console.WriteLine(Modulus(4, 9));

            //-------------Params keyword output------------------------
            Console.Write($"Sum of (2, 4) is ");
            Console.WriteLine(AddParams(2, 4));

            Console.Write($"Sum of (2, 4, 6) is ");
            Console.WriteLine(AddParams(2, 4, 6));

            Console.Write($"Sum of (1, 1, 1, 1, 1) is ");
            Console.WriteLine(AddParams(1, 1, 1, 1, 1));

            //--------------------Exercise 1 ask user questions----------------------
            Console.Write($"Enough with the math, lets get to know you");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            var realName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("What rapper do you like to listen to?");
            var faveRapper = Console.ReadLine();

            Console.WriteLine($"Hello, I am {realName} and my favorite " +
                $"color is {faveColor}.");
            Console.WriteLine($"My favorite animal in the zoo is a {faveAnimal} " +
                $"and I like to listen to {faveRapper}.");

        }
    }
}

