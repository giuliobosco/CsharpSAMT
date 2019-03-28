using System;
using _06_Amici.DA.Services;
using _06_Amici.DA.Models;

namespace _06_Amici.CLI {
    class Program {
        static void Main(string[] args) {
            MockAmicoRepository ctx = new MockAmicoRepository();

            Amico amico = ctx.Get(1);

            Console.WriteLine(amico.Nome + " " + amico.Cognome);
            Console.ReadLine();
        }
    }
}
