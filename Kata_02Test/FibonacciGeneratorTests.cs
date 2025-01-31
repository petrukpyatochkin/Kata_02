using Xunit;
using System.Collections.Generic;
using Kata_02.Contracts;
using Services;

public class FibonacciGeneratorTests
{
    private readonly IFibonacciGenerator _generator;

    public FibonacciGeneratorTests()
    {
        _generator = new FibonacciGenerator();
    }

    /// <summary>
    /// Tests FibonacciGenerator with various inputs to ensure correct output.
    /// </summary>
    /// <param name="n">Number of terms in the sequence</param>
    /// <param name="expected">Expected sequence</param>
    [Theory]
    [InlineData(0, new int[] { })]
    [InlineData(1, new int[] { 0 })]
    [InlineData(2, new int[] { 0, 1 })]
    [InlineData(5, new int[] { 0, 1, 1, 2, 3 })]
    [InlineData(7, new int[] { 0, 1, 1, 2, 3, 5, 8 })]
    public void Generate_ReturnsExpectedSequence(int n, int[] expected)
    {
        // Act
        var result = _generator.Generate(n);

        // Assert
        Assert.Equal(expected, result);
    }


     /// <summary>
    /// Tests FibonacciGenerator with negative inputs to ensure it returns an empty list.
    /// </summary>
    /// <param name="n">Number of terms in the sequence (negative value)</param>
    [Theory]
    [InlineData(-1)]
    [InlineData(-5)]
    [InlineData(-10)]
    public void Generate_WithNegativeValues_ReturnsEmptyList(int n)
    {
        // Act
        var result = _generator.Generate(n);

        // Assert
        Assert.Empty(result);
    }
}
