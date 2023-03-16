using SEDC.Homework_4.Homework.Task1.Classes;

Dog dog = new Dog();

Console.WriteLine("Enter a dog name?");
string dogName = Console.ReadLine();

Console.WriteLine("Enter a dog race?");
string dogRace  = Console.ReadLine();

Console.WriteLine("Enter a dog color?");
string dogColor  = Console.ReadLine();

while (true)
{
    if(dogName == null || dogRace == null || dogName == null)
    {
        Console.WriteLine("You enter something wrong!");
    }
    else
    {
        dog.Name = dogName;
        dog.Race = dogRace;
        dog.Color = dogColor;
        break;
    }
}

Console.WriteLine("Plase choose what are your dog is doing now:");
Console.WriteLine("1 for Eating");
Console.WriteLine("2 for Playng");
Console.WriteLine("3 for Chese Tail");

string dogNow = Console.ReadLine().ToLower();

while (true)
{
    if(dogNow == "1")
    {
        dog.Eat();
        break;
    }
    if (dogNow == "2")
    {
        dog.Play();
        break;
    }
    if(dogNow == "3")
    {
        dog.ChaseTail();
        break;
    }
    else
    {
        Console.WriteLine("That number is not an option. Plase enter a valid number!");
        break;
    }
}