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
                        Console.WriteLine("\nStan konta: {0}zł", pieniadze);
                        WyswietlKupon(kupon);

                        //MENU
                        if (pieniadze >= 3 && losow < 8)
                        {
                            Console.WriteLine("1 - Postaw los - 3zł [{0}/8]", losow + 1);
                        }

                        Console.WriteLine("2 - Sprawdź kupon - losowanie");
                        Console.WriteLine("3 - Zakończ grę");

                        //MENU

                        wybor = Console.ReadKey().Key;
                        if (wybor == ConsoleKey.D1 && pieniadze >= 3 && losow < 8)
                        {
                            kupon.Add(item: PostawLos());
                            pieniadze -= 3;
                            losow++;
                        }


                    } while (wybor == ConsoleKey.D1);
                    Console.Clear();
                    if (kupon.Count > 0)
                    {
                        int wygrana = Sprawdz(kupon);
                        if (wygrana >0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nBrawo wygrałeś {0} w tym losowaniu!", wygrana);
                            Console.ResetColor();
                            pieniadze += wygrana;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNiestety nic nie wygrałeś w tym losowaniu!");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nie miełeś losów w tym losowaniu.");
                    }

                    Console.WriteLine("Enter - kontynułuj.");
                    Console.ReadKey();

                } while (pieniadze >= 3 && wybor != ConsoleKey.D3);

                Console.WriteLine("Dzień {0}. \nKoniec gry, Twoj wynik to : {1} zł", dzien, pieniadze - START);
                Console.WriteLine("Enter - graj od nowa.");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        private static int Sprawdz(List<int[]> kupon)
        {
            throw new NotImplementedException();
        }

        private static int[] PostawLos()
        {
            throw new NotImplementedException();
        }

        private static void WyswietlKupon(List<int[]> kupon)
        {
            if (kupon.Count == 0)
            {
                Console.WriteLine("Nie postawiłeś jeszcze żadnych losów.");
            }
            else
            {
                int i = 0;
                Console.WriteLine("\nTWÓJ KUPON:");
                foreach (int[] los in kupon)
                {
                    i++;
                    Console.WriteLine(i + ": ");
                    foreach (int liczba in los)
                    {
                        Console.Write(liczba + ", ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
