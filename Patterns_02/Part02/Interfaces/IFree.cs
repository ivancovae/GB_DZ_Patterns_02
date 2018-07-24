namespace Patterns_02.Part02.Interfaces
{
    /// <summary>
    /// Интерфейс добавления товара в промоакцию
    /// </summary>
    interface IFree
    {
        /// <summary>
        /// некоторые товары могут быть по промоакции и при этом быть без скидки
        /// </summary>
        /// <param name="promocode">промокод</param>
        void SetPromocode(string promocode);
    }
}
