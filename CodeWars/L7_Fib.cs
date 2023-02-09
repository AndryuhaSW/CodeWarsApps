namespace CodeWars;

public class L7_Fib
{
    public static int Fib(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        return Fib(n - 1) + Fib(n-2);
    }
    
    //old versiom
    /*public static int Fib(int n)
    {
        int first = 1;
        int second = 1;
        for (int i = 2; i < n; i++)
        {
            int temp = first;
            first = second;
            second = temp + first;
        }
        return second;
    }*/
}