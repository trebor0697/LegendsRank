using Newtonsoft.Json;
using LegendsRank.Models;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Prism;
using Prism.Unity;
using Prism.Ioc;
using System;
using System.Collections.Generic;

namespace LegendsRank.Services
{
    class SummonerAPIService
    {
        public class SummonerAPIService : ISummonerAPIService
        {
            public async Task<Summoner> GetSummonerAsync(string summonerName)
            {
                Summoner summ = null;

                HttpClient client = new HttpClient();

                var SummonerName = summonerName.Replace(" ", "%20");

                var urlString = $"https://la1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{SummonerName}?api_key=RGAPI-e40aa00c-2072-436c-9002-3fc07374cafd";



                var response = await client.GetAsync(urlString);

                if (response.IsSuccessStatusCode)
                {
                    summ = JsonConvert.DeserializeObject<Summoner>(await response.Content.ReadAsStringAsync());
                }

                return summ;
            }
        }
    }
}
