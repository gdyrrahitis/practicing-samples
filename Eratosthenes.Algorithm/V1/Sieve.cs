namespace Eratosthenes.Algorithm.V1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sieve
    {
        public IEnumerable<int> Calculate(int n)
        {
            var numbers = Initialize(n).ToList();
            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = NextOf(i); j < numbers.Count; j++)
                    if (NextIsMultiplyOf(numbers, j, i))
                        numbers.Remove(numbers[j]);
                if (CurrentPowerOfTwoIsGreaterThan(n, numbers, i)) break;
            }

            return numbers;
        }

        private static bool CurrentPowerOfTwoIsGreaterThan(int n, List<int> numbers, int i)
        {
            return Math.Pow(numbers[i], 2) > n;
        }

        private static int NextOf(int i)
        {
            return i + 1;
        }

        private static bool NextIsMultiplyOf(List<int> numbers, int j, int i)
        {
            return numbers[j] % numbers[i] == 0;
        }

        private IEnumerable<int> Initialize(int n)
        {
            for (var i = 2; i <= n; i++)
            {
                yield return i;
            }
        }
    }
}
