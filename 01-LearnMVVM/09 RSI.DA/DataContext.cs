using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09_RSI.DA.Model;
using _09_RSI.Model;

namespace _09_RSI.DA {
    public class DataContext {
        #region =================== costants ===================
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======

        public List<Film> Films { get; private set; }

        #endregion

        #region =================== constructors ===============

        public DataContext() {
            Films = new List<Film>() {
                new Film() {
                    Id = 1,
                    Title = "Telegiornale",
                    Duration = 30,
                    Kind = FilmKind.Informazione,
                    StartTime = new DateTime(2018, 1, 1, 20, 0, 0),
                    Year = 2018
                }, 
                new Film() {
                    Id = 2,
                    Title = "Via col venti",
                    Duration = 25,
                    Kind = FilmKind.Varietà,
                    StartTime = new DateTime(2018, 1, 1,20, 35, 0),
                    Year = 2018
                },
                new Film() {
                    Id = 3,
                    Title = "Cobra 11",
                    Duration = 45,
                    Kind = FilmKind.Telefilm,
                    StartTime = new DateTime(2018, 1, 1, 21, 35, 0),
                    Year = 2018
                }
            };
        }

        #endregion

        #region =================== help methods ===============
        #endregion

        #region =================== general methods ============
        #endregion
    }
}
