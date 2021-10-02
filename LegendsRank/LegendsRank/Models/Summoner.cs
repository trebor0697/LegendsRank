using System;
using System.Collections.Generic;
using System.Text;
using Prism;
using Prism.Unity;
using Prism.Ioc;

namespace LegendsRank.Models
{
    public class Summoner
    {
        public string Id { get; set; }
        public string AccountID { get; set; }
        public string Puuid { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public int SummonerLevel { get; set; }
    }
}

