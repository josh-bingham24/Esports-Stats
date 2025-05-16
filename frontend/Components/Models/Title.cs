using System.Text.Json.Serialization;

public class Title
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("nameShortened")]
    public string? NameShortened { get; set; }
}