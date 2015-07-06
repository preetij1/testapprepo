using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            
            Console.WriteLine(beverage.GetDesc());

            Console.WriteLine(beverage.GetCost());

            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.GetDesc());

            Console.WriteLine(beverage.GetCost());

            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.GetDesc());

            Console.WriteLine(beverage.GetCost());

            beverage = new Milk(beverage);

            Console.WriteLine(beverage.GetDesc());

            Console.WriteLine(beverage.GetCost());

            beverage = new Whip(beverage);

            Console.WriteLine(beverage.GetDesc());

            Console.WriteLine(beverage.GetCost());

            Console.ReadKey();
        }
    }
}
