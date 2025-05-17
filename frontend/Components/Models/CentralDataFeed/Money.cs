using System.Text.Json.Serialization;

public class Money
{
    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }
}