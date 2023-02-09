namespace CodeWars;

using System.Linq;
using System;

public class L6_SpinWords
{
    public static string SpinWords(string sentence)
    {
        return String.Join(' ', sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
    }
    
    //second realisation
    /*public static string SpinWords(string sentence)
    {
        string[] sent = sentence.Split(' ');
        for (int i = 0; i < sent.Length; i++)
            if (sent[i].Length >= 5)
                sent[i] = Reverse(sent[i]);
        return String.Join(" ", sent);
    }
  
    private static string Reverse(String str)
    {
        string res = String.Empty;
        for (int i = str.Length-1; i >= 0; i--)
            res += str[i];
        return res;
    }*/
    
}