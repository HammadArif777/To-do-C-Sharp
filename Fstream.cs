// using System;
// using System.IO;
// using static System.Console;
// namespace Fstream
// {
//     class MainClass 
//     {
//         public static void Main(){
//             // Using Streams
//             // FileStream fout = null;
//             // try {
//             //      fout = new FileStream("test.txt", FileMode.Create,FileAccess.Write);
//             //      string message = "\"You are not brave, men are brave.\" - The Dark Knight";
//             //     foreach (char item in message)
//             //     {
//             //             fout.WriteByte((byte)item);
//             //     }
//             // }
//             // catch(Exception ex){
//             //     Console.WriteLine(ex.Message);
//             // }
//             // finally {
//             //     fout.Close();
//             // }
//             // FileStream fin = null;
//             // try {
//             //     fin = new FileStream("test.txt", FileMode.Open,FileAccess.Read);
//             //     int i = fin.ReadByte();
//             //     WriteLine(
//             //         format : "{0}, {1}",
//             //         arg0: i,
//             //         arg1 : (char)i
//             //     );
//             // }
//             // catch(Exception ex){
//             //     Console.WriteLine(ex.Message);
//             // }
//             // finally {
//             //     fin.Close();
//             // }

//     // Using Stream writer
        
//         // StreamWriter sw = new StreamWriter(
//         //     new FileStream(
//         //         "test_1.txt",
//         //         FileMode.Create,
//         //         FileAccess.Write
//         //     )
//         // );
//         // string data = "Hello, from Fstream.cs file.";
//         // sw.Write(data);
//         // sw.Close();
//         // StreamReader
//     StreamReader sr = null;
//         try {
//             sr = new StreamReader(
//                 new FileStream(
//                     "test_1.txt",
//                     FileMode.Open,
//                     FileAccess.Read
//                 )
//             );
//             string line = String.Empty;
//                 while((line = sr.ReadLine()) != null)
//                 {
//                     Console.WriteLine(line);
//                 }
            
//         }
//     catch(Exception ex){Console.WriteLine(ex.Message);  }
//     finally{
//         sr.Close();
//     }
//         }
//     }
// }