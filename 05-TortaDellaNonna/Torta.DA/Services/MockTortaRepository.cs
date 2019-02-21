using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torta.DA.Services {
    public class MockTortaRepository : ITortaRepository {
        private List<Models.Torta> torte;

        public MockTortaRepository() {
            if (torte is null) {
                CaricaDati();
            }
        }

        private void CaricaDati() {
            torte = new List<Models.Torta>
                {
                    new Models.Torta {Id = 1, Nome = "Apple Pie", Prezzo = 12.95M, Descrizione = "La famosa apple pie!",
                    Osservazioni = "Torta di carote alla glassa jelly-o cheesecake. Rotolo dolce al caramello con marshmallow al marzapane al caramello e al brownie. Cioccolato torta pan di zenzero tootsie roll avena torta cioccolato bar biscotto brownie dragato. Torta lecca lecca con zucchero filato. Crostata con crostata di caramelle e caramelle. Marzapane con barrette di cioccolato e caramelle. Biscotti di zucchero filato e caramelle gommose con gocce di cioccolato.Biscotto danese al cioccolato. Crostata con ciambella al cioccolato con amaretto in polvere danese. Torta di carote glassata con gocce di limone liquirizia biscotto caramello. Torta di caramello e torta di carote. Artigli di orso caramelle su wafer di gelatina. Tiramis˘ gocce di limone danese. Caramelle al cioccolato.",
                    ImageUrl = "/files/applepie.jpg", TortaDelMese = true, ImageThumbnailUrl = "/files/applepiesmall.jpg"},
                    new Models.Torta {Id = 2, Nome = "Blueberry Cheese Cake", Prezzo = 18.95M, Descrizione = "Non puo' non piacere!",
                        Osservazioni = "Torta di carote alla glassa jelly-o cheesecake. Rotolo dolce al caramello con marshmallow al marzapane al caramello e al brownie. Cioccolato torta pan di zenzero tootsie roll avena torta cioccolato bar biscotto brownie dragato. Torta lecca lecca con zucchero filato. Crostata con crostata di caramelle e caramelle. Marzapane con barrette di cioccolato e caramelle. Biscotti di zucchero filato e caramelle gommose con gocce di cioccolato.Biscotto danese al cioccolato. Crostata con ciambella al cioccolato con amaretto in polvere danese. Torta di carote glassata con gocce di limone liquirizia biscotto caramello. Torta di caramello e torta di carote. Artigli di orso caramelle su wafer di gelatina. Tiramis˘ gocce di limone danese. Caramelle al cioccolato.",
                    ImageUrl = "/files/blueberrycheesecake.jpg", TortaDelMese = false, ImageThumbnailUrl = "/files/blueberrycheesecakesmall.jpg"},
                    new Models.Torta {Id = 3, Nome = "Cheese Cake", Prezzo = 18.95M, Descrizione = "Semplice cheese cake. Un piacere unico.",
                        Osservazioni = "Torta di carote alla glassa jelly-o cheesecake. Rotolo dolce al caramello con marshmallow al marzapane al caramello e al brownie. Cioccolato torta pan di zenzero tootsie roll avena torta cioccolato bar biscotto brownie dragato. Torta lecca lecca con zucchero filato. Crostata con crostata di caramelle e caramelle. Marzapane con barrette di cioccolato e caramelle. Biscotti di zucchero filato e caramelle gommose con gocce di cioccolato.Biscotto danese al cioccolato. Crostata con ciambella al cioccolato con amaretto in polvere danese. Torta di carote glassata con gocce di limone liquirizia biscotto caramello. Torta di caramello e torta di carote. Artigli di orso caramelle su wafer di gelatina. Tiramis˘ gocce di limone danese. Caramelle al cioccolato.",
                     ImageUrl = "/files/cheesecake.jpg", TortaDelMese = false, ImageThumbnailUrl = "/files/cheesecakesmall.jpg"},
                    new Models.Torta {Id = 4, Nome = "Cherry Pie", Prezzo = 15.95M, Descrizione = "Un classico dell'estate!",
                        Osservazioni = "Torta di carote alla glassa jelly-o cheesecake. Rotolo dolce al caramello con marshmallow al marzapane al caramello e al brownie. Cioccolato torta pan di zenzero tootsie roll avena torta cioccolato bar biscotto brownie dragato. Torta lecca lecca con zucchero filato. Crostata con crostata di caramelle e caramelle. Marzapane con barrette di cioccolato e caramelle. Biscotti di zucchero filato e caramelle gommose con gocce di cioccolato.Biscotto danese al cioccolato. Crostata con ciambella al cioccolato con amaretto in polvere danese. Torta di carote glassata con gocce di limone liquirizia biscotto caramello. Torta di caramello e torta di carote. Artigli di orso caramelle su wafer di gelatina. Tiramis˘ gocce di limone danese. Caramelle al cioccolato.",
                     ImageUrl = "/files/cherrypie.jpg", TortaDelMese = false, ImageThumbnailUrl = "/files/cherrypiesmall.jpg"}
                };
        }

        public Models.Torta Get(int id) {
            return torte.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Models.Torta> Get() {
            return torte;
        }

        public Models.Torta Insert(Models.Torta entity) {
            int newId = torte.Max(t => t.Id) + 1;
            entity.Id = newId;
            torte.Add(entity);
            return entity;
        }

        public void Delete(Models.Torta entity) {
            torte.Remove(entity);
        }

        public void Update(Models.Torta element) {
            throw new NotImplementedException();
        }
    }
}
