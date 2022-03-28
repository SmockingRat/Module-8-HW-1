using System;
using System.IO;

namespace Module_8_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to directory");
            string path = Convert.ToString(Console.ReadLine());
            
            DeleteTheDir.DeleteDir(path);

            Console.ReadKey();
        }


        class DeleteTheDir
        {
            public static void DeleteDir(string path)
            {
                try
                {
                    DirectoryInfo dr = new DirectoryInfo(path);
                    double CompareTime = (DateTime.Now - dr.LastAccessTime).TotalMinutes;

                    if (dr.Exists)
                    {
                        dr.Delete(true);
                        Console.WriteLine("Success");
                    }
                    else
                    {
                        Console.WriteLine("User, directory does not exist!");
                    }
                }
                catch(Exception message)
                {
                    Console.WriteLine(message);
                }
            }


        }


    }
}
