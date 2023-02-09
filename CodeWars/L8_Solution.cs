namespace CodeWars;

public class L8_Solution
{
    public static string Solution(string a, string b)
        => a.Length > b.Length ? String.Concat(b,a,b) : string.Concat(a,b,a);
}