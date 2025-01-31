using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kata_02.Contracts;
using Services;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // Register dependencies
        services.AddSingleton<IFibonacciGenerator, FibonacciGenerator>();
    })
    .Build();

// Resolve the service through DI
var generator = host.Services.GetRequiredService<IFibonacciGenerator>();

Console.WriteLine("Enter the number of terms for the sequence:");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    var sequence = generator.Generate(n);
    Console.WriteLine("Generated Sequence: " + string.Join(", ", sequence));
}
else
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
}
