namespace TerraBlockchain.Models.Request
{
    /// <summary>
    /// Базовый класс модели запроса
    /// </summary>
    public abstract class RequestBase
    {
        /// <summary>
        /// Получить путь запроса
        /// </summary>
        public abstract string GetPath();

        /// <summary>
        /// Преобразовать в JSON запрос
        /// </summary>
        /// <returns></returns>
        public virtual string ToJsonRequest()
        {
            return string.Empty;
        }
    }
}
