// using System;
// using System.Collections.Generic;
// using System.Text.Json;
// using System.Web;
// namespace Container_02
// {
//     class Student {
//         public int Id { get; set;}
//         public double Salary { get; set;}
//         public required string Department { get; set;}
//     }
//     class MainClass 
//     {
//         public static void Main(string [] args){

//             List<Student> records = new List<Student>()
//             {
//             new Student(){Id = 1, Salary = 25_000, Department = "IT" },
//             new Student(){Id = 2, Salary = 35_000, Department = "MKT" },
//             new Student(){Id = 3, Salary = 55_000, Department = "IT" },
//             };
//             // var jsonFormatter = new JsonSerializerOptions() { WriteIndented = true};
//             var student = new Student() { Id = 1, Salary = 25000, Department = "IT" };
//             var json = JsonSerializer.Serialize(student);
//             Console.WriteLine(
//                 format :"Id:{0}, Salary:{1:C}, Dep:{2}",arg0 : student.Id,arg1: student.Salary,arg2 : student.Department);
//             var obj = JsonSerializer.Deserialize<Student>(json);
//             Console.WriteLine($"Id:{obj.Id} Salary:{obj.Salary:C} Department:{obj.Department}");
//             // ConsoleKeyInfo key = Console.ReadKey();
//             // Console.WriteLine();
//             // Console.WriteLine(
//             //     format :"Key:{0}, Char:{1:C}, Modifier:{2}",
//             //     arg0 : key.Key,
//             //     arg1: key.KeyChar,
//             //     arg2 : key.Modifiers
//             // );
//             //  var operation = 2;
//             //  var result = operation switch
//             //  { 1 => "case 1", 2 => "case 2", _ => "No case available" };
//             // dynamic value = "string";

//         }

//     }
//     // class MainClass 
//     // {
//     //     public static async Task<int> LongProcess1(){

//     //         Console.WriteLine("Process 1 started.");
//     //         await Task.Delay(10000);
//     //         return 1;
//     //     }
//     //     public static async Task<int> LongProcess2(){
//     //         Console.WriteLine("Process 2 started.");
//     //         await Task.Delay(10000);
//     //         return 2;
//     //     }
//     //     public static void Print(int val) { 
//     //         Console.WriteLine($"Long Process values:{val}");
//     //     }
//     //     public static void Message(){
//     //         Console.WriteLine("Hello, World");
//     //     }
//     //     public static async Task Main(){

//     //         Task<int> process_1 = LongProcess1();
//     //         Console.WriteLine("Loading...");
//     //         int val_1 = await process_1;
//     //         Message();
//     //         Console.WriteLine(val_1);
//     //         Task<int> process_2 = LongProcess2();
//     //         int val_2 = await process_2;
//     //         Console.WriteLine(val_2);
//     //     }
//     // }
// }