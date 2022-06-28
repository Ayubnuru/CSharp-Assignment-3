using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double Calculateperimeter();


    }
    class Circle : Shape
    {
        public double radius { get; set; }
        static readonly double pi = 3.14;
        public override double CalculateArea()
        {
            return radius * radius* pi;
        }

        public override double Calculateperimeter()
        {
            return 2 * radius * pi;
        }
    }
    class Square : Shape
    {
        public double length { get; set; }

        public override double CalculateArea()
        {
        


            return length * length;
        }

        public override double Calculateperimeter()
        {
            return length * 4;
        }

        
 class Main{
    public static void main(String[] args){
        
Circle c = new Circle { radius = 4 };
Console.WriteLine( c.Calculateperimeter());
Console.WriteLine( c.CalculateArea());  
Console.WriteLine( c.CalculateArea());  
        }
}
}



