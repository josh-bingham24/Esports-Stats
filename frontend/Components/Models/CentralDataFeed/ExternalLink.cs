using System.Text.Json.Serialization;

public class ExternalLink
{
    [JsonPropertyName("dataProvider")]
    public DataProvider? DataProvider { get; set; }
    [JsonPropertyName("externalEntity")]
    public ExternalEntity? ExternalEntity { get; set; }
}