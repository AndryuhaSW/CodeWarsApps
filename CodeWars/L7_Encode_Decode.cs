namespace CodeWars;

public class L7_Encode_Decode
{
    public static string Encode(string s)
    {
        int start = 0;
        int end = s.Length-1;
        string res = string.Empty;
        while (start < end)
            res += s[start++].ToString() + s[end--].ToString();
        if (s.Length % 2 == 1)
            res += s[start].ToString();
        return res;
    }

    public static string Decode(string s)
    {
        string res = string.Empty;
        for (int i = 0; i < s.Length; i += 2)
        {
            res += s[i].ToString();
        }
            
        int j;
        if (s.Length % 2 == 0)
            j = s.Length - 1;
        else
            j = s.Length - 2;
        for (; j > 0; j -= 2)
            res += s[j].ToString();
        return res;
    }
}