using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed laused "Hello world!" tärniga (*)

            string helloW = "Hello World!";

            /* for (int i = 0; i < helloW.Length; i++)
            {
                helloW[i] = '*'; //sõned on muutmatud, seda meetodit ei saa kasutada, vajab rohkem baasteadmisi
            }*/

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');

            Console.WriteLine(helloW);

        }
    }
}
