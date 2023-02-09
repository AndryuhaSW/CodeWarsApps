namespace CodeWars;

public class L7_IsLeapYear
{
    public static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
            return true;
        if (year % 100 == 0)
            return false;
        return year % 4 == 0;
    }
    
    //old version
    /*public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0)
                return false;
            return true;
        }
        return false;
    }*/
}