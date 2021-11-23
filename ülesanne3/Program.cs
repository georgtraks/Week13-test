using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ToyotaData = @"C:\Users\opilane\samples\cars\toyota.txt";
            string BMWData = @"C:\Users\opilane\samples\cars\bmw.txt";
            string CarsData = @"C:\Users\opilane\samples\cars\cars.txt";
            string teslaData = @"C:\Users\opilane\samples\cars\tesla.txt";


            List<string> toyota = new List<string>();
            List<string> bmw = new List<string>();
            List<string> tesla = new List<string>();

            string[] sourceData = File.ReadAllLines(CarsData);

            foreach (string element in sourceData)
            {
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);

                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);

                }
                if (element.Contains("tesla"))
                {
                    tesla.Add(element);

                }

                File.WriteAllLines(ToyotaData, toyota);
                File.WriteAllLines(BMWData, bmw);
                File.WriteAllLines(teslaData, tesla);

            }




        }



    }
}