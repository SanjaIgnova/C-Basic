
#region Task 1
Console.WriteLine(" Real Calculator!");


Console.WriteLine("Please enter +, -, * or /");

string input = Console.ReadLine();

if (input == "+")
{
    Console.WriteLine("Plase enter the first number");
    int firstNubmer = int.Parse(Console.ReadLine());
    Console.WriteLine("Plase enter the second number");
    int secondNumber = int.Parse(Console.ReadLine());   
    int result = firstNubmer + secondNumber;
    Console.WriteLine($"Your result is {result}");
} else if (input == "-")
{
    Console.WriteLine("Plase enter the first number");
    int firstNubmer = int.Parse(Console.ReadLine());
    Console.WriteLine("Plase enter the second number");
    int secondNumber = int.Parse(Console.ReadLine());
    int result = firstNubmer - secondNumber;
    Console.WriteLine($"Your result is {result}");
}
else if (input == "*")
{
    Console.WriteLine("Plase enter the first number");
    int firstNubmer = int.Parse(Console.ReadLine());
    Console.WriteLine("Plase enter the second number");
    int secondNumber = int.Parse(Console.ReadLine());
    int result = firstNubmer * secondNumber;
    Console.WriteLine($"Your result is {result}");
} else if(input == "/")
{
    Console.WriteLine("Plase enter the first number");
    int firstNubmer = int.Parse(Console.ReadLine());
    Console.WriteLine("Plase enter the second number");
    int secondNumber = int.Parse(Console.ReadLine());
    int result = firstNubmer / secondNumber;
    Console.WriteLine($"Your result is {result}");
}
else
{
    Console.WriteLine("You enter a wrong operation. Plase enter again!");
}
#endregion

#region Task 2
Console.WriteLine("Average Number!");


Console.WriteLine("Plase enter first number:");
int firstNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Plase enter second number:");
int secondNumber1= int.Parse(Console.ReadLine());
Console.WriteLine("Plase enter third number:");
int thirdNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Plase enter four number:");
int fourNumber1 = int.Parse(Console.ReadLine());

int averageNumber1 = (firstNumber1 + secondNumber1 + thirdNumber1 + fourNumber1) / 4;
Console.WriteLine($"The average number of enterd number is {averageNumber1}");
#endregion

#region Task 3
Console.WriteLine("Swap Numbers!");

Console.WriteLine("Plase enter a first number:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Plase enter a second number:");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Before swapping the first number is {number1} and the second number is {number2} ");

number1 = number1 + number2;
number2 = number1 - number2;
number1 = number1 - number2;

Console.WriteLine($"After swapping the first number is {number1} and the seconf number is {number2}");


#endregion