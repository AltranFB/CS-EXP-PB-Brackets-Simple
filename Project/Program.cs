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
        public static bool Check(string str)
        {
            return DoIt(str);
        }
        public static bool DoIt(string str)
        {
            if (0 == str.Length || null == str)
                return true;

            if (1 == str.Length)
                return false;

            if ((str[0] == '(' && str[str.Length - 1] == ')')
             || (str[0] == '[' && str[str.Length - 1] == ']'))
            {
                if (str.Length == 2)
                    return true;
                return DoIt(str.Substring(1, str.Length - 2));
            }

            int lastOcc;
            if (str[0] == '(')
                lastOcc = str.LastIndexOf(')');
            else if (str[0] == '[')
                lastOcc = str.LastIndexOf(']');
            else
                return false;
            if (lastOcc == -1)
                return false;

            return DoIt(str.Substring(1, lastOcc - 1)) && DoIt(str.Substring(lastOcc + 1));
        }

        //  Auto generated code, please don't modify the code below
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Console.WriteLine(DoIt(expression));
        }
    }
}