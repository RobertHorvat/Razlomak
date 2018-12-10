using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Razlomak a = new Razlomak(4, 8);
            Console.WriteLine("Decimalna vrijednost iznosi: {0}", a.PretvoriUFloat());
            a.SkratiRazlomak();
        
            Razlomak b = new Razlomak(4, 8);
            Razlomak c = new Razlomak(12, 4);

            List<Razlomak> lista = new List<Razlomak>();
            lista.Add(a);
            lista.Add(b);
            lista.Add(c);
            lista.Sort();


            foreach (Razlomak r in lista)
            {
                Console.Write(r.PretvoriUFloat() + ",");
            }
            Console.WriteLine();

            if (a.Equals(b))
                Console.WriteLine("Jesu");
            else
                Console.WriteLine("Nisu");

            Console.ReadKey();

        }
    }
}
