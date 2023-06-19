using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Linq;

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
                new Car { Id = 1, Name = "BMW ", Price = 120000 },
                new Car { Id = 2, Name = "MERS ", Price = 125000 }
                }
            };
                SaveObjectToFile(company);
        }

        static void SaveObjectToFile(Company company)
        {
            string path = Directory.GetCurrentDirectory();
            path += "\\obj.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Close();

                string json = JsonSerializer.Serialize(company);
                Console.WriteLine(json);
                File.WriteAllText(path, json);
            }
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
