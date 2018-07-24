using System.Drawing;

namespace Patterns_02.Part02.Interfaces
{
    /// <summary>
    /// Интерфейс товара, некоторый товар может быть из другого материала, например, составной материал
    /// </summary>
    interface IMaterial
    {
        /// <summary>
        /// Задание цвета материала для товара
        /// </summary>
        /// <param name="color">цвет</param>
        void SetColor(Color color);
    }
}
