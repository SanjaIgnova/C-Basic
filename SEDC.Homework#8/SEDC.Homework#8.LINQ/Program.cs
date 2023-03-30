List<int> numbers = new List<int>();
{

    numbers.Add(2);
    numbers.Add(4);
    numbers.Add(3);
    numbers.Add(5);
    numbers.Add(10);
    numbers.Add(7);
    numbers.Add(8);
    numbers.Add(9);
    numbers.Add(15);
    numbers.Add(20);
}

Console.WriteLine("List of numbers:");
foreach(int num in numbers) Console.Write(num + " ,");
Console.WriteLine(); 
Console.WriteLine();

List<int> squeres = numbers.Select(x => x * x).ToList();
Console.WriteLine("Find a squares of the numbers in the list");
Console.WriteLine("Squares of the number is: ");
squeres.ForEach(numbers => Console.Write(numbers + ","));

Console.WriteLine();




