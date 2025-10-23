using System;

class Program
{
    static void Main()
    {
        string? input;
        do
        {
        Console.WriteLine("Enter first number: ");
        string firstInput = Console.ReadLine();
        double firstNumber = double.Parse(firstInput);
        Console.WriteLine("*********************");

        Console.WriteLine("Enter second number: ");
        string secondInput = Console.ReadLine();
        double secondNumber = double.Parse(secondInput);
        Console.WriteLine("*********************");

        Console.WriteLine("Enter operation (+, -,*, /, %)");
        string operation = Console.ReadLine();

        double result = 0;
        

    switch (operation)
        {
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                }
                else
                {
                    result = firstNumber / secondNumber;
                }
                break;
            case "%":
                result = firstNumber % secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
        Console.WriteLine("Result: " + firstNumber + operation + secondNumber + " = " + result);
        Console.WriteLine("*********************");
        Console.WriteLine ("Do you want to do another one? (y/n)");
        input = Console.ReadLine()?.Trim().ToLowerInvariant();
        }while (input == "y" || input == "yes");
        Console.WriteLine("Thank you for using the calculator!");
    }
}