namespace AsianKitchen.Infrastructure.Services.Authentication;

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Secret {get; set;}
    public int Expires {get; set;}
    public string Audience {get; set;}
    public string Issuer {get;set;}
}