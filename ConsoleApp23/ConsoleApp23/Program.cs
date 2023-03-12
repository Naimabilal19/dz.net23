using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string str = "ahb acb aeeb adcb axeb";
            string pattern = @"(\a)\w(\b)&";
            MatchCollection match = Regex.Matches(str, pattern);
            foreach(var i in match)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //2
            string str2 = "aba aca aea abba adca abea";
            string pattern2 = @"^(a)+\w+(a)\s?$";
            MatchCollection match2 = Regex.Matches(str2, pattern2);
            foreach (var i in match2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //3
            string str3 = "aba aca aea abba adca abea";
            string pattern3 = @"^(ab)+\w+(a)\s?$";
            MatchCollection match3 = Regex.Matches(str3, pattern3);
            foreach (var i in match3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //4
            string str4 = "aa aba abba abba abbba abca abea";
            string pattern4 = @"^(a|b)+\w+(a)\s?$";
            MatchCollection match4 = Regex.Matches(str4, pattern4);
            foreach (var i in match4)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //5
            string str5 = "aa aba abba abba abbba abca abea";
            string pattern5 = @"^(a|b)+\w*(a)\s?$";
            MatchCollection match5 = Regex.Matches(str5, pattern5);
            foreach (var i in match5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //6
            string str6 = "aa aba abba abba abbba abca abea";
            string pattern6 = @"^(a|b)+\w?(a)\s?$";
            MatchCollection match6 = Regex.Matches(str6, pattern6);
            foreach (var i in match6)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //7
            string str7 = "aa aba abba abba abbba abca abea";
            string pattern7 = @"^(a|b)+\w?(b|a)\s?$";
            MatchCollection match7  = Regex.Matches(str7, pattern7);
            foreach (var i in match7)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //8
            string str8 = "aa abab abab abba abababab abea";
            string pattern8 = @"^(ab)+\s?$";
            MatchCollection match8 = Regex.Matches(str8, pattern8);
            foreach (var i in match8)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
