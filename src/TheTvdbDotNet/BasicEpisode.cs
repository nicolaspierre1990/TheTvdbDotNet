using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class BasicEpisode
    {
        [JsonPropertyName("absoluteNumber")]
        public int? AbsoluteNumber { get; set; }

        [JsonPropertyName("airedEpisodeNumber")]
        public int? AiredEpisodeNumber { get; set; }

        [JsonPropertyName("airedSeason")]
        public int? AiredSeason { get; set; }

        [JsonPropertyName("dvdEpisodeNumber")]
        public int? DvdEpisodeNumber { get; set; }

        [JsonPropertyName("dvdSeason")]
        public int? DvdSeason { get; set; }

        [JsonPropertyName("episodeName")]
        public string EpisodeName { get; set; }

        [JsonPropertyName("firstAired")]
        public string FirstAired { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("lastUpdated")]
        public long? LastUpdated { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }
    }
}
