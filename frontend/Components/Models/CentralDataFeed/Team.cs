using System.Text.Json.Serialization;

public class Team
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("colorPrimary")]
    public string? PrimaryColor { get; set; }
    [JsonPropertyName("colorSecondary")]
    public string? SecondaryColor { get; set; }
    [JsonPropertyName("externalLinks")]
    public List<ExternalLink>? ExternalLinks { get; set; }
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("nameShortened")]
    public string? NameShortened { get; set; }
    [JsonPropertyName("organization")]
    public OrganizationRelation? Organization { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("rating")]
    public float? Rating { get; set; }
    [JsonPropertyName("title")]
    public Title? Title { get; set; }
}