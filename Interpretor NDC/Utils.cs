using System;
using System.Collections.Generic;
using System.Text;

namespace Interpretor_NDC
{
    class Utils
    {
        public static int StrIndexOf(char ch, string str, int nr_skip)  // pozitia ch sarind peste primele skip aparitii
        {
            int count = 0;

            while (str.IndexOf(ch, count) >= 0)
            {
                if (nr_skip < 0)
                    return count;
                else
                {
                    count = str.IndexOf(ch, count + 1);
                    if (count == -1)
                        return -1;
                    nr_skip--;
                }
            }
            return -1;
        }

        public static int StrCount(char ch, string str, int start_index)   // returneaza numraul de aparitii a unui caracter intrun sir
        {
            int count = 0;
            int pos = start_index;

            while (str.IndexOf(ch, pos) >= 0)
            {
                pos = str.IndexOf(ch, pos + 1);                     // sare la urmatorul
                if (pos == -1)
                    return count;
                count++;
            }
            return -1;
        }

        public static string GetSubstring(string str, string begin, string end) // returneaza stringul dintre bigin si end
        {
            string temp = "";

            int start = str.IndexOf(begin);
            int stop = str.IndexOf(end);

            if (start >= 0 && stop > 0 && stop > start)
                temp = str.Substring(start, stop - start);

            return temp;
        }
    }
}
