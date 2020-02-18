using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biliárd1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> golyók = new List<int>();
            
            Kezdes(golyók);
            int Leeső;
           
            do
            {
                Leeső = LeEsőSorsoló(golyók);
                Console.WriteLine($"ez esett le:{Leeső}");
                
                Kiiró(golyók);
                Console.ReadLine();
                

            } while (golyók.Contains(8));

            if (golyók.Count==0)
            {
                Console.WriteLine("nyertél!");
            }
            else
            {
                Console.WriteLine("veszítettél!");
            }
           
            Console.ReadLine();
            
        }

        private static void Kiiró(List<int> golyók)
        {
            foreach (var item in golyók)
            {
                Console.Write($"{item} ");
            }
        }

        private static int LeEsőSorsoló(List<int> golyók)
        {
              
                Random gép = new Random();                      
                int szám= gép.Next(golyók.Count);
                int sorsolt = golyók[szám];
                golyók.Remove(golyók[szám]);
               
                return sorsolt;

        }

        private static void Kezdes(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
