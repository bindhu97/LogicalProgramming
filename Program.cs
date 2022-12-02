// See https://aka.ms/new-console-template for more information
using LogicalProgramming;

Console.WriteLine("Hello, World!");

Console.WriteLine("Calling PrimeNumber");
PrimeNumber primeNumber = new PrimeNumber();
primeNumber.Prime();

Console.WriteLine("Calling PerfectNumber");
PerfectNumber perfectNumber = new PerfectNumber();
perfectNumber.Perfect();

Console.WriteLine("Calling FibonacciSeries");
FibonacciSeries fibonacciSeries = new FibonacciSeries();
fibonacciSeries.Fibonacci();

