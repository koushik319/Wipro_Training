using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    public abstract class Animal
    {
        public string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string Getname()
        {
            //Console.WriteLine("Enter the name of the Dog : ");
            //name = Console.ReadLine();
            //Console.WriteLine("The Dog Name is "+name);

            return Name;
        }
        public  abstract void Eat();
      
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating Chicken Bone");
        }
    }
}
