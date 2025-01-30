// Day-1

using System.Text;
using Training_Day1;

// Collections

// Generic Collection
//Employee e = new Employee();
//e.CreateEmployee<int>(1);
//e.CreateEmployee<string>("Shiva");
//e.CreateEmployee<double>(1.43);

// Non - Generic Collection 

Employee e = new Employee();
e.Createemploy();

//Constructor Overloading 
//Pop p = new Pop();
//Pop p1 = new Pop(1,"Shiva");
//Pop p2 = new Pop(100, "Shiva", "Kailash");
//Pop.log();

//punjabbank p1 = new punjabbank();
//p1.print1();
//Iob i = new Iob("Shiva",15);
//i.print();

// MidWeek Practise on 29th Jan 2025
//Midweek m = new Midweek();
//m.Basic();

//1 D Arrays
//ArrayDemo1 a = new ArrayDemo1();
//a.ArrayPractise();

//Multi Dimension Array 
//MultiDimensionalArray mul = new MultiDimensionalArray();
//mul.Multidimen();

//Jagged Array
//Jagarray jagery = new Jagarray();
//jagery.jagg();

//Bank1 b = new Bank1();
//b.branc();
//b.Id1 = 1;
//b.Sname = "Ss";



//SBI1 s = new SBI1();
//s.branc();
//s.Id1 = 2;
//Console.WriteLine(s.Id1);

//Bmw b = new Bmw();
//b.modelnumber();
//b.model();

//Benz b1 = new Benz();
//b1.modelnumber();
//b1.model();

//Bike b = new Bike();
//Bike.model();


//Abstraction 


//Dog dog = new Dog();
//dog.SetName(Console.ReadLine());
//Console.WriteLine(dog.Getname());
//dog.Eat();

//UBI ubi = new UBI();
//ubi.services();
//ubi.confidential();

//RBI rbi = new UBI();
//rbi.services();
//rbi.confidential();


// Polymorphism 

//Bank mainbank = new Bank();
//mainbank.Name = "RBI";
//mainbank.Accounttype();


//SBI sbibank = new SBI();
//sbibank.Bankname();
//sbibank.Accounttype();

//HDFC hdfcbank = new HDFC();
//hdfcbank.BankName();
//hdfcbank.Accounttype();

//IDBI idbibank = new IDBI();
//idbibank.Accounttype();
//// TO acess Static methods we need to use the Class Name 
//IDBI.BankDetails();
////idbibank.Name = "IDBI";

// Sinlge Dimension Array 
// To Call the method of Array in ArrayDemo Class  
//ArrayDemo a = new ArrayDemo();
//a.Find();

//Practise p1 = new Practise();
//p1.Pra();


// MultiDimension Array 

//ArrayDemo m = new ArrayDemo();
//m.MultiDimension();


//ArrayDemo j = new ArrayDemo();
//j.JaggedArray();

//Task1 t = new Task1();
//t.Task();


//Task1 t2 = new Task1();
//t2.Task2();
//Console.WriteLine("Hello_World");

//Console.WriteLine("Enter the value of X");

//int x = Convert.ToInt32(Console.ReadLine());


//if (x % 2 == 0)
//{
//    Console.WriteLine("X is Divisible by 2");
//}

//else
//{
//    Console.WriteLine("X is not divisible by 2 ");
//}


//Console.WriteLine("Enter your Name :");
//String name = Console.ReadLine();
//Console.WriteLine(name);


//Console.WriteLine("Enter your marks/cgpa");
//Double score = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(score);

//if (score > 90)
//{
//    Console.WriteLine("First Class");
//}

//else
//{
//    Console.WriteLine("Not First Class");
//}



//int y;
//Console.WriteLine("Enter the value of y ");
//y = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i <= y; i++)
//{
//    Console.WriteLine(i);
//}


//// Boxing and Unboxing 

//int t = 100;
//Object o = t; // value type to refernece type it is called BOXING 
//int b = Convert.ToInt32(o); // reference type to value type it is called UNBOXING 



//// String VS StringBuilder 

//String s = "Hello";
//s = "Hello Everyone";
//Console.WriteLine(s);

//StringBuilder sb = new StringBuilder();
//sb.Append("Hello");
//sb.Append("Everyone this is Shiva");
//sb.Insert(1, "Hi");
//string s1 = sb.ToString();
//Console.WriteLine(s1);