namespace CodeWars;

public class L8_Between
{
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(a, b-a+1).ToArray();
    }
}