using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetPluralized(string word, int count)
            {
                return count != 1 ? word + "s" : word;
            }
            for (int i = 0; i < 4; i++)
            {
                string dayOrDays = GetPluralized("day", i);
                string msg = String.Format("{0} {1}", i, dayOrDays);
                Write.Line(msg);
            }
        }
    }
}
