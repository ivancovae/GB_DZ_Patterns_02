namespace Patterns_02
{
    /// <summary>
    /// Редактирование Order через API
    /// </summary>
    class ModifyOrderAPI : IModifyOrder
    {
        /// <summary>
        /// Удаление существующего Order
        /// </summary>
        /// <param name="order">объект Order</param>
        public void Delete(Order order)
        {
            // Удаление из базы существующего элемента
        }
        /// <summary>
        /// Обновление существующего Order
        /// </summary>
        /// <param name="order">объект Order</param>
        public void Update(Order order)
        {
            // Обновление в базе существующего элемента
        }
    }
}
