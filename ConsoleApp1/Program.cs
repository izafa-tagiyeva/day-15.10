using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Notebook classi Product'dan miras alir. Name, Count, Price, RAM deyerleri daxil edilmeden, 
             * Notebook obyekti yaradila bilmez. Notebook obyekti yaradib Sale() methodunu işə salırsınız, .
             * Daha sonra ShowFullData() methodunu işə salıb, bütün dataları ekranda göstərirsiniz
              əgər məhsul stockda yoxdursa, "Məhsul yoxdur!" yazısını ekrana çıxarırsınız

              Product class:
               ==============
              string Name
               string Description
               int Count
               bool IsStock
              double Price
                  Sale() 
    
              Notebook class:
              ===============
               byte RAM 
               int Storage

               GetFullInfo()
                ShowFullData()*/



            Notebook myNotebook = new Notebook("Asus", "Gaming Laptop", 5, 1500.00, 16, 512);

            
            myNotebook.Sale();

           
            myNotebook.ShowFullData();

           


        }

       

public class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

       
        public Product(string name, string description, int count, double price)
        {
            if (count > 0 )
            {
                Name = name;
                Description = description;
                Count = count;
                Price = price;
                IsStock = true; 
            }
            else
            {
                
                IsStock = false; 
            }
        }

        
        public void Sale()
        {
            if (IsStock && Count > 0)
            {
                Count--; 
                if (Count == 0)
                {
                    IsStock = false; 
                }
            }
            else
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
        }

       
        public string GetFullInfo()
        {
            return $"Product: {Name}, Description: {Description}, Count: {Count}, Price: {Price}, In Stock: {IsStock}";
        }
    }

    public class Notebook : Product
    {
        public byte RAM;
        public int Storage;

       
        public Notebook(string name, string description, int count, double price, byte ram, int storage)
            : base(name, description, count, price)
        {
            
                RAM = ram;
                Storage = storage;
            
        }

        
        public void ShowFullData()
        {
            if (IsStock) 
            {
                Console.WriteLine($"Notebook Info: {GetFullInfo()}, RAM: {RAM}GB, Storage: {Storage}GB");
            }
            else
            {
                Console.WriteLine("Məhsul yoxdur!");
            }
        }

       
    }

    




}
}
