using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public static class InterpreterNumbersForScoreUI
    {
        #region Fields

        private static string[] _namesOfNumbers = { "", "K", "M", "B", "T" };
        private static string _zero = "0";
        private static double _maxDoubleNumber = 1000.0d;

        #endregion


        #region Methods

        public static string Format(double number)
        {
            number = Mathf.Round((float)number);
            var i = 0;

            if (number == 0)
            {
                return _zero;
            }

            while (i + 1 < _namesOfNumbers.Length && number >= _maxDoubleNumber)
            {
                number /= _maxDoubleNumber;
                i++;
            }
            return $"{number:#.##}{_namesOfNumbers[i]}";
        }

        #endregion
    }
}
