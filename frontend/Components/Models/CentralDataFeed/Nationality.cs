using System.Text.Json.Serialization;

public class Nationality
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}