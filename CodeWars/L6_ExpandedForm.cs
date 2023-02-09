namespace CodeWars;

public class L6_ExpandedForm
{
    public static string ExpandedForm(long num)
    {
        int l = num.ToString().Length;
        string[] res = new string[l];
        for (int i = 0; i < l; i++)
        {
            res[i] = ((num % 10) * Math.Pow(10, i)).ToString();
            num /= 10;
        } 
        return String.Join(" + ", res.Reverse().Where(x => x != "0"));
    }
}