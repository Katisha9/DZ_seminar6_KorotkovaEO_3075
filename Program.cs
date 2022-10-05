// ДЗ. Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
/*
Console.WriteLine("Укажите, какое количество чисел будем вводить: "); float qnt = float.Parse(Console.ReadLine()!); float[] array = GetArray(qnt, -999, 1000);
Console.WriteLine(String.Join(", ", array));
 float posNumbers = 0;

for  float i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        posNumbers++;
    }
}

Console.WriteLine($"Количество чисел больше 0 = {posNumbers}.");

 float[] GetArray float size, float minValue, float maxValue)
{
 float[] res = new float[size];

    for  float i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение k1: ");
float k1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b1: "); 
float b1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение k2: "); 
float k2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение b2: "); 
float b2 = float.Parse(Console.ReadLine()!);
 
float x = 0; 
float y = 0;

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

if (k1 == k2) 
{
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны и не имеют точки пересечения");
}
else {
Console.WriteLine($"Координаты точки пересечения прямых y = {k1}x + {b1} и y = {k2}x + {b2}: ({x}; {y})");
}
