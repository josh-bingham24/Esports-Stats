using System.Text.Json.Serialization;

public class PlayerRole
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("title")]
    public Title? Title { get; set; }
}