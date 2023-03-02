using System;
using System.IO;

namespace FilesExample
{
    public class CreateFile
    {
        public static void Create()
        {
            string writeText = "Hello World!";
            File.WriteAllText("./files/filename.txt", writeText);

            string readText = File.ReadAllText("./files/filename.txt");
            Console.WriteLine(readText);
        }

        public static void checkFile()
        {
            // File.Exists("./files/Theory Innerrrr2.pdf");
            Boolean fileExists = File.Exists("./files/filename.txt");
            if (fileExists)
            {
                Console.WriteLine("The file exists");
                File.Delete("./files/filename.txt");
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }

        public static void stringFunc()
        {
            string name = "Ikenna Remigius Ezeanyaeji";
            string newName = name.Replace(" ", "_").ToLower();
            Console.WriteLine(newName);
        }
    }
}
