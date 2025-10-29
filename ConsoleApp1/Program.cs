
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
        do
        {
            string history = "";  
            Console.WriteLine("=== Scientific Calculator ===");
            Console.WriteLine("Menu:");
            string[] menu = { "Basic Operations (+, -, *, /, %)", "Square Root", "Power (x^y)", "View History","Exit" };
 
       
            int i = 0;
   
            while (i < menu.Length)
            {
                Console.WriteLine($"{i+1}: {menu[i]}");
                i++;
            }
            Console.WriteLine("Choose an option: ");
            menuInput= Console.ReadLine();
            switch (menuInput)
            {
                case "1":
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
                
                    history = $"{firstNumber} {operation} {secondNumber} = {result}";
                    Console.WriteLine("Result: " + firstNumber + operation + secondNumber + " = " + result);
                    Console.WriteLine("*********************");
                    break;
                case "2":
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();
                    double number = double.Parse(input);
                    double sqrtResult =Math.Sqrt(number);
                    history = $"{number} {input} = {sqrtResult}";
                    Console.WriteLine($"Result: √{input} = {sqrtResult}");
               
                    break;
                case "3":
                    Console.WriteLine("Enter base: ");
                    string baseInput = Console.ReadLine();
                    double baseNumber=double.Parse(baseInput);
                    Console.WriteLine("Enter exponent:");
                    double exponentInput=double.Parse(Console.ReadLine());
                    double powerResult=Math.Pow(baseNumber, exponentInput);
                    history =  $"{baseNumber} {baseInput} = {powerResult}";
                    Console.WriteLine($"Result: {baseInput}^{exponentInput} = {powerResult} ");
                    break;
                case "4":
                    Console.WriteLine("=== Calculation History ===");
                    Console.WriteLine(history1);
                    Console.WriteLine(history2);   
                    Console.WriteLine(history3);
                    Console.WriteLine(history4);
                    Console.WriteLine(history5);
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Scientific Calculator!"); 
                    break;
            }
        
            history5 = history4;
            history4 = history3;
            history3 = history2;
            history2 = history1;
            history1 = history;
        } while (menuInput!="5");
    }
}