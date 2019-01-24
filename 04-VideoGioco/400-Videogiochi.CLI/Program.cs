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
            
            var tipi = from t in ctx.Tipi
                orderby t.Nome
                select t;

            foreach (var item in tipi) {
                Console.WriteLine(item.Nome);
            }

            Console.ReadLine();
        }
    }
}
