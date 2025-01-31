using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_02.Contracts
{
    public interface IFibonacciGenerator
    {
        /// <summary>
        /// Generates a Fibonacci sequence with the specified number of terms.
        /// </summary>
        /// <param name="n">The number of terms to generate.</param>
        /// <returns>A list containing the Fibonacci sequence.</returns>
        List<int> Generate(int n);
    }
}
