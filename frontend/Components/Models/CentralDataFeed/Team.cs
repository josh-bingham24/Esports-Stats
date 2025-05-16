using System.Text.Json.Serialization;

public class Team
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("title")]
    public required Title Title { get; set; }
    // [JsonPropertyName("organization")]
    // public required Organization Organization { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("colorPrimary")]
    public string? PrimaryColor { get; set; }
    [JsonPropertyName("colorSecondary")]
    public string? SecondaryColor { get; set; }
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }
}