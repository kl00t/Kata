using FluentAssertions;

namespace Kata.Tests;

[TestFixture]
public class OddEvenTests
{
    [Test]
    public void PrintOddEven_ShouldReturnCorrectResult_ForTotalNumbers10()
    {
        // Arrange
        int totalNumbers = 10;
        string expected =
            "1: Odd\r\n" +
            "2: Even\r\n" +
            "3: Odd\r\n" +
            "4: Even\r\n" +
            "5: Odd\r\n" +
            "6: Even\r\n" +
            "7: Odd\r\n" +
            "8: Even\r\n" +
            "9: Odd\r\n" +
            "10: Even\r\n";

        // Act
        string result = OddEven.PrintOddEven(totalNumbers);

        // Assert
        result.Should().Be(expected);
    }

    [Test]
    public void PrintOddEven_ShouldReturnEmptyString_ForZeroInput()
    {
        // Arrange
        int totalNumbers = 0;

        // Act
        string result = OddEven.PrintOddEven(totalNumbers);

        // Assert
        result.Should().BeEmpty();
    }

    [Test]
    public void PrintOddEven_ShouldReturnCorrectResult_ForTotalNumbers1()
    {
        // Arrange
        int totalNumbers = 1;
        string expected = "1: Odd\r\n";

        // Act
        string result = OddEven.PrintOddEven(totalNumbers);

        // Assert
        result.Should().Be(expected);
    }
}