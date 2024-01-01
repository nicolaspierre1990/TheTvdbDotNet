using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class JsonErrors
    {
        [JsonPropertyName("")]
        public string[] InvalidFilters { get; set; }

        [JsonPropertyName("invalidLanguage")]
        public string InvalidLanguage { get; set; }

        [JsonPropertyName("invalidQueryParams")]
        public string[] InvalidQueryParams { get; set; }
    }
}
