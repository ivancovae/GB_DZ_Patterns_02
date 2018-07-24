namespace Patterns_02
{
    /// <summary>
    /// Интерфейс изменения уже существующей записи Order
    /// </summary>
    interface IModifyOrder
    {
        /// <summary>
        /// Обновление существующего Order
        /// </summary>
        /// <param name="order">существующий Order</param>
        void Update(Order order);
        /// <summary>
        /// Удаление существующего Order
        /// </summary>
        /// <param name="order">существующий Order</param>
        void Delete(Order order);
    }
}
