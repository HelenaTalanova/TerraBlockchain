using Newtonsoft.Json;

namespace TerraBlockchain.Models.Common
{
    /// <summary>
    /// Количество токенов 
    /// </summary>
    public class AmountTokenModel
    {
        /// <summary>
        /// Имя в блокчейне
        /// </summary>
        [JsonProperty("denom")]
        public string AssetId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
