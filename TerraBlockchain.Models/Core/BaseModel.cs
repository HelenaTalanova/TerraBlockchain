using Newtonsoft.Json.Linq;

namespace TerraBlockchain.Models.Core
{
    /// <summary>
    /// Интерфейс модели
    /// </summary>
    /// <typeparam name="TModel">Тип модели</typeparam>
    public interface IBaseModel<out TModel>
        where TModel : class, new()
    {
        /// <summary>
        /// Создать из JSON Amino (legacy)
        /// </summary>
        TModel FromAmino(JToken j);

        /// <summary>
        /// Создать из JSON Data (cosmos)
        /// </summary>
        TModel FromData(JToken j);
    }

    /// <summary>
    /// Базовый класс модели
    /// </summary>
    /// <typeparam name="TModel">Тип модели</typeparam>
    /// <typeparam name="TBaseModel">Реализация интерфейса BaseModel</typeparam>
    public abstract class BaseModel<TModel, TBaseModel> : IBaseModel<TModel>
        where TModel : class, new()
        where TBaseModel : IBaseModel<TModel>, new()
    {
        /// <summary>
        /// Создать из JSON Amino (legacy)
        /// </summary>
        public static TModel FromAmino(JToken j, string path)
            => new TBaseModel().FromAmino(j.SelectToken(path));

        /// <summary>
        /// Создать из JSON Amino (legacy)
        /// </summary>
        public abstract TModel FromAmino(JToken j);

        /// <summary>
        /// Создать из JSON Data (cosmos)
        /// </summary>
        public static TModel FromData(JToken j, string path)
            => new TBaseModel().FromData(j.SelectToken(path));
        
        /// <summary>
        /// Создать из JSON Data (cosmos)
        /// </summary>
        public abstract TModel FromData(JToken j);
    }
}
