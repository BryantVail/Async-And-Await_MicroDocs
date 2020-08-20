using System;
using System.Threading.Tasks;
// user defined
using Breakfast.Domain.Entities;

namespace AsyncAwait_Overview
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee cup = Coffee.PourCoffee();
            Console.WriteLine("Coffee is ready");

            var eggsTask = Egg.FryEggsAsync(2);
            var baconTask = Bacon.FryBaconAsync(3);
            var toastTask = Toast.MakeToastWithButterAndJamAsync(2);

            Task.WhenAll(eggsTask, baconTask, toastTask);
            
            Console.WriteLine("eggs are ready");
            Console.WriteLine("Bacon is ready");
            Console.WriteLine("Toast is ready");

            Juice oj = Juice.PourOj();
            Console.WriteLine("oj is ready");

            //Done
            Console.WriteLine("Breakfast is ready!");
        }


    }
}
