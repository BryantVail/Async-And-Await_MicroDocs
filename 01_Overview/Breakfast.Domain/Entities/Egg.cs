using System;
using System.Threading;
using System.Threading.Tasks;



namespace Breakfast.Domain.Entities
{
    public class Egg
    {

        public async static Task<Egg> FryEggsAsync(int numberOfEggs)
        {
            Console.WriteLine($"Entered 'FryEggsAsync':\n" +
                $" {Thread.CurrentThread.ManagedThreadId}");


            var eggTask = await Task.Run(() =>
            {
                Console.WriteLine($"enter Task.Run(...):\n" +
                    $"{Thread.CurrentThread.ManagedThreadId}");

                Console.WriteLine("Warming the pan...");
                Task.Delay(3000).GetAwaiter().GetResult();

                Console.WriteLine($"Cracking {numberOfEggs} eggs");
                Console.WriteLine("Cooking the eggs");

                // Time Waiting
                Task.Delay(3000).GetAwaiter().GetResult();

                return new Egg();

            });

            Console.WriteLine("Put eggs on plate");

            return eggTask;
        }

    }
}