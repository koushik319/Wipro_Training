using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public  class Midweek
    {
        public void Basic()
        {

            Console.WriteLine("Hello World");


            Console.WriteLine("Enter tha value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Enter your marks:");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(marks);

            if(marks> 90)
            {
                Console.WriteLine("O Grade");
            }

            else
            {
                Console.WriteLine("A+ Grade");
            }

            Console.WriteLine("Enter the value to loop");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }

        }     
    }

     public class ArrayDemo1 {
     public void ArrayPractise()
        {

            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[n];

            Console.WriteLine("Enter the Values of Array :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values of array are :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }


    public class MultiDimensionalArray
    {
        public void Multidimen()
        {
            Console.WriteLine("Enter the size of the row");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of the column");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[m, n];

            Console.WriteLine("Read the Value of 2d Array");

            for( int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Value of 2d arrays are:");

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine(arr1[i, j]);
                }
               
            }
        }
    }


    public class Jagarray
    {
        public void jagg()
        {
            int[][] arr2 = new int[3][];

            arr2[0] = new int[2];
            arr2[1] = new int[3];
            arr2[2] = new int[5];

            arr2[0][0] = 1;
            arr2[0][1] = 2;

            arr2[1][0] = 3;
            arr2[1][1] = 4;
            arr2[1][2] = 5;

            arr2[2][0] = 6;
            arr2[2][1] = 7;
            arr2[2][2] = 8;
            arr2[2][3] = 9;
            arr2[2][4] = 10;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < arr2[i].Length; j++)
                {
                    Console.WriteLine(arr2[i][j] +" ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    public  class Bank1
    {
        public int Id1 { get; set; }
        public string Sname { get; set; }
        public string Braanch { get; set; }

        public virtual void branc()
        {
            string[] types = { "Hyd", "Bang", "Chen" };

            foreach(string type in types)
            {
                Console.WriteLine(type);
            }
        }

        public virtual void read()
        {
            Console.WriteLine("Reading");
        }

    }

    public class SBI1 : Bank1
    {
        public void sbiread()
        {
            Console.WriteLine("sbi read");
        }
        public override void branc()
        {
            string[] types = { "Mum", "Hyd", "Chen" };
            foreach(string type in types)
            {
                Console.WriteLine(type);
            }
        }
    }

    public class Icici1 : Bank1
    {
        public void iciciread()
        {
            Console.WriteLine("Icici read");
        }

        public override void read()
        {
            Console.WriteLine("Reading ICICI");
        }
    }

    public abstract class Car
    {
        public void model()
        {
            Console.WriteLine("Car Model");
        }

        public abstract void modelnumber();
    }

    public class Bmw : Car
    {
        public override void modelnumber()
        {
            Console.WriteLine("789552");
        }

        public void model()
        {
            Console.WriteLine("BMW");
        }
    }

    public class Benz: Car
    {
        public override void modelnumber()
        {
            Console.WriteLine("15222");
        }
    }

    // We cannot Object for the Static class 
    public static class Bike
    {
        public static void model()
        {
            Console.WriteLine("BMW Bike");
        }
    }

}
