namespace CodeWars;

public class L7_NextPal
{
    public static int NextPal(int val)
    {
        do
            val++;
        while (val.ToString() != String.Concat(val.ToString().Reverse()));
        return val;
    }
}