
#region Task 1
Console.WriteLine(" Real Calculator!");


Console.WriteLine("Please enter +, -, * or /");

string input = Console.ReadLine();
Console.WriteLine("Plase enter the first number");
bool firstNubmer = int.TryParse(Console.ReadLine(), out int firstNum);
Console.WriteLine("Plase enter the second number");
bool secondNumber = int.TryParse(Console.ReadLine(), out int secondNum);

if (firstNubmer && secondNumber)
{
    if (input == "+")
    {

        int result = firstNum + secondNum;
        Console.WriteLine($"Your result is {result}");
    }
    else if (input == "-")
    {

        int result = firstNum - secondNum;
        Console.WriteLine($"Your result is {result}");
    }
    else if (input == "*")
    {

        int result = firstNum * secondNum;
        Console.WriteLine($"Your result is {result}");
    }
    else if (input == "/")
    {
        int result = firstNum / secondNum;
        Console.WriteLine($"Your result is {result}");
    }
}else
{
    Console.WriteLine("You enter a wrong operation. Plase enter again!");
}

#endregion

#region Task 2
Console.WriteLine("Average Number!");


Console.WriteLine("Plase enter first number:");
bool firstNumber1 = int.TryParse(Console.ReadLine(),out int firstNumParse);
Console.WriteLine("Plase enter second number:");
bool secondNumber1 = int.TryParse(Console.ReadLine(), out int secondNumParse);
Console.WriteLine("Plase enter third number:");
bool thirdNumber1 = int.TryParse(Console.ReadLine(), out int thirdNumParse);
Console.WriteLine("Plase enter four number:");
bool fourNumber1 = int.TryParse(Console.ReadLine(), out int fourNumParse);

if (firstNumber1 && secondNumber1 && thirdNumber1 && fourNumber1)
{
    int averageNumber1 = (firstNumParse + secondNumParse + thirdNumParse + fourNumParse) / 4;
    Console.WriteLine($"The average number of enterd number is {averageNumber1}");
} else
{
    Console.WriteLine("You must enter a number!");
}
#endregion

#region Task 3
Console.WriteLine("Swap Numbers!");

Console.WriteLine("Plase enter a first number:");
bool numb = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Plase enter a second number:");
bool numb2 = int.TryParse(Console.ReadLine(), out int number2);


if (numb && numb2)
{
    Console.WriteLine($"Before swapping the first number is {number1} and the second number is {number2} ");
    number1 = number1 + number2;
    number2 = number1 - number2;
    number1 = number1 - number2;
    Console.WriteLine($"After swapping the first number is {number1} and the second number is {number2}");
} else
{
    Console.WriteLine("Your input is not number!");
}

#endregion