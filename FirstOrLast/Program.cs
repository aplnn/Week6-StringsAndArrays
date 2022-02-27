using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanimi
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            
            else if(firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }

            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on ühepikkused.");
            }
        }
    }
}
