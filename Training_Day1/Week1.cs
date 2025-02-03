using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training_Day1
{
    public class Week1
    {
        #region 1D Array
        public void OneArray() {
            Console.WriteLine("Enter the size of Array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Array Values are");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        #endregion

        #region MultiDimesion Array
        public void Multidimension()
        {
            Console.WriteLine("Enter the value of row and column");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[x, y];

            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("The Values of Array are :");

            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
        #endregion

        #region Jagged Array
        public void Jagged()
        {
            int[][] arr1 = new int[3][];

             arr1[0] = new int[2];
             arr1[1] = new int[4];
             arr1[2] = new int[3];

            arr1[0][0] = 1;
            arr1[0][1] = 2;

            arr1[1][0] = 3;
            arr1[1][1] = 4;
            arr1[1][2] = 5;
            arr1[1][3] = 6;

            arr1[2][0] = 7;
            arr1[2][1] = 8;
            arr1[2][2] = 9;

            Console.WriteLine("The Values of Array are :");

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine(arr1[i][j]);
                }
            }
        }
        #endregion


    }
    #region Virtual and Override
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Branch { get; set; }

        public  virtual void Accounttype()
        {
            string[] type = { "Savings", "Current" };

            foreach(var item in type)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class DBS : Account
    {
        public void Bankname()
        {
            Console.WriteLine("DBS");
        }

        public override void Accounttype()
        {
            string[] act = { "Demat", "Business" };

            foreach(var item in act)
            {
                Console.WriteLine(item);
            }
        }

        public static void Region()
        {
            Console.WriteLine("South-Zone");
        }
    }
    #endregion


    #region Abstraction
    public abstract class Cars
    {
        public int Model { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        
        public void Type()
        {
            Console.WriteLine("SUV");
        }
        public abstract void GetDetails();
    }

    public class Lambo : Cars
    {
        public override void GetDetails()
        {
            Console.WriteLine("This is Lamborgini Car");
        }
    }
    #endregion


    #region Constructor OverLoading

    public class Books
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string Bookcode { get; set; }

         static Books()
        {
            Console.WriteLine("Static Constructor");
        }
        public  Books(int bookid)
        {
            Bookid = bookid;

            Console.WriteLine(Bookid);
        }
        public Books(int bookid,string bookname)
        {
            Bookid =bookid ;
            Bookname=bookname ;

            Console.WriteLine(Bookid);
            Console.WriteLine(Bookname);
        }
        public Books(int bookid, string bookname, string bookcode)
        {
            bookid = Bookid;
            bookname = Bookname;
            bookcode = Bookcode;


        }
    }
    #endregion

    #region Non-Generic Collections

    public class NonGenCollect
    {
        #region ArrayList
        public void Alist()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Ram");
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add("Dummy");

            al.Remove("Dummy");
            al.RemoveAt(5);

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Stack
        public void Stack1()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Pop();

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Queue 

        public void Queue1()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue("Ram");
            q.Enqueue("Shiva");
            q.Enqueue(3);
            q.Dequeue();

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }

    #endregion


    #region Generic Collection 
    public class GenCollect
    {
        #region List
        public void Lis()
        {
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            l1.Remove(5);
            l1.RemoveAt(0);

            foreach(var item in l1)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Dictionary

        public void Dicti()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Shiva");
            dict.Add(2, "Ram");
            dict.Add(3, "Krishna");

            foreach(var item in dict)
            {
                Console.WriteLine(item);
                //Console.WriteLine("The Keys are :");
                //Console.WriteLine(item.Key);
                //Console.WriteLine("The values are :");
                //Console.WriteLine(item.Value);
                //Console.WriteLine(item.Key);
            }

        }
        #endregion

    }
    #endregion


    #region Exception handling

    public class Excemp
    {
        public void exc()
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                int z = x / y;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Final Block is Executed");
            }
        }
    }
    #endregion

    //public class Files
    //{
    //    public int Eid { get; set; }
    //    public Files(int id)
    //    {
    //        Eid = id;
    //    }
    //    public  void FileCreate()
    //    {
    //        FileStream fs = new FileStream("Demo.txt", FileMode.Create, FileAccess.Write);
    //        StreamWriter sw = new StreamWriter(fs);

    //        sw.WriteLine("Id:")
    //    }
    //}
}
