using System;

class Program
{
    static void Main()
    {
        double epsilon = 0.0001; // Задана похибка

        double sum = 0.0;
        double term = 0.0;
        double i = 1.0;

        do
        {
            term = 1.0 / (i * i); // Обчислення доданку
            sum += term; // Додавання доданку до суми
            i++;
        } while (term >= epsilon); // Перевірка похибки

        Console.WriteLine("Наближене значення суми: " + sum);
    }
}
