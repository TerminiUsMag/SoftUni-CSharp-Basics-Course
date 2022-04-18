using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudioPerNight = 0;
            double priceApartmentPerNight = 0;
            double discount = 0;
            double discountApartment = 0;
            double priceForNightsInApartment = 0;
            double priceForNightsInStudio = 0;
            double priceForNightsInStudioWithDiscount = 0;
            double priceForNightsInApartmentWithDiscount = 0;

            //Май и октомври Юни и септември Юли и август
            //Студио – 50 лв./ нощувка Студио – 75.20 лв./ нощувка  Студио – 76 лв./ нощувка
            //Апартамент – 65 лв./ нощувка Апартамент – 68.70 лв./ нощувка  Апартамент – 77 лв./ нощувка
            //Предлагат се и следните отстъпки:
            //•	За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            //•	На първия ред е месецът – May, June, July, August, September или October

            switch (month)
            {
                case "May":
                case "October":
                    priceApartmentPerNight = 65;
                    priceStudioPerNight = 50;
                    if (nights > 7 && nights <= 14)
                    {
                        discount = 0.05;
                    }
                    else if (nights > 14)
                    {
                        discount = 0.3;
                    }
                    break;
                case "June":
                case "September":
                    priceApartmentPerNight = 68.70;
                    priceStudioPerNight = 75.20;
                    if (nights > 14)
                    {
                        discount = 0.2;
                    }
                    break;
                case "July":
                case "August":
                    priceStudioPerNight = 76;
                    priceApartmentPerNight = 77;
                    break;
            }
            if (nights > 14)
            {
                discountApartment = 0.1;
            }
            priceForNightsInApartment = nights * priceApartmentPerNight;
            priceForNightsInStudio = nights * priceStudioPerNight;

            priceForNightsInApartmentWithDiscount = priceForNightsInApartment - (priceForNightsInApartment * discountApartment);
            priceForNightsInStudioWithDiscount = priceForNightsInStudio - (priceForNightsInStudio * discount);

            Console.WriteLine($"Apartment: { priceForNightsInApartmentWithDiscount:f2} lv.");
            Console.WriteLine($"Studio: { priceForNightsInStudioWithDiscount:f2} lv.");

        }
    }
}
