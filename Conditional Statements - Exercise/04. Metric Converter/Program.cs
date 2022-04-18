using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numToConvert = double.Parse(Console.ReadLine());
            string numType = Console.ReadLine();
            string numTypeToConvert = Console.ReadLine();
            double convertedNum = 0;

            if(numType == "m")
            {
                if (numTypeToConvert == "mm")
                    convertedNum = numToConvert * 1000;
                else if (numTypeToConvert == "cm")
                    convertedNum = numToConvert * 100;
            }
            else if (numType == "cm")
            {
                if (numTypeToConvert == "mm")
                    convertedNum = numToConvert * 10;
                else if (numTypeToConvert == "m")
                        convertedNum = numToConvert / 100;
            }
            else if (numType == "mm")
            {
                if (numTypeToConvert == "cm")
                    convertedNum = numToConvert / 10;
                else if (numTypeToConvert == "m")
                    convertedNum = numToConvert / 1000;
            }

            Console.WriteLine($"{convertedNum:F3}");

        }
    }
}
