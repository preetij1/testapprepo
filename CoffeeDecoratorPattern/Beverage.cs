using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecoratorPattern
{
    abstract class Beverage
    {

        public abstract string GetDesc();
        
        public abstract int GetCost();
    }

    class Espresso : Beverage
    {      

        public override int GetCost()
        {
            return 9;
        }

        public override string GetDesc()
        {
            return "Espresso ";
        }
    }
    class Latte : Beverage
    {
        public override string GetDesc()
        {
            return "Latte ";
        }

        public override int GetCost()
        {
            return 11;
        }
    }
}
