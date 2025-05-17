using System.Text.Json.Serialization;

public class TeamConnection
{
    [JsonPropertyName("max")]
    public List<TeamEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}