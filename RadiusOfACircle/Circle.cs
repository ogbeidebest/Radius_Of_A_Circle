using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusOfACircle
{
     class Circle
    {
        const double pi = 3.14159;
        double radius;
        

        public void AcceptRadius()
        {
            Console.Write("Enter the radius of the circle: ");
             radius = double.Parse(Console.ReadLine());
            
        }
        public double GetArea()
        {
            return pi * radius * radius;
        }
        public void ShowResult()
        {
            Console.WriteLine("The radius of the circle is : {0}", radius);
            Console.WriteLine($"Area: {GetArea():2F}");
        }
    }
}
 