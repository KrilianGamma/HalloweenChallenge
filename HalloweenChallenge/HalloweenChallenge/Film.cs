namespace HalloweenChallenge
{
    public class Film
    {
        public string title { get; set; }
        public string description { get; set; }
        public string lenguage_id { get; set; }
        public string lenght { get; set; }
        public string rating { get; set; }
        public string FullInfo
        {
            get
            {
                return title + rating;
            }
        }

    }
}