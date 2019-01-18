using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _201_Mercatino;

namespace _201_Mercatino.CLI {
    class Program {
        static void Main(string [] args) {
            MercatinoContext ctx = new MercatinoContext();

            var dati = from n in ctx.Nazioni
                orderby n.Nome
                select n;

            foreach (var item in dati) {
                Console.WriteLine(item.Nome);
            }

            Console.ReadLine();
        }
    }
}
