Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

Console.WriteLine("Enter another number: ");
int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
Console.WriteLine($"The sum of entered numbers is {number +  number2}");
