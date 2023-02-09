namespace CodeWars;

public class L7_Partlist
{
    public static string[][] Partlist(string[] arr)
    {
        return Enumerable
            .Range(1, arr.Length - 1)
            .Select(i => new string[] {String.Join(" ", arr.Take(i)), String.Join(" ", arr.Skip(i))})
            .ToArray();
    }
    
    //old version
    /*public static string[][] Partlist(string[] arr)
    {
        string[][] res = new string[arr.Length - 1][];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            res[i] = new string[2];
            res[i][0] = String.Join(" ",arr[0..(i+1)]);
            res[i][1] = String.Join(" ",arr[(i+1)..(arr.Length)]);
        }
        return res;
    }*/
}