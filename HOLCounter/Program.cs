using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, miut 'h', 'o' ja 'l' tähte on lauses "Hello World"

            Console.WriteLine("Kirjuta 'Hello World'");
            string helloWorld = Console.ReadLine().ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
               
            }

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }
            }

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"Lauses on {hCounter} 'h', {oCounter} 'o' ja {lCounter} 'l' tähte. ");




        }
    }
}
