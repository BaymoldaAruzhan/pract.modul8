using System;

class Supermarket
{
    public static void Main()
    {
        Console.WriteLine("Добро пожаловать в Продуктовый супермаркет!");

        Console.Write("Введите текущее время в формате HH:mm: ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime currentTime))
        {
            // Проверяем, входит ли текущее время в интервал скидки (с 8:00 до 12:00)
            bool isDiscountTime = currentTime.TimeOfDay >= new TimeSpan(8, 0, 0) && currentTime.TimeOfDay <= new TimeSpan(12, 0, 0);

            Console.WriteLine("Выберите продукты и введите цены (для завершения введите 'exit'):");

            double totalCost = 0;

            while (true)
            {
                Console.Write("Название продукта: ");
                string productName = Console.ReadLine();

                if (productName.ToLower() == "exit")
                    break;

                Console.Write("Цена: ");
                if (double.TryParse(Console.ReadLine(), out double productPrice))
                {
                    // Применяем скидку, если текущее время в интервале скидки
                    if (isDiscountTime)
                    {
                        productPrice *= 0.95; // 5% скидка
                    }

                    totalCost += productPrice;
                }
                else
                {
                    Console.WriteLine("Некорректная цена. Попробуйте снова.");
                }
            }

            Console.WriteLine($"Итого: {totalCost:C2}");
        }
        else
        {
            Console.WriteLine("Некорректное время. Пожалуйста, введите время в правильном формате (HH:mm).");
        }
    }
}
