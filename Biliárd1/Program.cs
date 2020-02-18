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
            for (int i = 0; i < golyók.Count; i++)
            {
                Console.WriteLine(golyók[i]);
            }
            Console.ReadLine();
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
