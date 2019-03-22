using System;
using System.Collections.Generic;
using System.Linq;
using _05_TortaDellaNonna.DA.Models;

namespace _05_TortaDellaNonna.DA.Services {
    public class MockTortaRepository : ITortaRepository {

        private List<Torta> torte;

        public MockTortaRepository() {
            if (torte is null) {
                LoadData();
            }
        }

        private void LoadData() {
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

        public Torta Get(int id) {
            return torte.FirstOrDefault(torte => torte.Id == id);
        }

        public IEquatable<Torta> Get() {
            return torte;
        }

        public Torta Insert(Torta entity) {
            int id = torte.Max(torte => torte.Id) + 1;
            entity.Id = id;
            return torte.Add(entity);
        }

        public void Delete(Torta entity) {
            torte.remove(entity);
        }

        public void Update(Torta entity) {
            Torta t = entity.Id;

            t.Nome = entity.Nome;
            t.Descrizione = entity.Descrizione;
            t.Osservazioni = entity.Osservazioni;
            t.Prezzo = entity.Prezzo;
            t.TortaDelMese = entity.TortaDelMese;
            t.ImageUrl = entity.ImageUrl;
            t.ImageThumbnailUrl = entity.ImageThumbnailUrl;
        }
    }
}
