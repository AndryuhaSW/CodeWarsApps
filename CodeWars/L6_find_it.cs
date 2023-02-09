namespace CodeWars;

class L6_find_it
{
    public static int find_it(int[] seq) 
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int num in seq)
        {
            if (dic.ContainsKey(num))
                dic[num]++;
            else
                dic.Add(num, 1);
        }
        foreach (int key in dic.Keys)
            if (dic[key] % 2 != 0)
                return key;
        return 0;
    }
       
}