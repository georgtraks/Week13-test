using System;
using System.IO;

namespace createtitpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples\";
            Console.WriteLine("sisestage kausta nimi");
            string kasutajakaust = Console.ReadLine();
            
            string newdirectory = $@"{newPath}\{kasutajakaust}";

           
            bool directoryExists = Directory.Exists(newdirectory);

            if (directoryExists)
            {
                Console.WriteLine($"{kasutajakaust} already exists in samples");
            }
            else
            {
        
                Directory.CreateDirectory(newdirectory);
                Console.WriteLine($"directory {kasutajakaust} has been created");
            }
            Console.ReadLine();




        }
    }
}