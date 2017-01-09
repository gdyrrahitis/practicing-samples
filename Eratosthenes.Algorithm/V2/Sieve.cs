namespace Eratosthenes.Algorithm.V2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sieve
    {
        private const int Start = 2;

        public IEnumerable<int> Calculate(int n)
        {
            var list = InitializeSieve(n).ToList();
            var length = list.Count;
            for (var i = 0; i < length; i++)
            {
                for (var j = GetNextOf(i); j < GetCountOfCurrent(list); j++)
                    SieveItemIfNotPrime(list, j, i);
                if (IsCurrentItemPowerOfTwoGreaterThan(n, list[i]))
                    break;
            }

            return list;
        }

        private static bool IsCurrentItemPowerOfTwoGreaterThan(int n, int current)
        {
            return Math.Pow(current, 2) > n;
        }

        private static int GetCountOfCurrent(List<int> list)
        {
            return list.Count;
        }

        private static int GetNextOf(int i)
        {
            return i + 1;
        }

        private static void SieveItemIfNotPrime(List<int> list, int j, int i)
        {
            if (IsNotPrime(list, j, i))
                list.RemoveAt(j);
        }

        private static bool IsNotPrime(List<int> list, int j, int i)
        {
            return list[j] % list[i] == 0;
        }

        private static IEnumerable<int> InitializeSieve(int n)
        {
            for (var i = Start; i <= n; i++)
                yield return i;
        }
    }
}