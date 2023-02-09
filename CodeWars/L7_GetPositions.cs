namespace CodeWars;

public class L7_GetPositions
{
    public static int[] GetPositions(int s)
    {
        return new int[]
        {
            s%3,
            s/3%3,
            s/9%3,
        };
    }
}