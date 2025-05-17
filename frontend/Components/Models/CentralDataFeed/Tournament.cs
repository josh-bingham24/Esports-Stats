using System.Text.Json.Serialization;

public class Tournament
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("children")]
    public List<Tournament>? Children { get; set; }
    [JsonPropertyName("endDate")]
    public DateOnly? EndDate { get; set; }
    [JsonPropertyName("externalLinks")]
    public List<ExternalLink>? ExternalLinks { get; set; }
    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("nameShortened")]
    public string? NameShortened { get; set; }
    [JsonPropertyName("parent")]
    public Tournament? Parent { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("prizePool")]
    public Money? PrizePool { get; set; }
    [JsonPropertyName("startDate")]
    public DateOnly? StartDate { get; set; }
    [JsonPropertyName("teams")]
    public List<Team>? Teams { get; set; }
    [JsonPropertyName("titles")]
    public List<Title>? Titles { get; set; }
    [JsonPropertyName("venueType")]
    public string? VenueType { get; set; }
}