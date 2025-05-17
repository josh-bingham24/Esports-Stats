using System.Text.Json.Serialization;

public class TeamEdge
{
    [JsonPropertyName("cursor")]
    public string? cursor { get; set; }
    [JsonPropertyName("node")]
    public Team? Team { get; set; }
}