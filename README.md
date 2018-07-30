# GB_DZ_Patterns_02
Домашнее задание по курсу Архитектуры и шаблоны проектирования на C#(GeekBrains) 

1. Применить принцип открытости/закрытости.

Класс OrderRepository изначально был реализован для работы с заказами, хранящимися в MySQL. Но однажды нам потребовалось реализовать работу с данными о заказах, например, через API стороннего веб-сервиса. Какие изменения нам надо будет внести?

```c
class Order
{
    int orderId;
    string Name;
}
class OrderRepository
{
    public Order Load(int orderId) { return ... }
    public void Save(Order order) { ... }
    public void Update(Order order) { ... }
    public void Delete(Order order) { ... }
}
```

2. Принцип разделения интерфейсов.

Товары в магазине могут иметь промокод, скидку, у них есть цена, состояние и т.д. Если этот товар – одежда, то для нее устанавливается, из какого она материала, ее цвет и размер. Какие изменения нужно внести в код, чтобы описать произвольные товары (книги, автомобили и т.п.), соблюдая принципы SOLID?

```c
interface IItem
{
    void SetDiscount( double discount ); 
    void SetPromocode( string promocode);

    void SetColor(Color color);
    void SetSize(Size size);

    void SetPrice(double price);
}
class Clothes : IItem
{
    public void SetColor(Color color)    {    }
    public void SetDiscount(double discount)    {    }
    public void SetPrice(double price)    {    }
    public void SetPromocode(string promocode)    {    }
    public void SetSize(Size size)    {    }
}
```
