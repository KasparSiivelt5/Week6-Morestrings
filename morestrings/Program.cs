using System;

namespace morestrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest ees ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõpevad punktiga
            Console.WriteLine("sisesta oma nimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta oma perekonnanimi");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Tere {firstname[0]}, {lastname[0]}.!");
  
        }
    }
}
