namespace CodeWars;

public class L7_ModifyMultiply
{
    public static string ModifyMultiply(string str, int loc, int num)
    {
        return String.Join("-", Enumerable.Repeat(str.Split(" ")[loc],num));
    }
}