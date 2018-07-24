namespace Patterns_02
{
    /// <summary>
    /// Запись Order через API
    /// </summary>
    class WriteOrderAPI : IWriteOrder
    {
        /// <summary>
        /// Реализация записи в MySQL
        /// </summary>
        /// <param name="order"></param>
        public void Save(Order order) {}
    }
}
