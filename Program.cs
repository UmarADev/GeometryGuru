using System;
using System.Reflection.Metadata;
using System.Text.Encodings.Web;

string shouldContinue = "y";
 
do
{
    Console.WriteLine("Welcome to the Calculator!\n");
    Console.WriteLine("Choose the option you want:\n"); 
    Console.WriteLine("1. Calculate the surface area of a circle\n2. Calculate the area of the trapezoid\n3. Simple calculator for you\n");

    string userChoise = Console.ReadLine();
    
    if(userChoise == "1")
    {
        const double Pi = 3.14;
        Console.Write("Enter the radius of the circle: ");
        int radius = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"The surface area of a circle is {Pi * Math.Pow(radius, 2)}");
    }
    else if(userChoise == "2")
    {
        Console.WriteLine("Enter the trapezoids first base:");
        int base1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the trapezoids second base:");
        int base2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the trapezoids height:");
        int height = Convert.ToInt32(Console.ReadLine());

        int area = ((base1 + base2)/2)*height;
        Console.WriteLine($"The area of trapezoid is {area}");
    }
    else if(userChoise == "3")
    {
        Console.WriteLine("Welcome to the Simple Calculator");
        Console.WriteLine("Enter the number and operation");
        string inputNumAndOperation = Console.ReadLine();
        string[] separators = { " ", "+", "-", "*", "/" };
        string[] parts = inputNumAndOperation.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        int firstNumber = Convert.ToInt32(parts[0]);
        int secondNumber = Convert.ToInt32(parts[1]);

        foreach (var operationChar in inputNumAndOperation)
            {
                if (operationChar == '-')
                {
                    Console.WriteLine($"Result:{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                }
                else if (operationChar == '+')
                {
                    Console.WriteLine($"Result:{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                }
                else if (operationChar == '*')
                {
                    Console.WriteLine($"Result:{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                }
                else if (operationChar == '/')
                {
                    if (secondNumber != 0)
                    {
                        Console.WriteLine($"Result:{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot be divided by ZERO!!!!");
                    }
                }
            }
    }
    
    Console.WriteLine("Do you want to continue? Please confirm this\ny / n");
    shouldContinue = Console.ReadLine();
        
}while(shouldContinue == "y");
    