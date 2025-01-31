// Services/FibonacciGenerator.cs
using System.Collections.Generic;
using Kata_02.Contracts;

namespace Services
{
    public class FibonacciGenerator : IFibonacciGenerator
    {
        public List<int> Generate(int n)
        {
            var result = new List<int>();

            if (n <= 0)
            {
                return result;
            }

            result.Add(0);

            if (n == 1)
            {
                return result;
            }

            result.Add(1);

            for (int i = 2; i < n; i++)
            {
                result.Add(result[i - 1] + result[i - 2]);
            }

            return result;
        }
    }
}
