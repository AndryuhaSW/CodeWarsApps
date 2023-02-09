namespace CodeWars;

public class L7_SequenceSum
{
    public static int SequenceSum(int start, int end, int step)
    {
        int res = 0;
        for (int i = start; i <= end; i += step)
            res += i;
        return res;
    }
}