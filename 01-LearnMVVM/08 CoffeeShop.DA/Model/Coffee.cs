using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CoffeeShop.DA.Model {
    public class Coffee {
        public int CoffeeId { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public Country Origin { get; set; }

        public bool InStock { get; set; }

        public int Stock { get; set; }

        public DateTime FirstAdded { get; set; }

        public int ImageId { get; set; }
    }
}
