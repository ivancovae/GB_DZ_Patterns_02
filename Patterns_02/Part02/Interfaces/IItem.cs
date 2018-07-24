using System.Drawing;

namespace Patterns_02.Part02.Interfaces
{
    /// <summary>
    /// Интерфейс товарной единицы в магазине
    /// </summary>
    interface IItem
    {
        /// <summary>
        /// У любого товара нужно задавать размер
        /// </summary>
        /// <param name="size">Размер</param>
        void SetSize(Size size);
        /// <summary>
        /// У любого товара нужно задавать цену
        /// </summary>
        /// <param name="price"></param>
        void SetPrice(double price);
    }
}
