namespace CodeWars;

public class L7_GrowingPlant
{
    public int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
    {
        for (int i = 1; ; i++)
        {
            DesiredHeight -= UpSpeed; if (DesiredHeight <= 0) return i;
            DesiredHeight += DownSpeed; if (DesiredHeight <= 0) return i;
        }
    }
    
    //old version
    /*public int GrowingPlant(int UpSpeed, int DownSpeed, int DesiredHeight)
    {
        int c = 0;
        int h = 0;
        while (true)
        {
            c++;
            if (h < DesiredHeight)
                h += UpSpeed;
            else 
                break;
            if (h < DesiredHeight)
                h -= DownSpeed;
            else
                break;

        }
        return c;
    }*/
}
