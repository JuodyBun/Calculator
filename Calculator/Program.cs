using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string askForNumber = "Please give me a number";
            string askForNumber2 = "Please give me a second number";

            TalkToUser(askForNumber);
            string userInput = GetUserData();
            int num1 = int.Parse(userInput);

            TalkToUser(askForNumber2);
            userInput = GetUserData();
            int num2 = int.Parse(userInput);

            int answer = Add(num1, num2);
            Console.WriteLine($"The sum of these two numbers = {answer}");

            TalkToUser(askForNumber);
            userInput = GetUserData();
            num1 = ParseStringToInt(userInput);

            TalkToUser(askForNumber2);
            userInput = GetUserData();
            num2 = ParseStringToInt(userInput);

            Console.WriteLine("Subtraction");
            Console.WriteLine($"{num1} minus {num2} equals: {Subtract(num1, num2)}");

            Console.WriteLine("Subtraction");
            Console.WriteLine($"{num1} times {num2} equals: {Multiply(num1, num2)}");

            Console.WriteLine("Subtraction");
            Console.WriteLine($"{num1} divided by {num2} equals: {Divide(num1, num2)}");

            Console.ReadLine();
        }

        public static void TalkToUser(string dialogue)
        {
            Console.WriteLine(dialogue);
        }

        public static string GetUserData()
        {
            return Console.ReadLine();
        }

        public static int ParseStringToInt(string userAnswer)
        {
            return int.Parse(userAnswer);
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double numerator, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("You cannot divide by zero.");
                return 0;
            }
            return numerator / divisor;
        }
    }
    
}
