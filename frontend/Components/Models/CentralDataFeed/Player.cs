using System.Text.Json.Serialization;

public class Player
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("externalLinks")]
    public List<ExternalLink>? ExternalLinks { get; set; }
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