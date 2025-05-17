using System.Text.Json.Serialization;

public class TeamParticipant
{
    [JsonPropertyName("baseInfo")]
    public Team? BaseInfo { get; set; }
    [JsonPropertyName("scoreAdvantage")]
    public int? ScoreAdvantage { get; set; }
}