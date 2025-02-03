using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public static class Extension
    {
        public static int Read(this int value)
        {
            int result = 0;
            if(value>10 && value < 20)
            {
                result = value + 10;
            }
            else if(value>20 && value < 30)
            {
                result = value + 20;
            }
            else if(value>30 && value < 40)
            {
                result = value + 30;
            }
            return result;
        }
    }

    public static class Extension1
    {
        public static string Print(this string name)
        {
            string s = "Welcome," + name;
            return s;
        }
    }
}
