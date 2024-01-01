using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class UpdateData
    {
        [JsonPropertyName("data")]
        public Update[] Data { get; set; }

        [JsonPropertyName("errors")]
        public JsonErrors Errors { get; set; }
    }
}
