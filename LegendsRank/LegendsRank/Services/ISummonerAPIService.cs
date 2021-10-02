using System;
using System.Collections.Generic;
using System.Text;
using LegendsRank.Models;
using System.Threading.Tasks;
using Prism;
using Prism.Unity;
using Prism.Ioc;

namespace LegendsRank.Services
{
    public interface ISummonerAPIService
    {
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
