using System.Text.Json.Serialization;

public class VideoStream
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}