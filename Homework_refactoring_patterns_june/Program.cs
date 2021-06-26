using System;


namespace HomeworkRefactoringPatterns
{
    internal sealed class Program
    {
        #region Fields

        private const string _symbolFromQuit = "q";

        #endregion


        #region MainMethod

        private static void Main()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа.\n" +
                $"Для выхода введите: {_symbolFromQuit}\n");
            Console.Write("Пожалуйста, введите число: ");

            if (!CheckTheNumberFromUser(out int number))
            {
                return;
            }

            var calculate = new CalculationOfFormulas();

            var factorialCalculate = calculate.GetFactorial(number);
            var maxEvenNumberCalculate = calculate.GetMaxEvenNumber(number);
            var sumCalculate = calculate.GetSumFromOneToUserNumber(number);

            DisplayOfTheResultsOnTheScreen(factorialCalculate, maxEvenNumberCalculate, sumCalculate);

            Console.ReadKey();
        }

        #endregion


        #region Methods

        private static bool CheckTheNumberFromUser(out int number)
        {
            var userInputNumber = Console.ReadLine();

            checked
            {
                while (!int.TryParse(userInputNumber, out number) || number <= 0)
                {
                    if (userInputNumber == _symbolFromQuit)
                    {
                        number = -1;
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите корректное число.");
                        userInputNumber = Console.ReadLine();
                    }
                }
            }
            return true;
        }

        private static void DisplayOfTheResultsOnTheScreen(int factorial, int maxEvenNumber, int sum)
        {
            Console.WriteLine($"Факториал введенного вами числа равен: {factorial}");
            Console.WriteLine($"Максимальное четное число от 1 до вашего числа равно: {maxEvenNumber}");
            Console.WriteLine($"Сумма чисел от 1 до N равна {sum}");
        }

        #endregion
    }
}
