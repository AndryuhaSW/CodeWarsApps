namespace CodeWars;

public class L6_FindEvenIndex
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum())
                return i;
        return -1;
    }
}