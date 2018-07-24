namespace Patterns_02
{
    /// <summary>
    /// Класс репозитория Order
    /// </summary>
    class OrderRepository
    {
        /// <summary>
        /// Чтение объекта Order по id объекта Order
        /// </summary>
        /// <param name="reader">объект с помощью которого берется Order</param>
        /// <param name="orderId">id объекта Order</param>
        /// <returns>объект Order</returns>
        public Order Load(IReadOrder reader, int orderId) => reader.Load(orderId);

        /// <summary>
        /// Сохранение объекта Order
        /// </summary>
        /// <param name="writter">объект с помощью которого сохраняется новый Order</param>
        /// <param name="order">объект Order</param>
        public void Save(IWriteOrder writter, Order order) => writter.Save(order);

        /// <summary>
        /// Обновление объекта Order
        /// </summary>
        /// <param name="modificator">объект с помощью которого обновляется существующий Order</param>
        /// <param name="order">объект Order</param>
        public void Update(IModifyOrder modificator, Order order) => modificator.Update(order);
        /// <summary>
        /// Удаление объекта Order
        /// </summary>
        /// <param name="modificator">объект с помощью которого удаляется существующий Order</param>
        /// <param name="order">объект Order</param>
        public void Delete(IModifyOrder modificator, Order order) => modificator.Delete(order);
    }
}
