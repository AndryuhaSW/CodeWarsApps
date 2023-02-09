namespace CodeWars;

public class L8_FixTheMeerkat
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        string temp = arr[0];
        arr[0] = arr[2];
        arr[2] = temp;
        return arr;
    }
}