namespace CodeWars;

public class L8_DivisibleBy
{
    public static int[] DivisibleBy(int[] numbers, int divisor)
    {
        List<int> result = new List<int>();
        foreach(int el in numbers)
            if (el % divisor == 0)
                result.Add(el);
        return result.ToArray();
    }
}