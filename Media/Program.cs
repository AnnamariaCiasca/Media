//Realizzare un programma che permetta l’inserimento di una
//serie di valori da tastiera, segnalando quando il valore medio
//corrente scende al di sotto di una certa soglia


using System;
using System.Collections.Generic;
using System.Linq;

namespace Media
{
    class Program
    {
        static List<int> listaNumeri = new List<int>();
        static void Main(string[] args)
        {
            GeneratoreEvento gen = new GeneratoreEvento();
            gen.MediaSuperata += RicezioneNotifica;
            while (true)
            {
                bool conversioneRiuscita = int.TryParse(Console.ReadLine(), out int num);
                if (conversioneRiuscita)
                {
                    listaNumeri.Add(num);
                    double media = CalcolaMedia(listaNumeri);
                    if (media < 10)
                    {
                        gen.SuperamentoMedia(media);
                    }
                }
            }
        }

        private static double CalcolaMedia(List<int> listaNumeri)
        {
            return listaNumeri.Sum() / listaNumeri.Count();
        }

        public static void RicezioneNotifica(GeneratoreEvento gen, double media)
        {
            Console.WriteLine($"La media ha un valore pari a {media} inferiore alla soglia critica");

        }
    }
}
