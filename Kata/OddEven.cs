namespace Kata;

public static class OddEven
{
    public const string Odd = "Odd";
    public const string Even = "Even";

    public static string PrintOddEven(int totalNumbers)
    {
        var resultBuilder = new System.Text.StringBuilder();

        // Given an X amount of numbers
        for (int i = 1; i <= totalNumbers; i++)
        {
            // Then Output "Even" for even numbers, "Odd" for odd numbers
            string result = (i % 2 == 0) ? Even : Odd;
            resultBuilder.AppendLine($"{i}: {result}");
        }

        return resultBuilder.ToString();
    }
}