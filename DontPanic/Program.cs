using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Don't Panic" nulliga - 0
            //programm asendab koik 'a' tahed lauses "Don't Panic" neljaga - 4

            string dontP = "Don't Panic";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);
        }
    }
    
}
