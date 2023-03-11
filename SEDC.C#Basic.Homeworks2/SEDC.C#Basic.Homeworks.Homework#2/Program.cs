
#region Task 1
Console.WriteLine("Sum Of Even");

int[] sumOfEven = new int[6];
int sum = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Enter integer no.{i + 1}:");
    sumOfEven[i] = int.Parse(Console.ReadLine());
}
foreach (int i in sumOfEven)
{
    if (i % 2 == 0)
    {
          sum += i;
    }
}
Console.WriteLine("The Result is:" + sum);

#endregion


#region Task 2
Console.WriteLine("Student Group");

string[] studentsG1 = new string[5] {"Sanja","Irena","Mite","Borce","Tea"};
string[] studentsG2 = new string[5] { "Tamara", "Ivan", "Keti", "Mihail", "Sara" };

Console.WriteLine("Plase enter witch student group do you want to see. Enter 1 for student group G1 or 2 for student group G2?");
int input = int.Parse(Console.ReadLine());

if (input == 1)
{
    for (int i = 0; i < studentsG1.Length; i++)
    {
        Console.WriteLine("You choose student group G1. Here is the name of the students:" + studentsG1[i]);
    }
   
} else if (input == 2)
{
    for (int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine("You choose student group G2. Here is the name of the students:" + studentsG2[i]);
    }
} else
{
    Console.WriteLine("Group with that number doesn't exist. Plase enter correct number?");
}
#endregion