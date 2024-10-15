using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /* 3 class-nız olur. Vehicle, Car, Motorcycle. Car və Motorcycle Vehicle-dan miras alır.

             Vehicle class:
            ==============
             string Brand 
             string Model 
             double Mile 

             Car class: Vehicle
             int DoorsNum 
             ShowFullInfo()

             MotorCycle class: Vehicle
             int WheelNum 
             ShowFullInfo()
             Brand ve Model teyin edilmeden, Car ve Bicycle obyekti yaratmaq olmasin.*/



            Car myCar = new Car("Toyota", "Corolla", 15000, 4);
            myCar.ShowFullInfo();

            Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Iron 883", 5000, 2);
            myMotorcycle.ShowFullInfo();
        }

       

public class Vehicle
    {
            public string Brand;
            public string Model;
            public double Mile;

        
        public Vehicle(string brand, string model, double mile)
        {
          
            Brand = brand;
            Model = model;
            Mile = mile;
        }
    }

    public class Car : Vehicle
    {
            public int DoorsNum;

        
        public Car(string brand, string model, double mile, int doorsNum)
            : base(brand, model, mile)
        {
            DoorsNum = doorsNum;
        }

       
        public void ShowFullInfo()
        {
            Console.WriteLine($"Car Info: Brand: {Brand}, Model: {Model}, Mile: {Mile}, Doors: {DoorsNum}");
        }
    }

    public class Motorcycle : Vehicle
    {
            public int WheelNum;

        
        public Motorcycle(string brand, string model, double mile, int wheelNum)
            : base(brand, model, mile)
        {
            WheelNum = wheelNum;
        }

        
        public void ShowFullInfo()
        {
            Console.WriteLine($"Motorcycle Info: Brand: {Brand}, Model: {Model}, Mile: {Mile}, Wheels: {WheelNum}");
        }
    }

}
}
