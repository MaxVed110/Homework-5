/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
*/

int[] Array(int length, int deviation)
{
    int[] arrayGeneration = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayGeneration[i] = new Random().Next(-deviation, deviation + 1);
    }
    return arrayGeneration;
}

int SumElement(int[] array)
{
    int sumElement = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumElement += array[i];
        }
    }
    return sumElement;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

Console.WriteLine("Введите длину массива и значение диапазона чисел N (-N..N): ");

int lengthUser = Convert.ToInt32(Console.ReadLine());
int deviationUser = Convert.ToInt32(Console.ReadLine());

int[] arrayUser = Array(lengthUser, deviationUser);
int sumElement = SumElement(arrayUser);

Console.Write("В массиве ");
ArrayPrint(arrayUser);
Console.Write($" сумма элементов на нечётных позициях равна {sumElement}");

