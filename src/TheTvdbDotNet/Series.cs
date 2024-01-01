using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class Series
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("seriesName")]
        public string SeriesName { get; set; }

        [JsonPropertyName("aliases")]
        public string[] Aliases { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("seriesId")]
        public string SeriesId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("firstAired")]
        public string FirstAired { get; set; }

        [JsonPropertyName("network")]
        public string Network { get; set; }

        [JsonPropertyName("networkId")]
        public string NetworkId { get; set; }

        [JsonPropertyName("runtime")]
        public string Runtime { get; set; }

        [JsonPropertyName("genre")]
        public string[] Genre { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("lastUpdated")]
        public long LastUpdated { get; set; }

        [JsonPropertyName("airsDayOfWeek")]
        public string AirsDayOfWeek { get; set; }

        [JsonPropertyName("airsTime")]
        public string AirsTime { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("imdbId")]
        public string ImdbId { get; set; }

        [JsonPropertyName("zap2itId")]
        public string Zap2itId { get; set; }

        [JsonPropertyName("added")]
        public string Added { get; set; }

        [JsonPropertyName("addedBy")]
        public object AddedBy { get; set; }

        [JsonPropertyName("siteRating")]
        public double SiteRating { get; set; }

        [JsonPropertyName("siteRatingCount")]
        public int SiteRatingCount { get; set; }
    }
}
