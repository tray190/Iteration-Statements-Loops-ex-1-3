using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            counter();


            PauseConsole();

            CounterThree();

            PauseConsole();

            EqualChecker();

            int userNum1 = GetUserNumber();

            
            

            bool areEqual = EqualChecker();
        }

        private static int GetUserNumber()
        {
            Console.WriteLine("give me a number": );
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;

            throw new NotImplementedException();
        }

        private static bool EqualChecker()
        {
            throw new NotImplementedException();
        }

        private static bool EqualChecker(int num1, int num2)
        {
            for (int i = 3; i <= 999; i += 3)
            {
                return num1 == num2;
            }
        }

        private static void CounterThree()
        {
            throw new NotImplementedException();
        }
        private static void counter()
        {


            int goal = -1000;

            for (int i = 1000; i >= goal; i++)
            {
                Console.WriteLine(i);
            }
            PauseConsole();
            {
                Console.WriteLine();
                Console.ReadLine();
            }
            { }
            }

        private static void PauseConsole()
        {
            throw new NotImplementedException();
        }
    }






