using System.Text.Json.Serialization;

public class Bounds
{
    [JsonPropertyName("max")]
    public Coordinates? Max { get; set; }
    [JsonPropertyName("min")]
    public Coordinates? Min { get; set; }
}