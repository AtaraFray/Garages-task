using GaragesDTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GaragesBLL
{
    public class GovApiService : IGovApiService
    {
        private readonly HttpClient _httpClient;
        public GovApiService()
        {
             _httpClient = new HttpClient();
        }
        public async Task<List<GarageDTO>> GetGovGaragesAsync()
        {
            try
            {
                string apiUrl = "https://data.gov.il/api/3/action/datastore_search?resource_id=bb68386a-a331-4bbc-b668-bba2766d517d&limit=5";

                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                string json = await response.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(json);

                var records = obj["result"]["records"];

                List<GarageDTO> garageList = new List<GarageDTO>();

                foreach (var r in records)
                {
                    garageList.Add(new GarageDTO
                    {
                        GarageId = (int?)r["_id"],
                        GarageNumber = (int?)r["mispar_mosah"],
                        GarageName = (string)r["shem_mosah"],
                        GarageCodeType = (int?)r["cod_sug_mosah"],
                        GarageType = (string)r["sug_mosah"],
                        GarageAddress = (string)r["ktovet"],
                        GarageCity = (string)r["yishuv"],
                        GaragePhone = (string)r["telephone"],
                        GaragePostalCode = (int?)r["mikud"],
                        GarageProfession = (int?)r["cod_miktzoa"],
                        Profession = (string)r["miktzoa"],
                        ProfessionManager = (string)r["menahel_miktzoa"],
                        RegisterCompany = (long?)r["rasham_havarot"],
                        Testime = (string)r["testime"]
                    });
                }
                return garageList;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to get data from the GovAPI", exception);
            }
        }

    }
    }
}
