using System;

namespace Implement_strStr_or_IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the haystack !");
            var haystack = Console.ReadLine();
            Console.WriteLine("Enter the needle !");
            var needle = Console.ReadLine();
            Console.WriteLine(StrStr(haystack, needle));
        }

        static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle)) return 0;
            int haystackLength = haystack.Length;
            int needleLength = needle.Length;
            if (haystack == needle) return 0;
            if(needleLength > haystackLength) return -1;
            for(int i =0; haystackLength - i >= needleLength; i++)
            {
                if (haystack.Substring(i, needleLength) == needle) return i;
            }

            return -1;
        }
    }
}
