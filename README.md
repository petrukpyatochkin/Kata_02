# Fibonacci Sequence Generator

## Overview
This project is a simple Fibonacci sequence generator built using C# with .NET 8. It uses Dependency Injection for better modularity and testability.

## Features
- Generates Fibonacci sequences up to a user-defined limit.
- Implements Dependency Injection for better code management.
- Includes unit tests using xUnit.
- Supports console-based user input.

## Prerequisites
- .NET 8 SDK installed.

## Installation
Clone the repository and navigate into the project folder:
```bash
git clone https://github.com/petrukpyatochkin/Kata_02.git
cd FibonacciGenerator
```

## Running the Application
To run the application, use the following command:
```bash
dotnet run --project FibonacciGenerator
```
You will be prompted to enter the number of terms for the sequence.

## Running Tests
To execute unit tests, run:
```bash
dotnet test
```

## Example Output
```
Enter the number of terms for the sequence:
5
Generated Sequence: 0, 1, 1, 2, 3
```

## Future Enhancements
- Support for exporting results to a file.
- Web-based interface.

## License
This project is licensed under the MIT License.

