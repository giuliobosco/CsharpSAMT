using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _400_Videogiochi.DA;

namespace _400_Videogiochi.CLI {
    class Program {
        static void Main(string [] args) {
            VideoGiochiContext ctx = new VideoGiochiContext();

            var dati = from vg in ctx.VideoGiochi
                orderby vg.Nome
                select vg;

            foreach (var item in dati) {
                Console.WriteLine(item.Nome);
            }

            Console.ReadLine();
        }
    }
}
