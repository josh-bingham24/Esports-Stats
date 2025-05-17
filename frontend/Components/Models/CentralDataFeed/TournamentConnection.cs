using System.Text.Json.Serialization;

public class TournamentConnection
{
    [JsonPropertyName("edges")]
    public List<TournamentEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}