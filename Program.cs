//https://leetcode.com/problems/isomorphic-strings/
//Accepted
//time limit exceed :/
//hint: dictionary (hashtable class can't be included)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isomorphic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function entry point");
            Console.WriteLine("result=" + IsIsomorphic("ab", "aa"));
            Console.ReadLine();
        }

        static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>(0);

            if (s.Length != t.Length)
            {
                return true;
            }

            char[] _s = s.ToCharArray();
            char[] _t = t.ToCharArray();
            
            for (int i = 0; i < _s.Length; i++)
            {
                if (dic.ContainsKey(_s[i]))
                {
                    char x;
                    dic.TryGetValue(_s[i], out x);

                    if (_t[i] != x)
                    {
                        return false;
                    }
                }
                else
                {
                    dic.Add(_s[i], _t[i]);
                }
            }

            dic.Clear();

            for (int i = 0; i < _t.Length; i++)
            {
                if (dic.ContainsKey(_t[i]))
                {
                    char y;
                    dic.TryGetValue(_t[i], out y);

                    if (_s[i] != y)
                    {
                        return false;
                    }
                }
                else
                {
                    dic.Add(_t[i], _s[i]);
                }
            }

            return true;
        }

        static bool IsIsomorphic_TIME_LIMIT_EXCEED(string s, string t)
        {
            Console.WriteLine("compare \"" + s + " and \"" + t + "\"");

            char[] _s = s.ToCharArray();
            char[] _t = t.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0)
                {
                    for (int j = i; j > -1; j--)
                    {
                        if (_s[j] == _s[i])
                        {
                            if (_t[j] != _t[i])
                            {
                                return false;
                            }
                        }

                        if (_t[j] == _t[i])
                        {
                            if (_s[j] != _s[i])
                            {
                                return false; 
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
