using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public delegate void DelegateBasic();
    public class DelegateDemo
    {
        public void Getname()
        {
            Console.WriteLine("getname is called");
        }

        public void GetRollno()
        {
            Console.WriteLine("GetRollno is called");
        }

        public void GetClass()
        {
            Console.WriteLine("GetClass is called");
        }
    }
}
