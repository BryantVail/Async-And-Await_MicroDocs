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
            Console.WriteLine("toast is ready");

            var eggs = await eggsTask;
            Console.WriteLine("eggs are ready");

            var bacon = await baconTask;
            Console.WriteLine("Bacon is ready");

            var toast = await toastTask;
            Console.WriteLine("Toast is ready");


            Juice oj = Juice.PourOj();
            Console.WriteLine("oj is ready");

            //Done
            Console.WriteLine("Breakfast is ready!");
        }


    }
}
