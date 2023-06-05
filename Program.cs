/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них четные");

void FillArray(int[] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    {
        numbers[x] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int x = 0; x < numbers.Length; x++)
    {
        Console.Write(numbers[x] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sumNotEven = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sumNotEven = sumNotEven + numbers[i];
    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов, стоящих на нечетных позициях = {sumNotEven}");

void FillArray(int[] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    {
        numbers[x] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int x = 0; x < numbers.Length; x++)
    {
        Console.Write(numbers[x] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Всего {numbers.Length} чисел. Максимальный элемент = {max}, минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");

void FillArray(double[] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    {
        numbers[x] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int x = 0; x < numbers.Length; x++)
    {
        Console.Write(numbers[x] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/