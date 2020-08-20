using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast.Domain.Entities
{
    public class Coffee
    {

        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring Coffee");
            return new Coffee();
        }

    }
}
