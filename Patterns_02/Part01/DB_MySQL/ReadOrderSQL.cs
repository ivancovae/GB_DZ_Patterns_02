namespace Patterns_02
{
    /// <summary>
    /// Чтение Order из MySQL
    /// </summary>
    class ReadOrderSQL : IReadOrder
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
