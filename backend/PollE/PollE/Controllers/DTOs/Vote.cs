using System.Net.NetworkInformation;
using System.Text.Json.Serialization;

namespace PollE.Controllers.DTOs
{
    public class Vote
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }
        
        [JsonPropertyName("option_id")]
        public int OptionId { get; set; }
        
        [JsonPropertyName("likes")]
        public bool Likes { get; set; }
        
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
    }
}