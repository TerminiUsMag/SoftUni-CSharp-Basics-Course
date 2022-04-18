using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            double area = 0;
            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (type == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }
            else if (type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
            }
            Console.WriteLine(area);
        }
    }
}
