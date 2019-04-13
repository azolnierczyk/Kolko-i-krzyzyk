using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_i_krzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            string ImieGraczaA = "";
            string ImieGraczaB = "";
            char ZnakGraczaA = 'x';
            char ZnakGraczaB = 'o';
            char[,] plansza = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
                };

            Console.Write("Wpisz imie gracza A: ");
            ImieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            ImieGraczaB = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
