using System.Text.Json.Serialization;

public class ProductServiceLevel
{
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; set; }
}