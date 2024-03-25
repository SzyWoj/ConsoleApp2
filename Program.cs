using System;
using System.Drawing;

namespace objects
{
    public class Car
    {
        public string name;
        public string brand;
        public string color;
        public int maxSpeed;
    }

    public class Volvo : Car
    {
       public int yearOfProduction = 2023;
    }

    public class Mercerdes : Car
    {
       public int yearOfProduction = 2019;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Car
            Car car = new Car();

            // Create an instance of Volvo
            Volvo volvo = new Volvo();

            //Create an instance of Mercedes
            Mercerdes mercedes = new Mercerdes();

            // Assign values to properties of Volvo
            volvo.name = "XC90";
            volvo.brand = "Volvo";
            volvo.color = "Black";
            volvo.maxSpeed = 180;
            

            mercedes.name = "C-class";
            mercedes.brand = "Mercedes";
            mercedes.color = "Silver";
            mercedes.maxSpeed = 220;
            

            // Access properties of Volvo
            Console.WriteLine("Name: " + volvo.name);
            Console.WriteLine("Brand: " + volvo.brand);
            Console.WriteLine("Color: " + volvo.color);
            Console.WriteLine("Max Speed: " + volvo.maxSpeed);
            Console.WriteLine("Year of Production " + volvo.yearOfProduction);


            //Access properties of Mercedes
            Console.WriteLine("Name: " + mercedes.name);
            Console.WriteLine("Brand: " + mercedes.brand);
            Console.WriteLine("Color: " + mercedes.color);
            Console.WriteLine("Max Speed: " + mercedes.maxSpeed);
            Console.WriteLine("Year of Production: " + mercedes.yearOfProduction);
        }
    }
}
