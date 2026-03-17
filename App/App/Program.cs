Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

Console.WriteLine("Enter another number: ");
int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
Console.WriteLine($"The sum of entered numbers is {number +  number2}");

Console.WriteLine("Enter any word: ");
string? word = Console.ReadLine();
int counter = 0;
foreach (char c in word)
{
    counter++;
}
Console.WriteLine($"The number of letters in the entered word is {counter}");
