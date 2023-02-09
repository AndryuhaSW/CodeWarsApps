namespace CodeWars;

public class L7_Cats
{
    public static int Cats(int start, int finish)
    {
        int dif = finish - start;
        return dif / 3 + dif % 3;
        /*Recurtion
        if (start == finish)
            return 0;
        if (start > finish)
            return 100;

        int first = Cats(start + 1, finish);
        int second = Cats(start + 3, finish);

        if (first < second)
            return first + 1;
        return second + 1;*/
    }
}