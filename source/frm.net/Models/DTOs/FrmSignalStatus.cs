using System.Text.Json.Serialization;
namespace FrmApp.Models.DTOs;

public partial class FrmSignalStatusDTO
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("signal")]
    public string Signal { get; set; } = default!;

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expectedFailurePct")]
    public long? ExpectedFailurePct { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expectedDelayInSec")]
    public long? ExpectedDelayInSec { get; set; }
}