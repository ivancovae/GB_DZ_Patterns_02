namespace Patterns_02
{
    /// <summary>
    /// Чтение Order через API
    /// </summary>
    class ReadOrderAPI : IReadOrder
    {
        /// <summary>
        /// Реализация чтения объекта Order
        /// </summary>
        /// <param name="orderId">id объекта Order</param>
        /// <returns>объект Order</returns>
        public Order Load(int orderId)
        {
            return new Order();
        }
    }
}
