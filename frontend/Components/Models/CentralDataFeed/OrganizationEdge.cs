using System.Text.Json.Serialization;

public class OrganizationEdge
{
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
    [JsonPropertyName("node")]
    public Organization? Organization { get; set; }
}