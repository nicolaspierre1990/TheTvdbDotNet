using System.Text.Json.Serialization;

namespace TheTvdbDotNet.Authentication
{
    public class LoginResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
