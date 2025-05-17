using System.Text.Json.Serialization;

public class SeriesConnection
{
    [JsonPropertyName("edge")]
    public List<SeriesEdge>? Edges { get; set; }
    [JsonPropertyName("pageInfo")]
    public PageInfo? PageInfo { get; set; }
    [JsonPropertyName("totalCount")]
    public int? totalCount { get; set; }
}