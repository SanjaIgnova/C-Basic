Console.WriteLine("QUELE");


Queue<int> numberInQuele = new Queue<int>();
Console.WriteLine();

void QueleNumber() {

    Console.WriteLine("Plaese enter a number");
    bool inputNumber = int.TryParse(Console.ReadLine(), out int number);
    if (inputNumber)
{
        numberInQuele.Enqueue(number);
    }
else
{
        Console.WriteLine("You entered unvalid number!Plase enter a valid number!");
    }
}

QueleNumber();


while (true)
{
    Console.WriteLine("Do you whant to continue? Y or N");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        QueleNumber();
        continue;
       
    } else if(answer == "N" || answer =="n") 

    {
        Console.WriteLine("Here is your numbers:");
        foreach (int num in numberInQuele)
        {
            Console.WriteLine(" - " + num);
        }
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("You input something wrong!");
    }
}


