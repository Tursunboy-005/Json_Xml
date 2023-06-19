﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.

namespace Json_Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company
            {
                Id = 1,
                Name = "Pdp academy",
                Cars = new List<Car> {
                new Car { Id = 1, Name = "Model X", Price = 120000 },
                new Car { Id = 2, Name = "Model Y", Price = 125000 }
                }
            };

            foreach (var car in company.Cars)
            {
                Console.WriteLine(car.Name);
            }

           // string json = 

            Console.ReadLine();
        }
    }

    class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Car> Cars { get; set; }
        
    }
    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
}
