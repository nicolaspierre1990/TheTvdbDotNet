using System;
using System.Text;
using System.Text.Json;

namespace TheTvdbDotNet.Authentication;

public class AuthenticationToken : IAuthenticationToken
{
    public string TokenString { get; private set; }

    public Token Token { get; private set; }

    public bool IsAuthenticated => TokenString != null && Token.ExpiryDateTime > DateTime.UtcNow;

    public void SetToken(string token)
    {
        TokenString = token;
        Token = JsonSerializer.Deserialize<Token>(Decode(token));
    }

    private static string Decode(string token)
    {
        var parts = token.Split('.');
        if (parts.Length != 3)
        {
            throw new ArgumentException("Token must consist from 3 parts separated by dot");
        }

        return Encoding.UTF8.GetString(DecodePayload(parts[1]));
    }

    private static byte[] DecodePayload(string input)
    {
        input = input.Replace('-', '+');
        input = input.Replace('_', '/');
        switch (input.Length % 4)
        {
            case 0:
                break;
            case 2:
                input += "==";
                break;
            case 3:
                input += "=";
                break;
            default:
                throw new FormatException("Illegal base64url string!");
        }
        return Convert.FromBase64String(input);
    }
}
