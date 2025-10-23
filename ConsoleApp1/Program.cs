using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        string firstInput = Console.ReadLine();
        double firstNumber = double.Parse(firstInput);
        Console.WriteLine("*********************");
        
        Console.WriteLine("Enter second number: ");
        string secondInput = Console.ReadLine();
        double secondNumber = double.Parse(secondInput);
        Console.WriteLine("*********************");
        
        Console.WriteLine("Enter operation (+, -, *, / )");
        string operation = Console.ReadLine();

        double result = 0;
        
        if (operation == "+")
            {
            result = firstNumber + secondNumber;
            }
        else if (operation == "-")
            {
            result = firstNumber - secondNumber;
            }
        else if (operation == "*")
            {
            result = firstNumber * secondNumber;
            }
        else if (operation == "/")
            {
            result = firstNumber / secondNumber;
            }
        Console.WriteLine("Result: " + firstNumber + operation + secondNumber + " = " + result);
        Console.WriteLine("*********************");
    }
}