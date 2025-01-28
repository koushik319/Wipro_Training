using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public class Task1
    {

        public void Task()
        {
            Console.WriteLine("Enter size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Enter the Array Values :");
            for(int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

             }

            int[][] output = new int[2][];

            int [] evenarray = Array.FindAll(a, x => x % 2 == 0);
            int [] oddarray = Array.FindAll(a,   x=>  x % 2 != 0);

            output[0] = evenarray;
            output[1] = oddarray;


            Console.Write("The Even numbers are : ");
            foreach(int even in output[0])
            {
                Console.WriteLine(even+ " ");
            }

            Console.WriteLine("The Odd numbers are : ");
            foreach(int odd in output[1])
            {
                Console.WriteLine(odd + " ");
            }
        }

        public void Task2()
        {
            Console.WriteLine("Enter size of Array ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] temp = new int[n];
            int j = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
               

            }
            for (int i = 0; i < arr.Length; i++)
            {
              
                if (arr[i] != 0)
                {
                    temp[j++] = arr[i];
                }
            }

            while (j < n)
            {
                temp[j++] = 0;
            }

            for(int i = 0; i < n; i++)
            {
              arr[i]= temp[i];
            }

            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }


}
