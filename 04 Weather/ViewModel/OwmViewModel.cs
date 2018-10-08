using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model;
using _04_Weather.Services;

namespace _04_Weather.ViewModel {
    public class OwmViewModel : BindableBase {
        #region =================== costants ===================
        public const string DEFAULT_CITY = "London";
        #endregion

        #region =================== static Members =============
        #endregion

        #region =================== properties & members =======
        private OpenWeatherMap model;
        private OwmService owms;

        public string City {
            get { return model.City.Name; }
            set {
                if (model.City.Name == value) {
                    return;
                } else {
                    model.City.Name = value;
                    OnPropertyChanged(() => City);
                }
            }
        }

        public double Temperature {
            get { return model.Temperature.Value; }
        }

        public double MinTemperature {
            get { return model.Temperature.MinValue; }
        }

        public double MaxTemperature {
            get { return model.Temperature.MaxValue; }
        }

        public int Id {
            get { return model.Weather.Id; }
        }

        public string Description {
            get { return model.Weather.Description; }
        }

        public string Icon {
            get { return model.Weather.Icon; }
        }

        public IDelegateCommand WeatherCommand { get; private set; }
        #endregion

        #region =================== constructors ===============
        public OwmViewModel() {
            this.model = new OpenWeatherMap();
            this.owms = new OwmService();

            this.City = DEFAULT_CITY;

            WeatherCommand = new DelegateCommand(OnWeather);
        }
        #endregion

        #region =================== help methods ===============
        private void OnWeather(object obj) {
            model = owms.GetWeatherForecast(City);

            OnPropertyChanged(() => Id);
            OnPropertyChanged(() => Icon);
            OnPropertyChanged(() => Description);
            OnPropertyChanged(() => Temperature);
            OnPropertyChanged(() => MinTemperature);
            OnPropertyChanged(() => MaxTemperature);
        }
        #endregion

        #region =================== general methods ============
        #endregion
    }
}
