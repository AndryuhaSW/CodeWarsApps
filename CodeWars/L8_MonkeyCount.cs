namespace CodeWars;

public class L8_MonkeyCount
{
    public static int[] MonkeyCount(int n)
    {
        int[] monkeys = new int[n];
        for (int i = 1; i <= n; i++)
            monkeys[i - 1] = i;
        return monkeys;
    }
}