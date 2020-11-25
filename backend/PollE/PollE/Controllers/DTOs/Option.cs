using System.Text.Json.Serialization;

namespace PollE.Controllers.DTOs
{
    public class Option
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }
}