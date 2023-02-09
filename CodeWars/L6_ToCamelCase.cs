namespace CodeWars;

public class L6_ToCamelCase
{
    public static string ToCamelCase(string str)
    {
        string[] s = str.Split(new char[] { '-', '_' });
        return s[0] +
               String.Join("", s.Skip(1).Select(x => String.Join("", (x.First().ToString().ToUpper() + String.Join("", x.Skip(1))))).ToArray());
    }
}