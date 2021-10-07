using System;

namespace GithubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Praise(s1);
            Console.WriteLine(s2);
        }
        static string Praise(string s)
        {
           s=s+"さんやりますねぇ！";
            return s;
        }
    }
}

