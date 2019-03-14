using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amici.DA.Models;

namespace Amici.DA.Services {
    public class MockAmicoRepository : IAmicoRepository {
        private List<Amico> amici;

        public MockAmicoRepository() {
            if (amici == null) {
                CaricaDati();
            }
        }

        private void CaricaDati() {
            amici = new List<Amico> {
                new Amico {Id = 1, Nome = "Matan", Cognome = "Davidi", Foto = "files/matandavidi.jpg"},
                new Amico {Id = 2, Nome = "Paolo", Cognome = "Guebeli", Foto = "files/paologuebeli.jpg"},
                new Amico {Id = 3, Nome = "Giulio", Cognome = "Bosco", Foto = "files/giuliobosco.jpg"},
                new Amico {Id = 4, Nome = "Jari", Cognome = "Naeser", Foto = "files/jarinaeser.jpg"},
                new Amico {Id = 5, Nome = "Gabriele", Cognome = "Alessi", Foto = "files/gabrielealessi.jpg"}
            };
        }

        public Amico Get(int id) {
            return amici.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Amico> Get() {
            return amici;
        }

        public Amico Insert(Amico entity) {
            int id = amici.Max(a => a.Id) + 1;
            entity.Id = id;
            amici.Add(entity);
            return entity;
        }

        public void Delete(Amico entity) {
            amici.Remove(entity);
        }

        public void Update(Amico entity) {
            throw new NotImplementedException();
        }
    }
}
