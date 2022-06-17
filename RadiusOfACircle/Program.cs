using System;

namespace RadiusOfACircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle oneCircle = new Circle();
            oneCircle.AcceptRadius();
            oneCircle.GetArea();
            oneCircle.ShowResult();
            Console.ReadKey();
        }
    }
}
