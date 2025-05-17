using System.Text.Json.Serialization;

public class TeamRelation
{
    [JsonPropertyName("colorPrimary")]
    public string? ColorPrimary { get; set; }
    [JsonPropertyName("colorSecondary")]
    public string? ColorSecondary { get; set; }
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("logoUrl")]
    public string? logoUrl { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("nameShortened")]
    public string? NameShortened { get; set; }
    [JsonPropertyName("rating")]
    public float? Rating { get; set; }
    [JsonPropertyName("titles")]
    public List<Title>? Titles { get; set; }
}