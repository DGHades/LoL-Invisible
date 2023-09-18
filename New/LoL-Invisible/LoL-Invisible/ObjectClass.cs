using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    public class Lol
    {
        public string? bannerIdSelected { get; set; }
        public string? challengeCrystalLevel { get; set; }
        public string? challengePoints { get; set; }
        public string? challengeTitleSelected { get; set; }
        public string? challengeTokensSelected { get; set; }
        public string? championId { get; set; }
        public string? companionId { get; set; }
        public string? damageSkinId { get; set; }
        public string? gameId { get; set; }
        public string? gameMode { get; set; }
        public string? gameQueueType { get; set; }
        public string? gameStatus { get; set; }
        public string? iconOverride { get; set; }
        public string? isObservable { get; set; }
        public string? level { get; set; }
        public string? mapId { get; set; }
        public string? mapSkinId { get; set; }
        public string? masteryScore { get; set; }
        public string? puuid { get; set; }
        public string? queueId { get; set; }
        public string? rankedLeagueDivision { get; set; }
        public string? rankedLeagueQueue { get; set; }
        public string? rankedLeagueTier { get; set; }
        public string? rankedPrevSeasonDivision { get; set; }
        public string? rankedPrevSeasonTier { get; set; }
        public string? regalia { get; set; }
        public string? skinVariant { get; set; }
        public string? skinname { get; set; }
        public string? timeStamp { get; set; }
    }

    public class Root
    {
        public string? availability { get; set; }
        public string? gameName { get; set; }
        public string? gameTag { get; set; }
        public int? icon { get; set; }
        public string? id { get; set; }
        public string? lastSeenOnlineTimestamp { get; set; }
        public Lol? lol { get; set; }
        public string? name { get; set; }
        public int? obfuscatedSummonerId { get; set; }
        public string? patchline { get; set; }
        public string? pid { get; set; }
        public string? platformId { get; set; }
        public string? product { get; set; }
        public string? productName { get; set; }
        public string? puuid { get; set; }
        public string? statusMessage { get; set; }
        public string? summary { get; set; }
        public int? summonerId { get; set; }
        public int? time { get; set; }
    }

    public enum EStatus
    {
        OFFLINE = 10,
        AWAY = 20,
        CHAT = 30
    }
}
