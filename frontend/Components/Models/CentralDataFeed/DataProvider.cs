using System.Text.Json.Serialization;

public class DataProvider
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}