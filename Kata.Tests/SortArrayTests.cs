using FluentAssertions;

namespace Kata.Tests;

[TestFixture]
public class SortArrayTests
{
    [Test]
    public void SortArray_GivenAnArray_ThenZeroMovedToTheEnd()
    {
        // Arrange
        object[] input = [0, false, 'a', 'b', 0];
        object[] expected = [false, 'a', 'b', 0, 0];

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenAnArrayWithoutZeros_ShouldRemainUnchanged()
    {
        // Arrange
        object[] input = { 'x', false, 'a', true, 'b' };
        object[] expected = { 'x', false, 'a', true, 'b' };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenAnArrayWithOnlyZeros_ShouldRemainUnchanged()
    {
        // Arrange
        object[] input = { 0, 0, 0, 0 };
        object[] expected = { 0, 0, 0, 0 };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenAnEmptyArray_ShouldReturnEmptyArray()
    {
        // Arrange
        object[] input = { };
        object[] expected = { };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenArrayWithMultipleDataTypes_ShouldMoveZerosToEnd()
    {
        // Arrange
        object[] input = { 0, 1, "test", 0, true, 3.14, 0 };
        object[] expected = { 1, "test", true, 3.14, 0, 0, 0 };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenArrayWithZerosAtTheEnd_ShouldRemainUnchanged()
    {
        // Arrange
        object[] input = { 1, 'a', false, 0, 0 };
        object[] expected = { 1, 'a', false, 0, 0 };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Test]
    public void SortArray_GivenArrayWithZerosAndNulls_ShouldHandleNullsCorrectly()
    {
        // Arrange
        object[] input = { 0, null, 'a', 0, null };
        object[] expected = { null, 'a', null, 0, 0 };

        // Act
        var result = SortArray.Sort(input);

        // Assert
        result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}