// * STATIC KEYWORD
// using System;
// namespace Container
// {
//     class StaticClass
//     {
//         public static int x = 0;
//         public static void Count (){
//             x+= 10;
//         }
//         static StaticClass()
//         {
//             x = 10;
//             Console.WriteLine("I am static constructor.");
//         }
//         public StaticClass()
//         {
//             Console.WriteLine("I am simple constructor.");
//         }
//     }
//     class Program
//     {
//         public static void Message(string name){
//             Console.WriteLine($"Hi {name}.");
//         }
//         public static void Main(string [] args)
//     {
//         // Func<string, string, string> FullName = (firstName, lastName) => $"{firstName} {lastName}";
//             // Func<int,int,int> GetSum = delegate (int a, int b)
//             {
//                 // return a + b;
//             };
//             // Message("Hammad");
//             // string myName = FullName("Muhammad ","Hammad");
//             // // Console.WriteLine(myName);
//             // // Console.WriteLine(GetSum(2,3));
//             // Console.WriteLine(StaticClass.x);
//             // var objA = new StaticClass();
//             // Console.WriteLine(StaticClass.x);
//     }
//     }
// }
// * MEMORY SHARING 
// using System;
// namespace Container
// {
//     class StaticClassExample
//     {
//         public static int x = 0;
//         public StaticClassExample()
//         {
//             x += 10;
//         }

//     }
//     class Driver
//     {
//         public static void Main(string[] args)
//         {
//             int value = StaticClassExample.x;
//             var obj = new StaticClassExample();
//             int value2 = StaticClassExample.x;
//             if (value == value2)
//             {
//                 Console.WriteLine("true");
//             }
//             else
//             {
//                 Console.WriteLine($"false {value} != {value2}");

//             }

//         }

//     }
// }

// using System;

// public class LimitedInstanceClass
// {
//     // Static counter to keep track of instances
//     private static int instanceCount = 0;

//     // Maximum allowed instances
//     private const int maxInstances = 10;

//     // Private constructor to prevent direct instantiation
//     private LimitedInstanceClass()
//     {
//         instanceCount++;
//     }

//     // Public static method to create an instance
//     public static LimitedInstanceClass CreateInstance()
//     {
//         if (instanceCount < maxInstances)
//         {
//             return new LimitedInstanceClass();
//         }
//         else
//         {
//             throw new InvalidOperationException("Maximum number of instances reached.");
//         }
//     }

//     // Optionally, a destructor to decrease the count when an instance is destroyed
//     ~LimitedInstanceClass()
//     {
//         instanceCount--;
//     }
// }

// // Usage example
// public class Program
// {
//     public static void Main()
//     {
//         try
//         {
//             for (int i = 0; i < 12; i++) // Attempt to create 12 instances
//             {
//                 LimitedInstanceClass obj = LimitedInstanceClass.CreateInstance();
//                 Console.WriteLine($"Instance {i+1} created.");
//             }
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// using System;
// namespace Container 
// {
//     class Driver 
//     {
//         public static void Main(string [] args){

//             List<Program> bucket = new List<Program>();
//             for(int i = 0; i < 10; i++)
//             {
//                 Program obj = Program.CreateInstance();
//                 bucket.Add(obj);
//             }

//             foreach (var item in bucket)
//             {
//                 Console.WriteLine(item);
//             }
//             Program obj = Program.CreateInstance();            
//         }
//     }
//     class Program 
//     {
//         public static int count = 0;
//         public static int maxLimit = 10;

//         private Program() 
//         {
//             count++;
//         }
//         public static Program CreateInstance()
//         {

//                 if(count < maxLimit)
//                 {
//                     return new Program();   
//                 }
//                 else {
//                     throw new OutOfMemoryException();
//                 }


//         }
//     }
// }

// using System;
// namespace Container
// {
//     class Student 
//     {
//         public static int id;
//         public static string name = string.Empty;
//         public static string major = string.Empty;
//         private Student (int Id , string Name, string Major) 
//         {
//             id = Id;
//             name = Name;
//             major = Major;
//         }
//         public static Student GetInstance(int id, string major,string name )
//         {
//             return new Student(id,major,name);
//         }
//         public int GetId()
//         {
//             return id;
//         }
//         public string GetMajor()
//         {
//             return major;
//         }
//         public string GetName()
//         {
//             return name;
//         }

//     }
//     class Driver 
//     {
//         public static void Main (string []args)
//         {
//         Student obj = Student.GetInstance(1,"Muhammad Hammad","IT");



//         }
//     }

// }


// using System;
// namespace Container
// {
//     class NegativeValueException:Exception{

//         public readonly string message;
//             public NegativeValueException()
//             {
//             message = "Attempted to set negative value.";   
//             }
//     }
//     class Driver 
//     {

//             public static void Main(string [] args)
//             {
//             int value = -1;
//                 try 
//                 {
//                 if (value < 0)
//                     throw new NegativeValueException();
//                 }
//                 catch(NegativeValueException e)
//                 {
//                 Console.WriteLine(e.message);
//                 }
//             }
//     }
// }