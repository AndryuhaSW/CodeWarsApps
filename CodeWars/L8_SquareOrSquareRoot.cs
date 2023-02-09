namespace CodeWars;

public class L8_SquareOrSquareRoot
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if ((int)Math.Sqrt(array[i]) == Math.Sqrt(array[i]))
                array[i] = (int)Math.Sqrt(array[i]);
            else
                array[i] = array[i] * array[i];
        }
        return array;
    }
}