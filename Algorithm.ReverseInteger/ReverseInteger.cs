namespace Algorithm.ReverseInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseInteger
    {
        public string Reverse(int number)
        {
            if (number == 0)
                return "0";

            var digits = GetNumberOfDigitsForNumber(number);
            return ReverseDigitsForNumber(number, digits);
        }

        private int GetNumberOfDigitsForNumber(int number)
        {
            var digits = GetDigits(number);
            var normalized = Math.Floor(digits);
            return Convert.ToInt32(normalized);
        }

        private double GetDigits(int number)
        {
            return Math.Log10(number) + 1;
        }

        private string ReverseDigitsForNumber(int number, int digits)
        {
            var list = ConstructListOfDigits(number, digits);

            list.Reverse();

            return string.Join("", list.Select(d => d.ToString()));
        }

        private List<int> ConstructListOfDigits(int number, int digits)
        {
            var divider = GetDividerByPower(digits);
            var list = new List<int>();

            for (var i = 0; i < digits; i++)
            {
                if (number >= 10)
                    list.Add(number / divider);
                else
                    list.Add(number % 10);
                number %= divider;
                divider /= 10;
            }

            return list;
        }

        private int GetDividerByPower(int digits)
        {
            var power = Math.Pow(10, digits - 1);
            return Convert.ToInt32(power);
        }
    }
}
