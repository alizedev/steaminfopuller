namespace SteamInfoPuller.Models
{
    public class MatchStats
    {
        public int TotalMatches { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }


        public int TotalKills { get; set; }

        public int TotalDeaths { get; set; }


        public double AverageKD
        {
            get
            {
                if(TotalDeaths == 0)
                    return TotalKills;

                return Math.Round(
                    (double)TotalKills / TotalDeaths,
                    2);
            }
        }


        public double WinRate
        {
            get
            {
                if(TotalMatches == 0)
                    return 0;

                return Math.Round(
                    (double)Wins / TotalMatches * 100,
                    1);
            }
        }
    }
}