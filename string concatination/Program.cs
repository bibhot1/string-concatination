// See https://aka.ms/new-console-template for more information
//making an addition calculator first.
Console.WriteLine("Please enter your first number");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number");
double num2 = double.Parse(Console.ReadLine());
double result = num1 + num2;

//using string interpolation to print out the value.
Console.WriteLine($"the sum of {num1} and {num2} is {result}");
