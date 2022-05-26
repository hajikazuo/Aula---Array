using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array___Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("Valor {0}:", i));
                valores[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                 Console.WriteLine(String.Format("Elemento {0} = valor {1}", i, valores [i]));
            }
        }
    }
}
