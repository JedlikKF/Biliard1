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
            int leeső=LeEsőSorsoló(golyók);
            Kiiró(golyók);
            

           
            Console.WriteLine(leeső);
            Console.ReadLine();
            
        }

        private static void Kiiró(List<int> golyók)
        {
            for (int i = 0; i < golyók.Count; i++)
            {
                Console.Write(golyók[i]+" ");
            }
        }

        private static int LeEsőSorsoló(List<int> golyók)
        {
            
            
                Random gép = new Random();
            int szám = gép.Next(golyók.Count);
            golyók.Remove(szám);

            return golyók[szám];

           
            
        
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
