using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis puuvilja kasutaja sööb

            //string[] fruit = new string[5]; //5 tähendab et tuleb 5 puuvilja
            string[] fruit = new string[5] {"an apple", "a banana", "a lemon", "an orange", "some grapes"}; //igal puuviljal on nüüd oma koht 0,1,2,3,4,5

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            //...
            //laseme kasuajal sisestada numbri 0-5:
            //Console.WriteLine("Enter a number 0 to 4:");
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");

        }
    }
}
