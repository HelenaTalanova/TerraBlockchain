using Newtonsoft.Json.Linq;

namespace TerraBlockchain.Models.Core
{
    public class PublicKey : BaseModel<PublicKey, PublicKey>
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public override PublicKey FromAmino(JToken j) =>
            new()
            {
                Type = j.Value<string>("type"),
                Value = j.Value<string>("value")
            };

        public override PublicKey FromData(JToken j) =>
            new()
            {
                Type = j.Value<string>("@type"),
                Value = j.Value<string>("key")
            };
    }
}
