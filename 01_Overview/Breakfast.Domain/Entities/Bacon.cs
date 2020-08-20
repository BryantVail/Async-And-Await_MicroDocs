using System;
using System.Threading;
using System.Threading.Tasks;




namespace Breakfast.Domain.Entities
{
    public class Bacon
    {

        public async static  Task<Bacon> FryBaconAsync(int numberOfBaconSlices)
        {

            Console.WriteLine($"Putting {numberOfBaconSlices} slices of bacon in the pan");
            Console.WriteLine("Cooking first side of bacon");

            var baconInstance = await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                Task.Delay(3000);

                for (int i = 0; i < numberOfBaconSlices; i++)
                {
                    Console.WriteLine("flipping a slice of bacon");
                }

                Console.WriteLine("Cooking the second side of bacon");

                Task.Delay(3000).GetAwaiter().GetResult();

                return new Bacon();
            });

            Console.WriteLine("Put Bacon on Plate");

            return baconInstance;
        }


    }
}