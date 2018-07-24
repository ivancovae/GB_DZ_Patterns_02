namespace Patterns_02
{
    /// <summary>
    /// Запись Order в MySQL
    /// </summary>
    class WriteOrderSQL : IWriteOrder
    {
        /// <summary>
        /// Реализация записи в MySQL
        /// </summary>
        /// <param name="order"></param>
        public void Save(Order order) {}
    }
}
