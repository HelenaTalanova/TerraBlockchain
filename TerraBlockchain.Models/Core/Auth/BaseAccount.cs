using Newtonsoft.Json.Linq;

namespace TerraBlockchain.Models.Core.Auth
{
    /// <summary>
    /// Базовое представление информации об аккаунте
    /// </summary>
    public class BaseAccount : BaseModel<BaseAccount, BaseAccount>
    {
        /// <summary>
        /// Адрес - terra1...
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// Публичный ключ аккаунта
        /// </summary>
        public PublicKey PublicKey { get; set; }
        
        /// <summary>
        /// Номер аккаунта
        /// </summary>
        public long? AccountNumber { get; set; }
        
        /// <summary>
        /// Подписанных транзакций
        /// </summary>
        public long? Sequence { get; set; }

        public override BaseAccount FromAmino(JToken j) =>
            new()
            {
                Address = j.Value<string>("address"),
                PublicKey = PublicKey.FromAmino(j, "public_key"),
                AccountNumber = j.Value<long?>("account_number"),
                Sequence = j.Value<long?>("sequence"),
            };

        public override BaseAccount FromData(JToken j) =>
            new()
            {
                Address = j.Value<string>("address"),
                PublicKey = PublicKey.FromData(j, "pub_key"),
                AccountNumber = j.Value<long?>("account_number"),
                Sequence = j.Value<long?>("sequence"),
            };
    }
}
