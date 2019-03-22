using System;
using _05_TortaDellaNonna.DA.Models;
using _05_TortaDellaNonna.DA.Services;
namespace _05_TortaDellaNonna.CLI {
    class Program {
        static void Main(string[] args) {
            UseMockRepository();
        }

        private static void UseMockRepository() {
            foreach (var item in new MockTortaRepository().Get()) {
                Console.Write("Nome: " + item.Nome);
                Console.WriteLine("Prezzo: " + item.Prezzo + "\n");
            }
        }
    }
}
