using System.Net.Http;
using System.Text.Json;
using SteamInfoPuller.Models;

namespace SteamInfoPuller.Core
{
    public class SteamApi
    {
        private readonly HttpClient _client;

        private readonly string _apiKey;


        public SteamApi(string apiKey)
        {
            _apiKey = apiKey;
            _client = new HttpClient();
        }


        public async Task<SteamUser> GetUserAsync(string steamId)
        {
            string url =
                $"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key={_apiKey}&steamids={steamId}";


            var json = await _client.GetStringAsync(url);


            using JsonDocument doc = JsonDocument.Parse(json);


            var player =
                doc.RootElement
                .GetProperty("response")
                .GetProperty("players")[0];


            return new SteamUser
            {
                SteamId = player.GetProperty("steamid").GetString(),

                Username =
                    player.GetProperty("personaname").GetString(),

                AvatarUrl =
                    player.GetProperty("avatarfull").GetString(),

                ProfileUrl =
                    player.GetProperty("profileurl").GetString()
            };
        }



        public async Task<List<SteamGame>> GetGamesAsync(string steamId)
        {
            string url =
                $"https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key={_apiKey}&steamid={steamId}&include_appinfo=true&include_played_free_games=true";


            var json = await _client.GetStringAsync(url);


            var result = new List<SteamGame>();

            using JsonDocument doc = JsonDocument.Parse(json);


            var games =
                doc.RootElement
                .GetProperty("response")
                .GetProperty("games");


            foreach(var game in games.EnumerateArray())
            {
                result.Add(new SteamGame
                {
                    AppId =
                        game.GetProperty("appid").GetInt32(),

                    Name =
                        game.GetProperty("name").GetString(),

                    PlaytimeForever =
                        game.GetProperty("playtime_forever").GetInt32()
                });
            }


            return result;
        }
    }
}