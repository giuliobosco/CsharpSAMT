using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _101_Mercatino.Models {
    public class DataContext {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public List<Mercatino> Mercatini { get; set; }

        #endregion

        #region =================== constructors ===============

        public DataContext() {
            Mercatini = new List<Mercatino>() {
                new Mercatino() {
                    Id = 1,
                    Luogo = "Lugano",
                    Nazione = "CH",
                    Inizio = new DateTime(2018,12,1)
                },
                new Mercatino() {
                    Id = 2,
                    Luogo = "Colmar",
                    Nazione = "Fr",
                    Inizio = new DateTime(2018,11,30)
                },
                new Mercatino() {
                    Id = 3,
                    Luogo = "Mocaco",
                    Nazione = "DE",
                    Inizio = new DateTime(2018,12,8)
                },
            };
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}