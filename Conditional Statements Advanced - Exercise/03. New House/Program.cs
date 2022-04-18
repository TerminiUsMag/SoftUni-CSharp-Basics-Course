using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]

            string typeFlowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            const double PRICE_ROSES = 5;
            const double PRICE_DAHLIAS = 3.8;
            const double PRICE_TULIPS = 2.8;
            const double PRICE_NARCISSUS = 3;
            const double PRICE_GLADIOLUS = 2.5;

            switch (typeFlowers)
            {
                case "Roses":
                    price = numFlowers * PRICE_ROSES;
                    if (numFlowers > 80)
                    {
                        discount = 0.1;
                        price -= price * discount;
                    }
                    break;
                case "Dahlias":
                    price = numFlowers * PRICE_DAHLIAS;
                    if (numFlowers > 90)
                    {
                        discount = 0.15;
                        price -= price * discount;
                    }
                    break;
                case "Tulips":
                    price = numFlowers * PRICE_TULIPS;
                    if (numFlowers > 80)
                    {
                        discount = 0.15;
                        price -= price * discount;
                    }
                    break;
                case "Narcissus":
                    price = numFlowers * PRICE_NARCISSUS;
                    if (numFlowers < 120)
                    {
                        discount = 0.15;
                        price += price * discount;
                    }
                    break;
                case "Gladiolus":
                    price = numFlowers * PRICE_GLADIOLUS;
                    if (numFlowers < 80)
                    {
                        discount = 0.2;
                        price += price * discount;
                    }
                    break;
                default:
                    break;
            }
            if(budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {typeFlowers} and {budget-price:f2} leva left.");
            }

        }
    }
}
