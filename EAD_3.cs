// using System ;
// namespace EAD_3
// {
//     class MainClass
//     {
//         public static void Main(string [] args){

//             object name_1 = "Muhammad Hammad";
//             int lengthOfName_1 = ((string)name_1).Length;
//             string name_2 = "IT";
//             int lengthOfName_2 = name_2.Length;
//             Console.WriteLine($"{lengthOfName_1}, {lengthOfName_2}");
//             dynamic variable = "Dynamic variable";
//             Console.WriteLine(variable);
//             var a = "10"; // Data-Type check on compile-time.
//             Console.WriteLine(a);
//             // Default values 
//             int defaultValue = default(int);
//             Console.WriteLine($"Default value of int- {defaultValue}");
//             // Arrays
//             int[] numbers;
//             numbers = new int[5];
//             //  Formating Output
//             // Formatting output using interpolated strings
//             // using numbered positional arguments
//             string firstName = "Muhammad";
//             string lastName = "Hammad";
//             Console.WriteLine($"First Name:{firstName} Last Name:{lastName}");
//             string formattedString = string.Format(
//                 format:"{0} , {1}",
//                 arg0 : firstName,
//                 arg1 : lastName
//             );
//             Console.WriteLine(formattedString);
//             // Read Key
//             // ConsoleKeyInfo key = Console.ReadKey();
//             // string formatOfKey = string.Format(
//             //     format : "Key:{0}, Char:{1}, Modifier:{2}",
//             //     arg0 : key.Key,
//             //     arg1: key.KeyChar,
//             //     arg2: key.Modifiers
//             // );
//             // Console.WriteLine(formatOfKey);
//             // Another style to format data
//             int salary_1 = 12000;
//             int salary_2 = 202000;
//             Console.WriteLine(
//                 format : "{0:NO} ,{1:NO}",
//                 arg0 : salary_1,
//                 arg1 : salary_2
//             );

//             // In switch statements, we can also use goto case 1;
//             // pattern matching using switch statements

//             int number = 100;
//             if(number is int y ){
//                 Console.WriteLine($"value of y: {y}");
//             }
//         //     var operation = 2;
//         //     var result = operation switch
//         //     { 1 => "case 1", 2 => "case 2", _ => "No case available" };
//         // Console.WriteLine(result);
//         // Type Casting in C# 
//         // Implicit smaller to larger data save
        
//         }
//     }
// }