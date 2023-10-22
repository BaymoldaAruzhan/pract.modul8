using System;

class SalesForecast
{
    static void Main()
    {
        // Исходные данные о продажах за пять месяцев
        int[] months = { 1, 2, 3, 4, 5 };
        double[] sales = { 100, 120, 130, 150, 160 };

        int n = months.Length; // Количество данных точек

        // Вычисление сумм и произведений
        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumXSquare = 0;

        for (int i = 0; i < n; i++)
        {
            sumX += months[i];
            sumY += sales[i];
            sumXY += months[i] * sales[i];
            sumXSquare += months[i] * months[i];
        }

        // Вычисление коэффициентов линейной функции
        double b = (n * sumXY - sumX * sumY) / (n * sumXSquare - sumX * sumX);
        double a = (sumY - b * sumX) / n;

        // Прогноз продаж на следующие три месяца
        Console.WriteLine("Прогноз продаж на следующие три месяца:");

        for (int month = 6; month <= 8; month++)
        {
            double forecast = a + b * month;
            Console.WriteLine($"Месяц {month}: Прогноз продаж - {forecast:F2}");
        }
    }
}
