using System.Text.Json.Serialization;

public class SeriesFormat
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("nameShortened")]
    public string? NameShortened { get; set; }
}