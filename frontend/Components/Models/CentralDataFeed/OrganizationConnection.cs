using System.Text.Json.Serialization;

public class OrganizationConnection
{
    [JsonPropertyName("edges")]
    public List<OrganizationEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}