
#region Task 1
using System.Diagnostics.Metrics;

Console.WriteLine("Sum Of Even");

int[] sumOfEven = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Enter integer no.{i + 1}:");
    bool numberOfArray = int.TryParse(Console.ReadLine(), out int numberInt);

    if (numberOfArray)
    {
        sumOfEven[i] = numberInt;
        if (numberInt % 2 == 0)
        {
            sum += numberInt;
        }


    }
    else
    {
        Console.WriteLine("Check your input. You must enter a number!");
    }

}
Console.WriteLine("The Result is:" + sum);
#endregion


#region Task 2
Console.WriteLine("Student Group");

string[] studentsG1 = new string[5] { "Sanja", "Irena", "Mite", "Borce", "Tea" };
string[] studentsG2 = new string[5] { "Tamara", "Ivan", "Keti", "Mihail", "Sara" };

Console.WriteLine("Plase enter witch student group do you want to see. Enter 1 for student group G1 or 2 for student group G2?");
bool input1 = int.TryParse(Console.ReadLine(), out int input);

if (input1)
{
    if (input == 1)
    {
        Console.WriteLine("You choose student group G1. Here is the name of the students:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }

    }
    else if (input == 2)
    {
        Console.WriteLine("You choose student group G2. Here is the name of the students:");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    else
    {
        Console.WriteLine("Group with that number doesn't exist. Plase enter correct number?");
    }
}
else
{
    Console.WriteLine("Plase enter a number!");
}
#endregion

#region Exersise 4
Console.WriteLine(" Exerises 4 ");
string[] stringArray = new string[] { "Heelo", "Hi", "Bye" };

double[] doubleArray = new double[] { 1.25, 5.6, 4.5 };

char[] charArray = new char[] { 'h', 'e', 'l', 'l', 'o' };

bool[] boolArray = new bool[] { false, true };


#endregion

#region Exersise 5
Console.WriteLine("Exersis 5");

int[] intArray = new int[5];
int sumOfNum = 0;



for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("Enter index " + i);
    bool number = int.TryParse(Console.ReadLine(), out int num);
    intArray[i] = num;

    if (number)
    {
        sumOfNum += num;
        Console.WriteLine("The result is: " + sumOfNum);
    }
    else
    {
        Console.WriteLine("Plase enter a number!");
    }
}
#endregion

#region Exersis 6
Console.WriteLine("Exersise 6");
string[] namesArray = new string[0];
int names = 0;
while (true)
{
    Console.WriteLine("Please enter a name :");
    string name = Console.ReadLine();
    Array.Resize(ref namesArray, namesArray.Length + 1);
    namesArray[names] = name;
    Console.WriteLine("Names stored:");
    foreach (string currentName in namesArray)
    {
        Console.WriteLine(currentName);
    }
    Console.WriteLine("Do you want to enter another name? Y of N");
    if (Console.ReadLine() == "N")
    {
        Console.WriteLine("You entred only one name in the array");
        break;
    }
  
}


#endregion