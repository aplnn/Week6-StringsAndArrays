using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (kasutame Random klassi)

            string[] predictions = { "win a million", "fall in love", "buy YouTube Premium", "join the darkside for cookies" };

            Console.WriteLine("Let's see what happens to you tomorrow...");
            System.Threading.Thread.Sleep(2000); //venitab natukene vastusega

            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[userNumber]}!");

        }
    }
}
