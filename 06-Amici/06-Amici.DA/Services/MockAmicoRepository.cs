using System;
using System.Collections.Generic;
using System.Linq;
using _06_Amici.DA.Model;

namespace _06_Amici.DA.Services {
    public class MockAmicoRepository : IAmicoRepository {

        private List<Amico> amici;
        
        public MockAmicoRepository() {
            if (amici is null) {
                LoadAmici();
            }
        }

        private void LoadAmici() {
            amici = new List<Amico> {
                new Amico {Id = 1, Nome = "Matan", Cognome = "Davidi", Foto = "files/matandavidi.jpg"},
                new Amico {Id = 2, Nome = "Paolo", Cognome = "Guebeli", Foto = "files/paologuebeli.jpg"},
                new Amico {Id = 3, Nome = "Giulio", Cognome = "Bosco", Foto = "files/giuliobosco.jpg"},
                new Amico {Id = 4, Nome = "Jari", Cognome = "Naeser", Foto = "files/jarinaeser.jpg"},
                new Amico {Id = 5, Nome = "Gabriele", Cognome = "Alessi", Foto = "files/gabrielealessi.jpg"}
            };
        }

        public void Delete(Amico entity) {
            amici.Remove(entity);
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

        public void Update(Amico entity) {
            Amico a = Get(entity.Id);
            a.Nome = entity.Nome;
            a.Cognome = entity.Cognome;
            a.Luogo = entity.Luogo;
            a.Foto = entity.Foto;
        }
    }
}
