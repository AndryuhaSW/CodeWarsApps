namespace CodeWars;

public class L7_Triangular
{
    public static int Triangular(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1)
            return 1;
        return Triangular(n - 1) + n;
    }
}