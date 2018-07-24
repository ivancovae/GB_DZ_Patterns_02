namespace Patterns_02
{
    /// <summary>
    /// Интерфейс чтения записи Order(в дальнейшем представление отделен для Readonly режима)
    /// </summary>
    interface IReadOrder
    {
        /// <summary>
        /// Чтение Order
        /// </summary>
        /// <param name="orderId">id order</param>
        /// <returns>объект Order</returns>
        Order Load(int orderId);
    }
}
