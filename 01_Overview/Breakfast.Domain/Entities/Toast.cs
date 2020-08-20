using System;
using System.Threading.Tasks;




namespace Breakfast.Domain.Entities
{
    public class Toast : Bread
    {

        public bool Buttered { get; set; }
        public bool HasJam { get; set; }
        //public bool Toasted { get; set; } inherited



        public async static Task<Toast> ToastBreadAsync(int NumberOfSlices)
        {
            
            for(int i = 0; i < NumberOfSlices; i++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start Toasting...");

            var toastTask = await Task.Run(() =>
            {
                Task.Delay(3000);

                Console.WriteLine("Remove Toast from toaster");
                //this.Toasted = true;

                return new Toast();
            });


            return toastTask;

        }
        public Toast ApplyJam()
        {
            Console.WriteLine("Putting Jam on toast");
            this.HasJam = true;
            return this;
        }

        public Toast ApplyButter()
        {
            Console.WriteLine("Putting Butter on toast");
            this.Buttered = true;
            return this;
        }

        public static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await Toast.ToastBreadAsync(number);
            toast
                .ApplyButter()
                .ApplyJam();

            return toast;
        }


    }
}