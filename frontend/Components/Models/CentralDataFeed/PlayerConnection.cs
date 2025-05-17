using System.Text.Json.Serialization;

public class PlayerConnection
{
    [JsonPropertyName("edges")]
    public List<PlayerEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}