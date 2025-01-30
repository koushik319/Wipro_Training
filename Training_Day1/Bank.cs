using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public  class Bank
    {
        // Creating a Property 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        /*
        * Polyomorphism - we use virtual and override keywords in the method 
        * Inheritance - Inheritance in c# is done using the : , and it is used to extend the parent class methods and varaibles and make use of it in the child class.
        * Abstraction - Abstraction is hiding the Implemention and showing only the definition.
        * If we decalre abstarct class in parent then implementation will be there in the Child class.
        * If we want to use the abstract class we need to name the class as abstract and the methods can be abstarct as well as non-abstarct in the class
        * Abstarct methods should be decalared only in the abstarct class
        * We cannot create Instance/ Object of the Abstarct Class . 
         
         
         */

        public virtual void Accounttype()
        {
            string[] accounts = { "Savings", "Current", "Corporate" };

            foreach(string account in accounts)
            {
                Console.WriteLine(account);
            }
        }

    }


    public class SBI : Bank
    {
        public void Bankname()
        {
            Console.WriteLine("SBI BANK");
        }

        public override void Accounttype()
        {
            string[] accounts = { "Savings", "Business" };
            foreach(string account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }

    public class HDFC : Bank
    {
        public void BankName()
        {
            Console.WriteLine("HDFC BANK");
        }

        public override void Accounttype()
        {
            string[] accounts = { "Business", "Current" };

            foreach(string account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }

    public class IDBI : Bank
    {
        public void Bankname()
        {
            Console.WriteLine("IDBI Bank");
        }

        public static void BankDetails()
        {
            Console.WriteLine("This is the Bank located in Mumbai as Head Quarters");
        }

        public override void Accounttype()
        {
            string[] accounts = { "Savings", "Demat" };
            foreach(string account in accounts)
            {
                Console.WriteLine(account);
            }
        }
    }

    // Abstarction 

    public abstract class RBI
    {
        public void name()
        {
            Console.WriteLine("Rbi bank");
        }

        public abstract void services();

        public abstract void confidential();


       
    }

    public class UBI : RBI
    {
        public override void services()
        {
            Console.WriteLine("UBI services");
        }

        public  override void confidential()
        {
            Console.WriteLine("This Information is Confidential");
        }
    }


    // Constructor Overloading
    public class Iob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Iob()
        {
            Console.WriteLine("Default Constructor");
        }

        public Iob(string name , int id)
        {
            Name = name;
            Id = id;
        }

        public void print()
        {
            //Name = Console.ReadLine();
            //Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Name);
            Console.WriteLine(Id);

        }
    }
   
    public class punjabbank
    {
        public int Cid { get; set; }
        public string Cname { get; set; }

        public punjabbank()
        {
            Console.WriteLine("Default Constructor");
        }
        public punjabbank(int id ,string name)
        {
            Cid = id;
            Cname = name;
        }

        public void print1()
        {
            Console.WriteLine("Enter id");
           int  id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cid);

            Console.WriteLine("Enter name");
           string name = Console.ReadLine();

            Console.WriteLine(Cname);
        }
    }

    public class Pop
    {
        public Pop()
        {
            Console.WriteLine("Default Constructor");
        }
        public Pop(int id , string name)
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }

        static Pop()
        {
            Console.WriteLine("Static Consructor");
        }
      

        public Pop(int age, string location, string area)
        {
            Console.WriteLine(age);
            Console.WriteLine(location);
            Console.WriteLine(area);
        }

        public static  void log()
        {
            Console.WriteLine("Static Method");
        }
    }
}
