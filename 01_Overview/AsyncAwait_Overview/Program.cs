using System;
using System.Collections.Generic;
using System.Threading.Tasks;
// user defined
using Breakfast.Domain.Entities;

namespace AsyncAwait_Overview
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            Coffee cup = Coffee.PourCoffee();
            Console.WriteLine("Coffee is ready");

            var eggsTask = Egg.FryEggsAsync(2);
            var baconTask = Bacon.FryBaconAsync(3);
            var toastTask = Toast.MakeToastWithButterAndJamAsync(2);

            var breakfastTasks 
                = new List<Task> { eggsTask, baconTask, toastTask };

            while(breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);

                if(finishedTask == eggsTask)
                {
                    Console.WriteLine("Eggs are ready");
                }else if(finishedTask == baconTask){
                    Console.WriteLine("Bacon is ready");
                }else if(finishedTask == toastTask)
                {
                    Console.WriteLine("Toast is ready");
                }

                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = Juice.PourOj();
            Console.WriteLine("oj is ready");

            //Done
            Console.WriteLine("Breakfast is ready!");

            timer.Stop();
            Console.WriteLine($"Time passed: {timer.ElapsedMilliseconds} milliseconds");

            Console.ReadLine();
        }


    }
}
