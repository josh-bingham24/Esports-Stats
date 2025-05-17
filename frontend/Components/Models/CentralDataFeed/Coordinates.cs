using System.Text.Json.Serialization;

public class Coordinates
{
    [JsonPropertyName("x")]
    public float X { get; set; }
    [JsonPropertyName("y")]
    public float Y { get; set; }
}