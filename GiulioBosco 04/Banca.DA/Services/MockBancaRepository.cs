using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Banca.DA.Models;

namespace Banca.DA.Services {
    class MockBancaRepository : IValutaRepository {
        private List<Valuta> valute;

        public MockBancaRepository() {
            if (valute is null) {
                CaricaDati();
            }
        }

        private void CaricaDati() {
            valute = new List<Valuta>
            {
                new Valuta {Id = 1, Codice = "EUR", Denominazione = "Euro", Entrata = 1000, Cambio = 1.1},
                new Valuta {Id = 1, Codice = "USD", Denominazione = "Dollaria americani", Entrata = 500, Cambio = 1.01},
                new Valuta {Id = 1, Codice = "BTC", Denominazione = "Sterlina inglese", Entrata = 10000, Cambio = 1.3}
            };
        }

        public Valuta Get(int id) {
            return valute.FirstOrDefault(valuta => valuta.Id == id);
        }

        public IEnumerable<Valuta> Get() {
            return valute;
        }

        public void Delete(Valuta entity) {
            valute.Remove(entity);
        }

        public Valuta Insert(Valuta entity) {
            int id = valute.Max(a => a.Id) + 1;
            entity.Id = id;
            valute.Add(entity);
            return entity;
        }

        public void Update(Valuta entity) {
            int id = valute.Max(a => a.Id) + 1;
            entity.Id = id;
        }
    }
}
