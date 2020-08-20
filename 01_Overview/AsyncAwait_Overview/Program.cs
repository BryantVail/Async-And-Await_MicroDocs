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

            Task<Egg> eggsTask = Egg.FryEggsAsync(2);
            

            Task<Bacon> baconTask = Bacon.FryBaconAsync(3);
            
            // Receive Task for Toast
            // await Toast Task
            Task<Toast> toastTask = Toast.ToastBreadAsync(2);
            Toast toast = await toastTask; // perform 'ToastBreadAsync(2)' task
            toast
                .ApplyButter()
                .ApplyJam();

            Console.WriteLine("toast is ready");


            Juice oj = Juice.PourOj();
            Console.WriteLine("oj is ready");


            // Collect Tasks
            Egg eggs = await eggsTask;
            Console.WriteLine("Eggs are ready");

            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon is ready");



            //Done
            Console.WriteLine("Breakfast is ready!");
        }


    }
}
