namespace SteamInfoPuller.Models
{
    public class CS2Match
    {
        public DateTime Date { get; set; }

        public string Map { get; set; }

        public string Mode { get; set; }

        public bool Win { get; set; }

        public int Kills { get; set; }

        public int Deaths { get; set; }

        public int Assists { get; set; }


        public double KD
        {
            get
            {
                if (Deaths == 0)
                    return Kills;

                return Math.Round(
                    (double)Kills / Deaths,
                    2);
            }
        }


        public string Result
        {
            get
            {
                return Win
                    ? "WIN"
                    : "LOSS";
            }
        }
    }
}