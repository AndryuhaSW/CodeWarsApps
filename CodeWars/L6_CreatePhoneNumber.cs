namespace CodeWars;

public class L6_CreatePhoneNumber
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        return long.Parse(String.Join("", numbers)).ToString("(000) 000-0000");
    }
}