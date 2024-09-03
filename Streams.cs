// using System;
// using System.IO;
// using  static System.Console;
// namespace Streams
// {
//     class MainClass 
//     {
//         public static void Main(string [] args)
//         {
//             WriteLine(Directory.GetCurrentDirectory());           
//             WriteLine(Path.PathSeparator);           
//             WriteLine(Path.GetTempPath());           
//             WriteLine(Environment.OSVersion);           
//             WriteLine(Environment.ProcessorCount);           
//             WriteLine(Environment.CurrentDirectory.GetType());
//             //  Local drives information

//             var drives = DriveInfo.GetDrives();
//             foreach (var item in drives)
//             {
//                     if(item.IsReady){
//                         WriteLine($"Name:{item.Name} Type:{item.DriveType} Size:{item.TotalSize / 1000000000}GB Format:{item.DriveFormat} Free_Space:{item.AvailableFreeSpace/ 1000000000}GB ");
//                     }
//                     else {
//                         WriteLine($"Name:{item.Name} Type:{item.DriveType}");
//                     }
//             }
//             // How to create a new folder or directory

//             var newFolder = Path.Combine(Directory.GetCurrentDirectory(),"My_New_Folder");
//             if(Directory.Exists(newFolder))
//             {
//                 Console.WriteLine("Already Created!");
//             Directory.Delete(newFolder,recursive:true);
//             }
//             else {
//                 Directory.CreateDirectory(newFolder);
//             }
//         }
//     }
// }