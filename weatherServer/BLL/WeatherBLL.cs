using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Newtonsoft.Json.Linq;

namespace BLL
{
    public class WeatherBLL
    {
        public async static Task<WeatherDTO> getCurrentWeather(int locationKey)
        {
            try
            {
                var weather = await WeatherDAL.getCurrentWeather(locationKey);
                var objects = JArray.Parse(weather.ToString());
                WeatherDTO weatherCity = new WeatherDTO();

                foreach (JObject weatherObject in objects)
                {
                    weatherCity.WeatherText = weatherObject["WeatherText"].ToString();
                    weatherCity.TemperatureValue = Convert.ToInt32(weatherObject["Temperature"]["Metric"]["Value"]);
                }

                return weatherCity;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
