using System.Text.Json.Serialization;

public class Organization
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("teams")]
    public List<TeamRelation>? TeamRelations { get; set; }
}