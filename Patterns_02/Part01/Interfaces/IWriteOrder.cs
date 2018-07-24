namespace Patterns_02
{
    /// <summary>
    /// Интерфейс записи не существующей записи Order(в дальнейшем представление отделен для Editable режима)
    /// </summary>
    interface IWriteOrder
    {
        /// <summary>
        /// Сохранение не существующего Order
        /// </summary>
        /// <param name="order">новый Order</param>
        void Save(Order order);
    }
}
