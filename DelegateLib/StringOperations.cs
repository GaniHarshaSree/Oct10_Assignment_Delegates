﻿using System;


namespace DelegateLib
{
    public delegate String AttachStringToEachOther(string s1, string s2);
    public delegate int FindLength(string s1);
    public delegate String Greeting(string s);
    public delegate String MakeFirstChUpper(string s);
    public class StringOperations
    {
        public string ConcatStrings(string s1,string s2)
        {
            return s1 + s2;
        }

        public int StringLength(string s)
        {
            return s.Length;
        }
     
       public string Greet(string name) {
            string s = $"Welcome Back {name}, waiting for u long time .";
            Console.WriteLine(s);
            return null;
        }

        public string MakeFirstCharacterUppecase(string str) {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
