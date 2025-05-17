using System.Text.Json.Serialization;

public class OrganizationRelation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}