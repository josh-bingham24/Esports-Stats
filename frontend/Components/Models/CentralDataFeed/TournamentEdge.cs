using System.Text.Json.Serialization;

public class TournamentEdge
{
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
    [JsonPropertyName("node")]
    public Tournament? Node { get; set; }
}