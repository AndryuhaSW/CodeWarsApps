namespace CodeWars;

public class L8_GetAverage
{
    public static int GetAverage(int[] marks)
    {
        int sumOfMarks = 0;
        int i;
        for (i = 0; i < marks.Length; i++)
            sumOfMarks += marks[i];
        return (int)(sumOfMarks / i);
    }
}