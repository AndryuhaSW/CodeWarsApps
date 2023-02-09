namespace CodeWars;

public class L6_Solution
{
    /*public static void Main(string[] args)
    {
        Console.WriteLine(Solution(123));
    }*/
    
    //first
    public static int Solution(int value)
    {
        if (value <= 0)
            return 0;
        return Enumerable.Range(1, value - 1).Select(x =>
            x % 15 == 0 ? x :
            x % 3 == 0 ? x :
            x % 5 == 0 ? x :
            0).ToArray().Sum();
    }
    
    //second
    /*public static int Solution(int value)
    {
        if (value <= 0) return 0;
        return Enumerable.Range(1, value - 1)
            .Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }*/
}