using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public class Employee
    {
        public void CreateEmployee<T>(T input)
        {
            Console.WriteLine(input);
        }
   
        public void Createemploy()
        {
            // Non - Generic Type  - It is not type safe , Any type of data can be stored.
            #region ArrayList

            ArrayList al = new ArrayList();
            al.Add("Shiva");
            al.Add(1);
            al.Add("Ram");
            al.Add("Dummy");
            al.RemoveAt(3);

            foreach(object obj in al)
            {
                Console.WriteLine(obj);
            }

            #endregion

            #region Stack
            Console.WriteLine("Stack Implementation");
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push("Ram");
            s.Push("Shiva");
            s.Push("Unknown");

            Console.WriteLine(s.Pop());

            foreach(object o in s)
            {
                Console.WriteLine(o);
            }




            #endregion

            #region Queue

            Console.WriteLine("Queue Implementation");
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("DOn");
            q.Enqueue("Shyam");
            q.Enqueue(2);

            Console.WriteLine(q.Dequeue());

            foreach(object item in q)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region HashTable

            Console.WriteLine("Hashtable");

            Hashtable h = new Hashtable();
            h.Add(1, "Shiva");
            h.Add(2, "Ram");
            h.Add(3, "Syam");

            foreach(object item in h)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region SortedList
            Console.WriteLine("SortedList Implementation");
            SortedList s1 = new SortedList();
            s1.Add(2, "Benz");
            s1.Add(3, "BMW");
            s1.Add(1, "Jaguar");
            s1.Add(4, "Bentley");

            foreach(Object item in s1)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region Generic Type
           
            Console.WriteLine("Generic Type List");

            List<int> list1 = new List <int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);

            //list1.Reverse();
            list1.Remove(4);
            

            foreach(int lists in list1)
            {
                Console.WriteLine(lists);
            }
            #endregion


            #region Dictionary 

            Console.WriteLine("Dictionary");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "BMW");
            dict.Add(2, "Harley");
            dict.Add(3, "R15");

            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }

            #endregion

           
        }

        public void Exceptional()
        {

            #region Exception
            #endregion

            try
            {
                Console.WriteLine("Enter 2 numbers");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("The Number cannot be divided by Zero");
            }
            finally
            {
                Console.WriteLine("The Finally Block");
            }

            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Enter values of x and y");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                int result = x / y;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by Zero Exception");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block is Called");
            }
        }
    }
}
