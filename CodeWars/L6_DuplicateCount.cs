namespace CodeWars;

public class L6_DuplicateCount
{
    /*public static void Main(string[] args)
    {
        Console.WriteLine(DuplicateCount("11223"));
        Console.WriteLine(DuplicateCount("122345688"));
    }*/
    public static int DuplicateCount(string str)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        str = str.ToUpper();
        foreach (char c in str)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        int res = 0;
        foreach (int i in dict.Values)
            if (i > 1)
                res++;
        return res;
    }
}