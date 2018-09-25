using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class Program
    {
        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
        public static string Reverse(string s)
        {
            string reversedString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedString += s[i];
            }
            return reversedString;
        }
        public static string ReplaceSpace(string s)
        {
            string HTMLString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    HTMLString += '-';
                }
                else
                {
                    HTMLString += s[i];
                }
            }
            return HTMLString;
        }

        public static string SubString(string stringToReduce, int startingIndex)
        {
            if (startingIndex < 0 || startingIndex >= stringToReduce.Length)
            {
                return null;
            }
            else
            {
                string subString = "";
                for (int i = startingIndex; i < stringToReduce.Length; i++)
                {
                    subString += stringToReduce[i];
                }
                return subString;
            }
        }
        static void Main(string[] args)
        {
            string Mainstring = "afseiajilf aefauukafhseku kgfaseyfgayegf kaygsefjaygsekf kasefa ykegfrsgruilghrugsamsecage";
            string string1 = Mainstring;
            string1 = ReplaceSpace(string1);
            string1 = Reverse(string1);
            int i = string1.Length;
            i = i / 2;
            string substr = SubString(string1, i);
            string1 = SortString(string1);
            string1 += substr;
            Console.WriteLine(string1);
            Console.Read();
        }
    }
}
