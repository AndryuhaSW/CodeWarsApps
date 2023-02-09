namespace CodeWars;

public class L7_ShadesOfGrey
{
    public static string[] ShadesOfGrey(int n)
    {
        if (n <= 0)
            n = 0;
        return Enumerable
            .Range(1, Math.Min(n, 254))
            .Select(x => String.Format("#{0:x2}{0:x2}{0:x2}", x))
            .ToArray();
    }
    
    //old version
    /*public static string[] ShadesOfGrey(int n)
    {
        if (n > 254)
            n = 254;
        else if (n <= 0)
            return new string[0];

        string[] res = new string[n];
        int i = 1;
        for (; i <= (n < 16 ? n : 15); i++)
            res[i-1] = "#" + String.Join("", Enumerable.Repeat("0" + Convert.ToString(i, 16), 3));
        for (; i <= n; i++)
            res[i-1] = "#" + String.Join("", Enumerable.Repeat(Convert.ToString(i, 16), 3));
        return res;
    }*/
}