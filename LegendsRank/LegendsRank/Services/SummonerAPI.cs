using System;
using System.Collections.Generic;
using System.Text;
using Prism;
using Prism.Unity;
using Prism.Ioc;
using Refit;
using LegendsRank.Models;
using System.Threading.Tasks;

namespace LegendsRank.Services
{
    public interface SummonerAPI
    {
        [Get($"/lol/summoner/v4/summoners/by-name/{summonerName}?api_key=RGAPI-e40aa00c-2072-436c-9002-3fc07374cafd")]
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
