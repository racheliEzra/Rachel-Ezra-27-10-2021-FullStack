using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WeatherDAL
    {
        static string Apikey;
        public async static Task<string> getCurrentWeather(int locationKey)
        {
            Apikey = "xeSz2trSIOXrkTdAxg5fz5pAkacXGTaz";
            var url = "http://dataservice.accuweather.com/currentconditions/v1/" + locationKey + "?apikey=" + Apikey;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string strResult = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return strResult;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
