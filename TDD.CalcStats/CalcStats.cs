
namespace TDD.CalcStat;

public class CalcStats
{
    public int CalculateMinimum(int[] numbers)
    {
        int min = numbers[0];
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    public int CalculateMaximum(int[] numbers)
    {
        throw new NotImplementedException();
    }
}
