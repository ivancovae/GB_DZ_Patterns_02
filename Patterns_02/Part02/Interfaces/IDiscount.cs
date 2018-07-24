namespace Patterns_02.Part02.Interfaces
{
    /// <summary>
    /// Интерфейс скидок для товара
    /// </summary>
    interface IDiscount
    {
        /// <summary>
        /// Задание скидки для товара
        /// </summary>
        /// <param name="discount">скидка</param>
        void SetDiscount(double discount);
    }
}
