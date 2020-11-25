using System.Text.Json.Serialization;

namespace PollE.Controllers.DTOs
{
    public class VoteResult
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        
        [JsonPropertyName("likes")]
        public int Likes { get; set; }
        
        [JsonPropertyName("dislikes")]
        public int Dislikes { get; set; }
    }
}