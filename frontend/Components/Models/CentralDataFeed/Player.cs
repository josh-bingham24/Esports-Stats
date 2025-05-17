using System.Text.Json.Serialization;

public class Player
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("age")]
    public int? Age { get; set; }
    [JsonPropertyName("externalLinks")]
    public List<ExternalLink>? ExternalLinks { get; set; }
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }
    [JsonPropertyName("imageUrl")]
    public string? ImageUrl { get; set; }
    [JsonPropertyName("nationality")]
    public Nationality? Nationality { get; set; }
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("roles")]
    public List<PlayerRole>? Roles { get; set; }
    [JsonPropertyName("team")]
    public Team? Team { get; set; }
    [JsonPropertyName("title")]
    public Title? Title { get; set; }
}