using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    class Program
    {
        private static int kumulacja;
        private static int START = 30;
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int pieniadze = START;
            int dzien = 0;
            do
            {
                pieniadze = START;
                ConsoleKey wybor;
                dzien = 0;

                do
                {
                    kumulacja = rnd.Next(2, 37) * 100000;
                    dzien++;
                    int losow = 0;
                    List<int[]> kupon = new List<int[]>();

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Dzień: {0}", dzien);
                        Console.WriteLine("witaj w grze LOTTO, dziś do wygrania jest aż {0}zł", kumulacja);
                        Console.WriteLine("\n Stan konta: {0}zł", pieniadze);
                        WyswietlKupon(kupon);

                        // TODO:MENU
                        if (pieniadze >= 3 && losow < 8)
                        {
                            Console.WriteLine("1 - Postaw los - 3zł [{0}/8]", losow + 1);
                        }

                        Console.WriteLine("2 - Sprawdź kupon - losowanie");
                        Console.WriteLine("3 - Zakończ grę");

                        // TODO:MENU

                        wybor = Console.ReadKey().Key;
                        if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 8)
                        {
                            kupon.Add(item: PostawLos());
                        }


                    } while (b);


                } while (pieniadze >= 3 && wybor != ConsoleKey.D3);

                Console.WriteLine("Dzień {0}. \nKoniec gry, Twoj wynik to : {1} zł", dzien, pieniadze - START);
                Console.WriteLine("Enter - graj od nowa.");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static int[] PostawLos()
        {
            throw new NotImplementedException();
        }

        private static void WyswietlKupon(List<int[]> kupon)
        {


        }
    }
}
