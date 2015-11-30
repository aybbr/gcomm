using PiDev_GCommunity_GUI.RavenCacheServices;
using NLog;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiDev_GCommunity_GUI.Helpers
{
    public class InitialEnityLoaders
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static readonly string AllStaticChampionsKey = "AllStaticChampions";

        static IRiotClient _riotClient;
        static ICacheManager _cacheManager;

        public InitialEnityLoaders(IRiotClient riotClient, ICacheManager cacheManager)
        {
            _riotClient = riotClient;
            _cacheManager = cacheManager;
        }


        public ChampionListDto CachedChampions
        {
            get
            {
                var allChampions = 
                    _cacheManager.Get(AllStaticChampionsKey, DateTime.Now.AddDays(1), () => _riotClient.LolStaticData.GetChampionList(RiotApi.Net.RestClient.Configuration.RiotApiConfig.Regions.Global));
                return allChampions;
            }
        }
    }
}