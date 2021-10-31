using DAL;
using DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PlacesBLL
    {
        public static async Task<List<PlacesDTO>> GetPlacesBySearch(string searchWord)
        {
            try
            {
                List<PlacesDTO> placesList = new List<PlacesDTO>();
                var places = await PlacesDAL.GetPlacesBySearch(searchWord);
                var objects = JArray.Parse(places.ToString());

                foreach (JObject p in objects)
                {
                    PlacesDTO place = new PlacesDTO();
                    place.Key = p["Key"].ToString();
                    place.localizedName = p["LocalizedName"].ToString();

                    placesList.Add(place);
                }
                return placesList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
