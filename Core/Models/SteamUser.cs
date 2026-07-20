namespace SteamInfoPuller.Models
{
    public class SteamUser
    {
        public string SteamId { get; set; }

        public string Username { get; set; }

        public string RealName { get; set; }

        public string AvatarUrl { get; set; }

        public string ProfileUrl { get; set; }

        public int SteamLevel { get; set; }

        public int PersonaState { get; set; }

        public string Status { get; set; }

        public DateTime LastLogOff { get; set; }

        public DateTime Created { get; set; }


        // Verknüpfung zu den Spielen
        public List<SteamGame> Games { get; set; }
            = new List<SteamGame>();


        // Hilfswerte für die GUI
        public int TotalGames
        {
            get
            {
                return Games.Count;
            }
        }


        public int TotalPlaytime
        {
            get
            {
                return Games.Sum(x => x.PlaytimeForever);
            }
        }


        public string TotalPlaytimeHours
        {
            get
            {
                return $"{TotalPlaytime / 60} Stunden";
            }
        }
    }
}