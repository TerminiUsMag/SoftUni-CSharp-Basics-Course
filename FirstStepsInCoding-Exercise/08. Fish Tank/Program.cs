using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())/100;

            double volume = lenght * width * height;
            double litresVolume = volume * 0.001;

            double result = litresVolume * (1 - percent);
            Console.WriteLine(result);


        }
    }
}
