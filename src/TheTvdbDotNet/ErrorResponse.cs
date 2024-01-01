using System.Text.Json.Serialization;

namespace TheTvdbDotNet
{
    public class ErrorResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
