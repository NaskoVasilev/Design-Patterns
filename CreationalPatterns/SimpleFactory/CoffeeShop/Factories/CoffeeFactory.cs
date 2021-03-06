﻿namespace CoffeeShop.Factories
{
    using System;

    using CoffeeShop.Enums;
    using CoffeeShop.Models;

    /// <summary>
    /// The 'SimpleFactory' class
    /// </summary>
    public static class CoffeeFactory
    {
        public static Coffee GetCoffee(CoffeeType coffeType)
        {
            switch (coffeType)
            {
                case CoffeeType.Regular:
                    return new RegularCoffee();

                case CoffeeType.Double:
                    return new DoubleCoffee();

                case CoffeeType.Cappuccino:
                    return new Cappuccino();

                case CoffeeType.Macchiato:
                    return new Macchiato();

                default:
                    throw new ArgumentException();
            }
        }
    }
}
