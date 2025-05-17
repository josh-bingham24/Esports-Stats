using System.Text.Json.Serialization;

public class Series
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    [JsonPropertyName("externalLinks")]
    public List<ExternalLink>? ExternalLinks { get; set; }
    [JsonPropertyName("format")]
    public SeriesFormat? Format { get; set; }
    [JsonPropertyName("players")]
    public List<Player>? Players { get; set; }
    [JsonPropertyName("private")]
    public bool? Private { get; set; }
    [JsonPropertyName("productServiceLevels")]
    public List<ProductServiceLevel>? ProductServiceLevels { get; set; }
    [JsonPropertyName("startTimeScheduled")]
    public DateTime? StartTimeScheduled { get; set; }
    [JsonPropertyName("streams")]
    public List<VideoStream>? Streams { get; set; }
    [JsonPropertyName("teams")]
    public List<TeamParticipant>? Teams { get; set; }
    [JsonPropertyName("title")]
    public Title? Title { get; set; }
    [JsonPropertyName("tournament")]
    public Tournament? Tournament { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}