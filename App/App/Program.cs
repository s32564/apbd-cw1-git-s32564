Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

if (number % 2 == 0)
    Console.WriteLine("The number is even");
else
    Console.WriteLine("The number is odd");

Console.WriteLine("Enter another number: ");
int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
Console.WriteLine($"The sum of entered numbers is {number +  number2}");
