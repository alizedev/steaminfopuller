namespace SteamInfoPuller.Models;


public class SteamPlayer
{
    public string SteamId { get; set; }

    public string PersonaName { get; set; }

    public string AvatarFull { get; set; }

    public int CommunityVisibilityState { get; set; }

    public int PersonaState { get; set; }
}