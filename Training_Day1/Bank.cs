using System;
using System.Collections.Generic;
using System.Linq;
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

}
