using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Infraesctructure.Models
{
    public class WeatherModel : IWeather
    {
        public WeatherModel()
        {

        }
        public DateTime ConvertDateTime(long Milisec)
        {
           
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
                dt = dt.AddMilliseconds(Milisec).ToLocalTime();
                return dt;
            
        }

        public void Create(WeatherInfo t)
        {
            throw new NotImplementedException();
        }

        public void Delete(WeatherInfo t)
        {
            throw new NotImplementedException();
        }

        public WeatherInfo FindAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
