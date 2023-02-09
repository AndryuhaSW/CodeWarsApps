namespace CodeWars;

public class L8_ExpressionsMatter
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        int[] res = {
            a*b*c,
            a*b+c,
            a*(b+c),
            (a+b)*c,
            a+b*c,
            a+b+c,
        };
        return res.Max();
    }
}