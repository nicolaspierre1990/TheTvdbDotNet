using System;
using System.Text.Json.Serialization;

namespace TheTvdbDotNet.Authentication
{
    public class Token
    {
        [JsonPropertyName("exp")]
        public long Expiry { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("orig_iat")]
        public long OriginalIssuedAt { get; set; }

        public DateTime ExpiryDateTime => Expiry.FromUnixTimestamp();

        public DateTime OriginalIssuedAtDateTime => OriginalIssuedAt.FromUnixTimestamp();
    }
}
