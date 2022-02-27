using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"

            string lauseHello1 = "Hello World!";
            Console.WriteLine(lauseHello1);
                        
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            
            for (int i = 0; i < lauseHello1.Length; i++)
            {
                if (lauseHello1[i] == 'H')
                {
                    hCounter++;
                }
                
                else if (lauseHello1[i] == 'o')
                {
                    oCounter++;
                }
                
                else if (lauseHello1[i] == 'l')
                {
                    lCounter++;
                }
                
            }
            
            Console.WriteLine($"Lauses '{lauseHello1}' on {hCounter} 'h' täht, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");
            
        }
    }
}
