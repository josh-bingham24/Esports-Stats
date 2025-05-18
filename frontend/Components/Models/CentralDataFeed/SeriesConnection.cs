using System.Text.Json.Serialization;

public class SeriesConnection
{
    [JsonPropertyName("edges")]
    public List<SeriesEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}