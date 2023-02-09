namespace CodeWars;

public class L7_Spoonerize
{
    public static string Spoonerize(string str)
    {
        string[] words = str.Split(" ");
        return string.Join(" ", words[1][0] + words[0][1..],
            words[0][0] + words[1][1..]);
    }
}