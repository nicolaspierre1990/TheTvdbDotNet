using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class SeriesEpisodes
    {
        [JsonPropertyName("data")]
        public BasicEpisode[] Data { get; set; }

        [JsonPropertyName("errrors")]
        public JsonErrors Errors { get; set; }

        [JsonPropertyName("links")]
        public Links Links { get; set; }
    }
}
