using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_CoffeeShop.DA.Model;

namespace _08_CoffeeShop.DA {
    public class DataContext {
        public List<Coffee> Coffees { get; private set; }

        public DataContext() {
            Coffees = new List<Coffee>() {
                new Coffee() {
                    CoffeeId = 1,
                    Name = "Latte alla moda dello chef Gill",
                    Description = "Semplicemente il miglior latte al mondo, con un po' di sciroppo alle nocciole!",
                    ImageId = 1,
                    Stock = 10,
                    InStock = true,
                    FirstAdded = new DateTime(2014, 1, 3),
                    Origin = Country.Etiopia,
                    Price = 12
                },
                new Coffee() {
                    CoffeeId = 2,
                    Name = "Espresso",
                    Description =
                        "Espresso Ë un caffË forte dove il vapore ad alta pressione passa attraverso i chicchi di caffË macinati " +
                        "in una macchina per l'espresso. Un espresso perfetto avr‡ una densa schiuma di color marrone-oro. " +
                        "Lo zucchero rimmarr‡ a galleggiare per qualche secondo prima di sprofondare.",
                    ImageId = 2,
                    InStock = true,
                    Stock = 100,
                    FirstAdded = new DateTime(2015, 10, 3),
                    Origin = Country.Colombia,
                    Price = 12
                },
                new Coffee() {
                    CoffeeId = 3,
                    Name = "Cappuccino",
                    Description =
                        "Questo popolare forma di caffË viene sorseggiata principalmente al mattino con qualche croissant. " +
                        "Un vero cappuccino Ë una combinazione di parti uguali tra espresso, latte e schiuma di latte. " +
                        "Questa bevanda lussuriosa puÚ essere bevuta anche accompagnando un dessert (tedeschi).",
                    ImageId = 3,
                    InStock = true,
                    Stock = 0,
                    FirstAdded = new DateTime(2014, 5, 5),
                    Origin = Country.Ecuador,
                    Price = 12
                },
                new Coffee() {
                    CoffeeId = 4,
                    Name = "Americano",
                    Description = "Un caffË Americano Ë un espresso agggiungendo una tazza di acqua calda. " +
                                  "Il nome Ë una specie di insulto agli Americani, i quali dovevano diluire il loro espresso " +
                                  "quando divenne popolare su quel lato dell'Atalntico. Molti negozi di caffË lo hanno " +
                                  "perfezionato, ottenendo come risultato un caffË cremoso da gustare prima di una partita di calcio.",
                    ImageId = 4,
                    InStock = true,
                    Stock = 200,
                    FirstAdded = new DateTime(2013, 9, 9),
                    Origin = Country.India,
                    Price = 14
                },
                new Coffee() {
                    CoffeeId = 5,
                    Name = "CaffË Latte",
                    Description = "Una parte di caffË espresso e tre parti di latte caldo.",
                    ImageId = 5,
                    InStock = true,
                    Stock = 0,
                    FirstAdded = new DateTime(2013, 9, 9),
                    Origin = Country.India,
                    Price = 9
                },
                new Coffee() {
                    CoffeeId = 6,
                    Name = "CaffË au Lait",
                    Description =
                        "Questa bevanda tradizionale francese Ë simile al caffË latte eccetto che il caffË Ë " +
                        "filtrato in rapporto 1:1 con il latte.",
                    ImageId = 6,
                    InStock = false,
                    Stock = 8,
                    FirstAdded = new DateTime(2013, 9, 9),
                    Origin = Country.India,
                    Price = 11
                },
                new Coffee() {
                    CoffeeId = 7,
                    Name = "CaffË marocchino",
                    Description =
                        "si prepara versando nel bicchierino di vetro prima la schiuma del latte e poi il caffË, " +
                        "spesso viene aggiunto anche del cioccolato o del cacao.",
                    ImageId = 7,
                    InStock = true,
                    Stock = 1000,
                    FirstAdded = new DateTime(2013, 9, 9),
                    Origin = Country.Etiopia,
                    Price = 10
                },
                new Coffee() {
                    CoffeeId = 8,
                    Name = "Caramel Macchiato",
                    Description =
                        "Questa Ë un'ulteriore variazione servita in molti modi differenti a seconda del negozio. " +
                        "ILa forma pi˘ venduta Ë una combinazione di espresso, caramello e schiuma di latte. " +
                        "spesso viene aggiunta dell'estratto di vanilla.",
                    ImageId = 8,
                    InStock = true,
                    Stock = 200,
                    FirstAdded = new DateTime(2013, 9, 9),
                    Origin = Country.Honduras,
                    Price = 11
                }
            };
        }
    }
}
