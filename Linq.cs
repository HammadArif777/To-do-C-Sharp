// using System ;
// using System.Collections.Generic;
// using System.Linq;
// namespace Container_02

// {
//     class Employee { 
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public decimal Salary { get; set; }
//         public string Designation { get; set; }
//         public Employee()
//         {
//             Random rnd = new Random();
//             this.Id = rnd.Next(0,100);
//         }
//     }
//     public delegate string MyDelegate(string message);
    
//     class MainClass 
//     {
//         public static string Greeting(string msg){
//             return $"Hello {msg}, How are you?";
//         }
//         public static void Main(string [] args){

                
//                 MyDelegate deg = new MyDelegate(MainClass.Greeting);
//                 Console.WriteLine(deg("Hammad"));
//                 List <Employee> records = new List<Employee>{
//                 new Employee{ Name = "Captain America", Designation = "FOUNDER, AND CEO", Salary = 2_000_000M},
//                 new Employee{ Name = "Dr.Strange", Designation = "CTO", Salary = 1_750_000M},
//                 new Employee{ Name = "Thor", Designation = "MD", Salary = 1_500_000M},
//                 new Employee{ Name = "Iron Man", Designation = "COO", Salary = 1_000_000M},
//                 new Employee{ Name = "Black Widow", Designation = "CFO", Salary = 2_000_000M},
//                 new Employee{ Name = "Spider Man", Designation = "INTERN", Salary = 20_000M},
//             };
//             // foreach(var item in records){
//             //             Console.WriteLine($"Id:{item.Id}, Name:{item.Name},  Designation:{item.Designation}, Salary:{item.Salary}");
//             // }
//             var newRecord = records.Where(s => s.Name.Equals("Spider Man")).ToList();
//             // Console.WriteLine(newRecord.ToList().GetType());
//             foreach (var item in newRecord)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
