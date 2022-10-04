// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Task_41()
{
    Console.Write("Введите числа через пробел: ");
    double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
    double count = 0;
 
    for (double i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {count}");
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Task_43()
{
    Console.Write("Введите b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");
}

// Task_41();
Task_43();