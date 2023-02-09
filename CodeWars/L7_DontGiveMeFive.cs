namespace CodeWars;

public class L7_DontGiveMeFive
{
    public static int DontGiveMeFive(int start, int end)
    {
        return Enumerable.Range(start, end - start + 1)
            .Count(x => !x.ToString()
                .Contains("5"));
    }
    
    //old version
    /*public static int DontGiveMeFive(int start, int end)
    {
        int c = 0;
        int i;
        for (i = start; i <= end; i++)
        {
            int ii = Math.Abs(i);
            while (ii > 0)
            {
                if (ii % 10 == 5)
                {
                    c++;
                    break;
                }
                ii /= 10;
            }
        }
        
        return i - start - c;
    }*/
}