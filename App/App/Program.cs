namespace App;

public class MainClass
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        Console.WriteLine("Enter another number: ");
        int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Console.WriteLine($"The sum of entered numbers is {number + number2}");

        Console.WriteLine("Enter any word: ");
        string word = Console.ReadLine();
        if (word is not null)
        {
            int counter = 0;
            foreach (char c in word)
            {
                counter++;
            }

            Console.WriteLine($"The number of letters in the entered word is {counter}");
        }

        int[] values = [number, number2];
        Console.WriteLine($"The average number is: {CalculateAverage(values)}");
        Console.WriteLine($"The maximal number is: {CalculateMax(values)}");

    }

    private static double CalculateAverage(int[] values)
    {
        return values.Average();
    }

    private static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}