using System.Text.Json.Serialization;

public class PlayerEdge
{
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
    [JsonPropertyName("node")]
    public Player? Node { get; set; }
}