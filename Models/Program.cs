using SteamInfoPuller;


string apiKey = "DEIN_API_KEY";


string steamId = "DEINE_STEAM_ID";



var steam =
    new SteamApiClient(apiKey);



var player =
    await steam.GetPlayer(steamId);



Console.WriteLine(
    $"Name: {player.PersonaName}");


Console.WriteLine(
    $"Avatar: {player.AvatarFull}");



Console.WriteLine(
    "--------------------");



var games =
    await steam.GetGames(steamId);



foreach(var game in games)
{

    Console.WriteLine(
        $"{game.Name} - {game.PlaytimeForever / 60} Stunden");

}