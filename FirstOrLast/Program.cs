using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi


            Console.Write("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.Write("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem.");
            }
            else
            {
                Console.WriteLine("Sinu perekonnanimi on pikem.");
            }

        }
    }
}
