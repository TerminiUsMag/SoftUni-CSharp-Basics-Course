using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            //За услуга тип "standard", срокът за доставка е 3 работни дни и фирмата калкулира цените при следните
            //условия:
            // За пратки по - леки от 1 кг – 3 стотинки на километър.
            // От 1 кг до 10 кг – 5 стотинки на километър.
            // От 10 кг вкл. до 40 кг – 10 стотинки на километър.
            // От 40 кг вкл. до 90 кг – 15 стотинки на километър.
            // От 90 кг вкл. до 150 кг – 20 стотинки на километър.
            //За услуга тип "express", фирмата извършва услугата в рамките на 24 часа, като начислява надценка за всеки
            //километър както следва:
            // За пратки по - леки от 1 кг – на килограм по 80 % от съответната цена на километър
            // От 1 кг до 10 кг – на килограм по 40 % от съответната цена на километър
            // От 10 кг вкл. до 40 кг – на килограм по 5 % от съответната цена на километър
            // От 40 кг вкл. до 90 кг – на килограм по 2 % от съответната цена на километър
            // От 90 кг вкл. до 150 кг – на килограм по 1 % от съответната цена на километър

            double weight = double.Parse(Console.ReadLine());
            string typeOfService = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double pricePerKilo = 0, resultStandard, overPricePerKG, overPricePercent = 0, overPriceForWeight, resultExpress = 0, result;

            if (weight < 1) pricePerKilo = 0.03;
            else if (weight >= 1 && weight < 10) pricePerKilo = 0.05;
            else if (weight >= 10 && weight < 40) pricePerKilo = 0.1;
            else if (weight >= 40 && weight < 90) pricePerKilo = 0.15;
            else if (weight >= 90 && weight < 150) pricePerKilo = 0.2;
            resultStandard = distance * pricePerKilo;

            if (typeOfService == "express")
            {
                if (weight < 1) overPricePercent = 80;
                else if (weight >= 1 && weight < 10) overPricePercent = 40;
                else if (weight >= 10 && weight < 40) overPricePercent = 5;
                else if (weight >= 40 && weight < 90) overPricePercent = 2;
                else if (weight >= 90 && weight < 150) overPricePercent = 1;

                overPricePerKG = (overPricePercent * pricePerKilo) / 100;
                overPriceForWeight = weight * overPricePerKG;
                resultExpress = distance * overPriceForWeight;
            }
            result = resultStandard + resultExpress;

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {result:f2} lv.");
        }
    }
}
