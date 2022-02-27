using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower(); //ees- ja perenimi liidetakse kokku üheks joruks
            
            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    aCounter++;
                }

            }

            if(aCounter != 1) //selle tingimuse lisan selleks, et konsoolis kuvatav lause grammatiliselt õigesti kirjutada
            {
                Console.WriteLine($"Sinu nimes {fullName} on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes {fullName} on {aCounter} 'a' täht.");
            }
            
        }
    }
}
