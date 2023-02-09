namespace CodeWars;

using System.Linq;
using System;

public class L6_SpinWords
{
    public static string SpinWords(string sentence)
    {
        return String.Join(' ', sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
    }
}