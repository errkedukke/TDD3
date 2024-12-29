using TDD.CalcStat;

namespace TDD.CalcStatsTests;

[TestFixture]
public class CalcStatsTests
{
    private CalcStats _calcStats;

    [SetUp]
    public void Setup()
    {
        _calcStats = new CalcStats();
    }

    [Test]
    public void CalculateStats_ShouldReturnMinimumValue()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4 };

        // Act
        var result = _calcStats.CalculateMinimum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void CalculateStats_ShouldReturnMaximumValue()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4 };

        // Act
        var result = _calcStats.CalculateMaximum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void CalculateStats_ShouldReturnNumberOfElements()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4 };

        // Act
        var result = _calcStats.CalculateCount(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void CalculateStats_ShouldReturnAverageValue()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4 };

        // Act
        var result = _calcStats.CalculateAverage(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(2.5));
    }
}
