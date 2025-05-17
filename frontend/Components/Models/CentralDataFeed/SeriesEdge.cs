using System.Text.Json.Serialization;

public class SeriesEdge
{
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
    [JsonPropertyName("node")]
    public Series? Node { get; set; }
}