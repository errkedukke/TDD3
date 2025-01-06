using TDD.CalcStat;

namespace TDD.CalcStatsTests;

public class CalcStatsTests
{
    private CalcStats _calcStats;

    [SetUp]
    public void Setup()
    {
        _calcStats = new CalcStats();
    }

    [Test]
    public void CalculateMinimum_ShouldReturnMinimumValue()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4 };

        // Act
        var result = _calcStats.CalculateMinimum(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
}
