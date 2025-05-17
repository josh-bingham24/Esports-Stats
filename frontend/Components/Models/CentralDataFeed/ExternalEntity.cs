using System.Text.Json.Serialization;

public class ExternalEntity
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}