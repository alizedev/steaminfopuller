namespace SteamInfoPuller.Models
{
    public class SteamGame
    {
        public int AppId { get; set; }

        public string Name { get; set; }

        public int PlaytimeForever { get; set; }

        public int Playtime2Weeks { get; set; }

        public DateTime? LastPlayed { get; set; }

        public string IconUrl { get; set; }

        public string HeaderImageUrl { get; set; }

        public int AchievementsUnlocked { get; set; }

        public int TotalAchievements { get; set; }

        public bool Installed { get; set; }


        // Hilfsproperty für die GUI
        public string PlaytimeHours
        {
            get
            {
                return $"{PlaytimeForever / 60} Stunden";
            }
        }
    }
}