using System;
using System.Threading.Tasks;


namespace Breakfast.Domain.Entities
{
    public class Juice
    {

        public static Juice PourOj()
        {
            Console.WriteLine("Pouring orange Juice");
            return new Juice();
        }

    }
}