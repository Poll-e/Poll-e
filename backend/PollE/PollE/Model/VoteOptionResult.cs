namespace PollE.Model
{
    public class VoteOptionResult
    {
        public PollOption Option { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}