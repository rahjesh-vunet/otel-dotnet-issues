using System.Text.Json.Serialization;
namespace FrmApp.Models.DTOs;

public class FrmSignalRequestDTO
{
  [JsonPropertyName("signal")]
  public string /* FSignal */ Signal { get; set; } = default!;

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("expectedFailurePct")]
  public int? ExpectedFailurePct { get; set; }

  [JsonPropertyName("active")]
  public bool Active { get; set; }

  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  [JsonPropertyName("expectedDelayInSec")]
  public int? ExpectedDelayInSec { get; set; }
}


// public enum FSignal : int { 
//     [StringValue("frm-err")]
//     FrmErr = 0,
//     [StringValue("frm-slow")]
//      FrmSlow = 1};


//     public class StringValueAttribute : Attribute {

//         #region Properties

//         public string StringValue { get; protected set; }

//         #endregion

//         #region Constructor

//         public StringValueAttribute(string value) {
//             this.StringValue = value;
//         }

//         #endregion

//     }


// public static class EXT{
//        public static string GetStringValue(this Enum value) {
//             // Get the type
//             Type type = value.GetType();

//             // Get fieldinfo for this type
//             FieldInfo fieldInfo = type.GetField(value.ToString());

//             // Get the stringvalue attributes
//             StringValueAttribute[]? attribs = fieldInfo.GetCustomAttributes(
//                 typeof(StringValueAttribute), false) as StringValueAttribute[];

//             // Return the first if there was a match.
//             return attribs.Length > 0 ? attribs[0].StringValue : null;
//         }
// }