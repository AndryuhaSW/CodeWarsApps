namespace CodeWars;

public class L7_GetFizzBuzzArray
{
    public static string[] GetFizzBuzzArray(int n)
    {
        return Enumerable.Range(1, n).Select(x => 
            x % 15 == 0 ? "FizzBuzz" : 
            x % 3 == 0 ? "Fizz" : 
            x % 5 == 0 ? "Buzz" : 
            x.ToString()).ToArray();
    }
    
    //old version
    /*public static string[] GetFizzBuzzArray(int n)
    {
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0)
                arr[i] = "FizzBuzz";
            else if ((i + 1) % 5 == 0)
                arr[i] = "Buzz";
            else if ((i + 1) % 3 == 0)
                arr[i] = "Fizz";
            else
                arr[i] = (i + 1).ToString();
        }
        return arr;
    }*/
}