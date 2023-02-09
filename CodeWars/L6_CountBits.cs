namespace CodeWars;

public class L6_CountBits
{
    /*public static void Main(string[] args)
    {
        Console.WriteLine(CountBits(5));
    }*/
    public static int CountBits(int n)
    {
        string binaryCod = Convert.ToString(n, 2);
        int count = 0;
        foreach (char sym in binaryCod)
            if (sym == '1')
                count++;
        return count;
    }
}