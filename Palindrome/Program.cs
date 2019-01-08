using System;
using System.Text;
using System.Text.RegularExpressions;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        // replace everything that is not a letter with nothing ""
        string str = Regex.Replace(word.ToUpper(), @"[^\w]", "");

        char[] letters = str.ToCharArray();
        int mid = letters.Length / 2;
        int size = letters.Length;
        bool result = true;

        for (int i = 0; i <= mid; i++)
        {
            if (letters[i].ToString() != letters[(letters.Length - 1) - i].ToString())
                result = false;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Press any key to end");
        Console.ReadKey();
    }
}
