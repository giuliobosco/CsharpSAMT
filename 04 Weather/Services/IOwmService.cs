using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Weather.Model;

namespace _04_Weather.Services {
    public interface IOwmService {
        OpenWeatherMap GetWeatherForecast(string city);
    }
}
