using System.Text.Json.Serialization;

namespace TheTvdbDotNet.Authentication
{
    public class LoginRequest
    {
        [JsonPropertyName("apiKey")]
        public string ApiKey { get; set; }
    }
}
