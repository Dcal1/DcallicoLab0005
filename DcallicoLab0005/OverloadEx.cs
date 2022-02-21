using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcallicoLab0005
{
    internal class OverloadEx
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2, int num3)
        { 
            return num1 + num2 + num3;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }

        public static string Add(string a, string b, string c)
        {
            return a + b + c;
        }

    }
}
