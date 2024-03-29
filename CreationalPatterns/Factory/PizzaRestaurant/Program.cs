﻿namespace PizzaRestaurant
{
    using System;

    using Factory.Common;
    using PizzaRestaurant.Factories;
    using PizzaRestaurant.Models;

    public class Program
    {
        public static void Main()
        {
            var factories = new PizzaFactory[]
            {
                new CheesePizzaFactory(),
                new PepperoniPizzaFactory(),
                new HawaiPizzaFactory()
            };

            foreach (var factory in factories)
            {
                Pizza pizza = factory.CreatePizza();

                var factoryName = factory.GetType().Name;
                Console.WriteLine(PrintMessages.PizzaFactory, pizza.Description, factoryName);
            }
        }
    }
}
