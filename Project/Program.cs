using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Project
{
    public class Solution
    {
        static List<char> Possible;

        public static bool Check(string str)
        {
            return DoIt(str);
        }
        public static bool DoIt(string str)
        {
            if (str == null)
                return true;

            var idx = 0;
            Possible = new List<char>();

            while (idx < str.Length)
            {
                switch (str[idx])
                {
                    case '(':
                        Possible.Add(')');
                        break;
                    case '[':
                        Possible.Add(']');
                        break;
                    case ']':
                    case ')':
                        if ((Possible.Count == 0)
                          ||(Possible.ElementAt(Possible.Count - 1) != str[idx]))
                            return false;
                        Possible.RemoveAt(Possible.Count - 1);
                        break;
                }
                idx++;
            }
            return (Possible.Count == 0);
        }

        //  Auto generated code, please don't modify the code below
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Console.WriteLine(DoIt(expression));
        }
    }
}