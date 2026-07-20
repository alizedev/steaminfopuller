using SteamInfoPuller.Models;

namespace SteamInfoPuller.Core
{
    public class SteamInfoPuller
    {
        private readonly SteamApi _steamApi;


        public SteamInfoPuller(string apiKey)
        {
            _steamApi = new SteamApi(apiKey);
        }


        public async Task<SteamUser> GetSteamInfoAsync(string steamId)
        {
            // Benutzer laden
            SteamUser user =
                await _steamApi.GetUserAsync(steamId);


            // Spiele laden
            List<SteamGame> games =
                await _steamApi.GetGamesAsync(steamId);


            // Spiele an Benutzer hängen
            user.Games = games;


            return user;
        }
    }
}