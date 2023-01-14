using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabliczkaMnozenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Tablica();
        }

        private void Tablica()
        {
            Console.WriteLine("Podaj liczbe: ");
            string line = Console.ReadLine();
            int liczba = int.Parse(line);
            int n = 3;
            int k = 0;
            int r = 0;

            while (k <= n)
            {
                while(r<=n)
                {
                    Console.Write(r.ToString() + '\t');
                    r++;
                }
                k++;
            }

            //while (k <= liczba) {
            //    Console.Write(k.ToString() + '\t');                
            //    k++;
            //}            
            //while ( r <= liczba)
            //{
            //    Console.WriteLine(r.ToString() + '\t');
            //    r++;
            //}
            
        }

    }
}
