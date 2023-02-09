namespace CodeWars;

public class L7_HasUniqueChars
{
    public class Unique
    {
        public static bool HasUniqueChars(string str)
        {
            var a = str.ToCharArray();
            for(int i = 0; i < a.Length; i++)
            for (int j = i + 1; j < a.Length; j++)
                if (a[i] == a[j])
                    return false;
            return true;
        }
    }
}