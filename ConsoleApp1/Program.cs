namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        string history1 = "";
        string history2 = "";
        string history3 = "";
        string history4 = "";
        string history5 = "";
        string menuInput;
        string invalidMessage = "Error: Please enter a valid number!";

        do
        {
            
            double firstNumber;
            double secondNumber;
            string history = "";
            Console.WriteLine("=== Scientific Calculator ===");
            Console.WriteLine("Menu:");
            string[] menu =
                [$"Basic Operations (+, -, *, /, %)", $"Square Root", $"Power (x^y)", $"View History", $"Exit"];
            int i = 0;

            while (i < menu.Length)
            {
                Console.WriteLine($"{i + 1}: {menu[i]}");
                i++;
            }

            Console.WriteLine("Choose an option: ");
            menuInput = Console.ReadLine();
            switch (menuInput)
            {
                case "1":
                    Console.WriteLine("Enter first number: ");
                    if (!double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.WriteLine(invalidMessage);
                        break;
                    }
                    //Basic operation

                    Console.WriteLine("*********************");

                    Console.WriteLine("Enter second number: ");
                    if (!double.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.WriteLine(invalidMessage);
                        break;
                    }

                    Console.WriteLine("*********************");

                    Console.WriteLine("Enter operation (+, -,*, /, %)");
                    string operation = Console.ReadLine();

                    double result = 0;
                    //check operation

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

                    history = $"{firstNumber} {operation} {secondNumber} = {result}";
                    Console.WriteLine("Result: " + firstNumber + operation + secondNumber + " = " + result);
                    Console.WriteLine("*********************");
                    break;
                //Calculate Square
                case "2":
                    Console.WriteLine("Enter a number: ");
                    if (!double.TryParse(Console.ReadLine(), out firstNumber))
                    {
                        Console.WriteLine(invalidMessage);
                        break;
                    }

                    double sqrtResult = Math.Sqrt(firstNumber);
                    history = $"√{firstNumber} = {Math.Round(sqrtResult),2}";
                    Console.WriteLine($"Result: √{firstNumber} = {Math.Round(sqrtResult, 2)}");

                    break;
                //Calculate Power
                case "3":
                    Console.WriteLine("Enter base: ");
                    string baseInput = Console.ReadLine();
                    if (!double.TryParse(baseInput, out firstNumber))
                    {
                        Console.WriteLine(invalidMessage);
                    }
                    else
                    {
                        Console.WriteLine("Enter exponent:");
                        if (!double.TryParse(Console.ReadLine(), out secondNumber))
                        {
                            Console.WriteLine(invalidMessage);
                            break;
                        }

                        double powerResult = Math.Pow(firstNumber, secondNumber);
                        history = $"{firstNumber} ^ {secondNumber} = {powerResult}";
                        Console.WriteLine($"Result: {firstNumber}^{secondNumber} = {powerResult} ");
                    }

                    break;
                //Show history
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("==============================");
                    Console.WriteLine("=== Calculation History ===");
                    Console.WriteLine(history1);
                    Console.WriteLine(history2);
                    Console.WriteLine(history3);
                    Console.WriteLine(history4);
                    Console.WriteLine(history5);
                    break;
                //Exit Menu
                case "5":
                    Console.WriteLine("Thank you for using the Scientific Calculator!");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine(invalidMessage);
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine();
                    break;
            }

            history5 = history4;
            history4 = history3;
            history3 = history2;
            history2 = history1;
            history1 = history;
        } while (menuInput != "5");
    }
}