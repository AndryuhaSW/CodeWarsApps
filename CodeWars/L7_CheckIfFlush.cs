namespace CodeWars;

public class L7_CheckIfFlush
{
    public static bool CheckIfFlush(string[] cards)
    {
        return cards.All(x => x.Last() == cards.First().Last());
    }
    
    //old version
    /*public static bool CheckIfFlush(string[] cards)
    {
        string m = cards[0].Substring(cards[0].Length - 1);
        foreach (string el in cards)
            if (el.Substring(el.Length-1) != m)
                return false;
        return true;
    }*/
}