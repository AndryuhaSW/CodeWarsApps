namespace CodeWars;

public class L8_ReverseWords
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Reverse());
    }
    
    //old version
    /*public static string ReverseWords(string str)
    {
        string[] partsOfStr = str.Split(' ');
        string res = string.Empty;
        for (int i = partsOfStr.Length - 1; i >= 0; i--)
            res += partsOfStr[i] + " ";
        return res.Substring(0,res.Length-1);
    }*/
}