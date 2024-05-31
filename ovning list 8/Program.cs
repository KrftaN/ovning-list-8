using System;
using System.Collections.Generic;

namespace övning_list._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många koder vill du skriva in?");
            int antalKoder = int.Parse(Console.ReadLine());

            Dictionary<char, char> kodLista = new Dictionary<char, char>();

            Console.WriteLine("Skriv in dina koder (på formen 'X Y'):");
            for (int i = 0; i < antalKoder; i++)
            {
                string[] kodPar = Console.ReadLine().Split();
                kodLista[kodPar[0][0]] = kodPar[1][0];
            }

            Console.WriteLine("Skriv in ditt hemliga meddelande:");
            string meddelande = Console.ReadLine();

            string avkodatMeddelande = AvkodaMeddelande(meddelande, kodLista);
            Console.WriteLine("Här är ditt avkodade meddelande:");
            Console.WriteLine(avkodatMeddelande);
        }

        static string AvkodaMeddelande(string meddelande, Dictionary<char, char> kodLista)
        {
            char[] avkodatMeddelande = new char[meddelande.Length];

            for (int i = 0; i < meddelande.Length; i++)
            {
                char tecken = meddelande[i];
                if (kodLista.ContainsKey(tecken))
                {
                    avkodatMeddelande[i] = kodLista[tecken];
                }
                else
                {
                    avkodatMeddelande[i] = tecken;
                }
            }

            return new string(avkodatMeddelande);
        }
    }
}
