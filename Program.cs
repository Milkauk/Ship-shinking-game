using System;

namespace MilkaUkkonenHarjoitustyöLaivanUpotus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            int taulukonPituus = 5;

            int[,] taulukko ={{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0}};
            bool VainUponneita = false;
            bool Lopetetaanko = false;

            string text;
            int osumia = 0, huteja = 0;

            Console.WriteLine("Tervetuloa pelaamaan laivanupotusta!");

            do
            {
                for (int i = 0; i < taulukonPituus; i++)
                {
                    for (int j = 0; j < taulukonPituus; j++)
                    {
                        Console.WriteLine("Rakennetaan pelitaulu. Anna luku 1 tai 0. (" + i + "-" + j + ")");
                        text = Console.ReadLine();
                        luku1 = Int32.Parse(text);
                        taulukko[i, j] = luku1;
                    }
                }
                Console.WriteLine();

                do
                {
                    for (int i = 0; i < taulukko.GetLength(0); i++)
                    {
                        for (int j = 0; j < taulukko.GetLength(1); j++)
                        {
                            Console.Write(taulukko[i, j] + " ");
                        }
                        Console.WriteLine();
                    }


                    Console.WriteLine("Anna rivi (0-4): ");
                    text = Console.ReadLine();
                    luku1 = Int32.Parse(text);

                    Console.WriteLine("Anna sarake (0-4): ");
                    text = Console.ReadLine();
                    luku2 = Int32.Parse(text);

                    if (luku1<5)
                    {
                        if (taulukko[luku1, luku2] == 1)
                        {
                            Console.WriteLine("Osuma!");
                            taulukko[luku1, luku2] = 0;
                            osumia += 1;
                        }
                        else
                        {
                            Console.WriteLine("Huti!");
                            huteja += 1;
                        }
                    }
                    else if (luku1 > 4 || luku2 > 4)
                    {
                        Console.WriteLine("Annoit virheellisen numeron. Yritä uudestaan!");
                    }

                    VainUponneita = true;

                    for (int i = 0; i < taulukonPituus; i++)
                    {
                        for (int j = 0; j < taulukonPituus; j++)
                        {
                            if (taulukko[i, j] == 1)
                            {
                                VainUponneita = false;
                            }
                        }
                    }
                } while (VainUponneita == false);
                Console.WriteLine("Osumia " + osumia + " huteja " + huteja);
                Console.WriteLine("Haluatko pelata uudestaan? (k/e)");
                text = Console.ReadLine();

                if (text == "k")
                {
                    Lopetetaanko = true;
                }
            } while (Lopetetaanko == true);
            Console.WriteLine("Peli on päättynyt!");
            Console.ReadKey();
        }
    }
}
