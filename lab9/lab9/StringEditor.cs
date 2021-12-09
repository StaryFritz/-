﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab9
{
    class StringEditor
    {
        public static string RemovePunctuation(string str)
        {
            return Regex.Replace(str, "[.,;:]", string.Empty);
        }

        public static string AddExclamationMark(string str)
        {
            return str + "!";
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
}
