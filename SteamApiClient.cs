using Newtonsoft.Json;
using SteamInfoPuller.Models;


namespace SteamInfoPuller;


public class SteamApiClient
{

    private readonly string apiKey;


    private readonly HttpClient client;



    public SteamApiClient(string key)
    {

        apiKey = key;

        client = new HttpClient();

    }



    public async Task<SteamPlayer?> GetPlayer(
        string steamId)
    {


        string url =
            $"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/" +
            $"?key={apiKey}&steamids={steamId}";



        var json =
            await client.GetStringAsync(url);



        dynamic data =
            JsonConvert.DeserializeObject(json);



        var player =
            data.response.players[0];



        return new SteamPlayer
        {

            SteamId =
                player.steamid,


            PersonaName =
                player.personaname,


            AvatarFull =
                player.avatarfull,


            PersonaState =
                player.personastate

        };

    }





    public async Task<List<SteamGame>> GetGames(
        string steamId)
    {


        string url =
            $"https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/" +
            $"?key={apiKey}&steamid={steamId}&include_appinfo=true";



        var json =
            await client.GetStringAsync(url);



        dynamic data =
            JsonConvert.DeserializeObject(json);



        var games =
            new List<SteamGame>();



        foreach(var game in data.response.games)
        {

            games.Add(new SteamGame
            {

                AppId = game.appid,

                Name = game.name,

                PlaytimeForever =
                    game.playtime_forever

            });

        }


        return games;

    }

}