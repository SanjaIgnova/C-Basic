
#region Task 1
Console.WriteLine(" Take one string from the input and print its last 5 characters.");

Console.WriteLine("Plase enter some word:");
string newString = Console.ReadLine();

if (newString.Length >= 5)
{
    string lastFive = newString.Substring(newString.Length - 5);
    Console.WriteLine($"Last five characterrs from the input is {lastFive}");
}
else
{
    Console.WriteLine("Your input is too short.Plase enter a longer word!");
}

#endregion

#region Task 2
Console.WriteLine("Take a sentence as input and print its words.");

Console.WriteLine("Plase enter some sentence:");
string sentenceString = Console.ReadLine();

string[] sentenceArray = sentenceString.Split(' ');
Console.WriteLine($"Here is the word from your imput:");
foreach (string words in sentenceArray)
{
    Console.WriteLine(words);
}




#endregion

#region Task 3
Console.WriteLine("Create a function that takes a number as input. This method should return the sum of the digits in the number.");

Console.WriteLine("Enter some bigger number:");
bool number = int.TryParse(Console.ReadLine(), out int numberSum);

if (number)
{
    int sumOfDigits = 0;
    while (numberSum != 0)
    {
        sumOfDigits += numberSum % 10;
        numberSum /= 10;
    }
    Console.WriteLine($"The sum of the digits is {sumOfDigits}");

}
else
{
    Console.WriteLine("Error! Something was entered incorrectly ");
}
#endregion

#region Task 4

Console.WriteLine("Make a method called AgeCalculator");


Console.WriteLine("Plase enter your birthday date: dd.MM.yyyy");

string yourBirthYear1 = Console.ReadLine();
int age = AgeCalculator(yourBirthYear1);

if (age != -1)
{
    Console.WriteLine("Your age is: " + age);
}
int AgeCalculator(string yourBirthday)
{
    DateTime birthday;
    DateTime.TryParse(yourBirthday, out birthday);
    DateTime todayYear = DateTime.Today;
    int age = todayYear.Year - birthday.Year;

    if (birthday > todayYear.AddYears(-age))
    {
        age--;
    }
    return age;
}
   
#endregion