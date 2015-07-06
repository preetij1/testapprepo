using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecoratorPattern
{
    abstract class CondimentDecorator : Beverage
    {
        Beverage beverage;

        protected string desc = "";

        protected int cost;

        protected CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDesc()
        {
            return this.beverage.GetDesc() + desc;
        }
        public override int GetCost()
        {
            return this.beverage.GetCost() + cost;
        }

    }

    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage):base(beverage)
        {
            desc = "Plus Mocha ";
            cost = 3;
        }
    }

    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
            : base(beverage)
        {
            desc = "Plus Milk ";
            cost = 7;
        }
    }

    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
            : base(beverage)
        {
            desc = "Plus Whip ";
            cost = 9;
        }
    }
}
