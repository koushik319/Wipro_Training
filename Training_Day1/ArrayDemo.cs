using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public class ArrayDemo
    {
       public void Find()
        {
            // int ar[] = new int[3];
            //int[] a = { 1, 2, 3 };
            Console.WriteLine("Enter the size of Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int []arr= new int[n];

            //arr[0] = 12;
            //arr[1] = 15;
            //arr[2] = 20;
            //arr[3] = 90;
            //arr[4] = 8;
            Console.WriteLine("Reading Array Values");

            for(int i = 0; i < arr.Length; i++)
            {
              arr[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Array Values are : ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public void MultiDimension()
        {
            Console.WriteLine("Enter the values of m and n ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr1= new int[m, n];

            //arr1[0, 0] = 1;
            //arr1[0, 1] = 2;
            //arr1[0, 2] = 3;

            //arr1[1, 0] = 4;
            //arr1[1, 1] = 5;
            //arr1[1, 2] = 6;

            Console.WriteLine("Enter MultiDimension Array Values");

            for(int i = 0; i< m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr1[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("The Array Values are : ");

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr1[i, j]);
                }
            }

        }


        public void JaggedArray()
        {
            Console.WriteLine("Jagged Array :");

            int[][] counter = new int[2][];

            counter[0] = new int[2];
            counter[1] = new int[3];

            counter[0][0] = 2;
            counter[0][1] = 3;


            counter[1][0] = 10;
            counter[1][1] = 12;
            counter[1][2] = 56;

            Console.WriteLine(counter[1][0]);
            
        }
    }
}
