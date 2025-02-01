using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training_Day1
{
    public class Transaction

    {
        // Properties Declaration
        public int TransactionId { get; set; }
        public string TransactionName { get; set; }
        public string Descrption { get; set; }
        public string Type { get; set; }

        // Constructor 
        public Transaction(int tid, string tname, string desc, string type)
        {
            TransactionId = tid;
            TransactionName = tname;
            Descrption = desc;
            Type = type;
        }
        public void WriteTransaction()
        {
            FileStream fs = new FileStream("transaction.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(TransactionId);
            sw.WriteLine(TransactionName);
            sw.WriteLine(Descrption);
            sw.WriteLine(Type);

            sw.Close();
            fs.Close();

        }

        public void Appendtransaction()
        {
            FileStream fs = new FileStream("transaction.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(TransactionId);
            sw.WriteLine(TransactionName);
            sw.WriteLine(Descrption);
            sw.WriteLine(Type);
            sw.WriteLine("----------------------");
            sw.Close();
            fs.Close();

        }

        public void ReadTransaction()
        {
            FileStream fs1 = new FileStream("transaction.txt",FileMode.Open, FileAccess.Read);

            StreamReader sw1= new StreamReader(fs1);

            sw1.Close();
            fs1.Close();

        }

        // To Read the values from the file and displaying in console 
        public void ReadTransaction1()
        {
            FileStream fs = new FileStream("transaction.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            while (sr.Peek() > 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
            fs.Close();
        }
    }
}
