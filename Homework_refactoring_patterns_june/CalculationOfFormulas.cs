namespace HomeworkRefactoringPatterns
{
    internal sealed class CalculationOfFormulas
    {
        #region Methods

        public int GetSumFromOneToUserNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int GetFactorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int GetMaxEvenNumber(int number)
        {
            int maxEvenNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0 && i < number)
                {
                    maxEvenNumber = i;
                }
            }
            return maxEvenNumber;
        }

        #endregion
    }
}
