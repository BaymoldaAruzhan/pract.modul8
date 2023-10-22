using System;

class RangeOfArray
{
    private int[] data; // Внутренний массив
    private int lowerBound; // Нижний индекс массива

    public RangeOfArray(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
        {
            throw new ArgumentException("Нижний индекс должен быть меньше или равен верхнему индексу.");
        }

        this.lowerBound = lowerBound;
        int size = upperBound - lowerBound + 1;
        data = new int[size];
    }

    // Индексатор для доступа к элементам массива
    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return data[index - lowerBound];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                data[index - lowerBound] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
            }
        }
    }

    // Метод для проверки допустимости индекса
    private bool IsIndexValid(int index)
    {
        return index >= lowerBound && index <= lowerBound + data.Length - 1;
    }
}

class Program
{
    static void Main()
    {
        RangeOfArray array = new RangeOfArray(-9, 15);

        array[-9] = 1;
        array[0] = 2;
        array[15] = 3;

        Console.WriteLine($"array[-9] = {array[-9]}");
        Console.WriteLine($"array[0] = {array[0]}");
        Console.WriteLine($"array[15] = {array[15]}");
    }
}
