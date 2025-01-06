
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
        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    public int CalculateCount(int[] numbers)
    {
        int count = 0;
        foreach (var _ in numbers)
        {
            count++;
        }
        return count;
    }

    public double CalculateAverage(int[] numbers)
    {
        throw new NotImplementedException();
    }
}
