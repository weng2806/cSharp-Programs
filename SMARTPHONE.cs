using System;
/* Write a C# program to create a class called Smartphone with private instance variables brand, model, and storageCapacity.
Provide public getter and setter methods to access and modify these variables.
Add a method called increaseStorage() that takes an integer value and increases the storageCapacity by that value.
*/


namespace ConsoleApp
{
    class Smartphone
    {
        private string brand;
        private string model;
        private int storageCapacity;

        
        public string GetBrand()
        {
            return this.brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetModel()
        {
            return this.model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetStorageCapacity()
        {
            return this.storageCapacity;
        }

        public void SetStorageCapacity(int storageCapacity)
        {
            this.storageCapacity = storageCapacity;
        }

        public int IncreaseStorage(int integer)
        {
            this.storageCapacity += integer;
            return this.storageCapacity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Smartphone obj = new Smartphone();


            Console.WriteLine("Enter Smartphone Brand:");
            string brand = Console.ReadLine();
            obj.SetBrand(brand);

            Console.WriteLine("Enter Smartphone Model:");
            string model = Console.ReadLine();
            obj.SetModel(model);
            

            obj.SetStorageCapacity(32);
            Console.WriteLine("Enter Storage Capacity: \nCurrent Storage is: " + obj.GetStorageCapacity());
            int storageCapacity = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nSmartphone Details:");
            Console.WriteLine("Brand: " + obj.GetBrand());
            Console.WriteLine("Model: " + obj.GetModel());
            Console.WriteLine("Storage Capacity: " + obj.GetStorageCapacity() + "GB");

            Console.WriteLine("Updated Storage Capacity: " + obj.IncreaseStorage(storageCapacity) + "GB");
        }
    }
}
