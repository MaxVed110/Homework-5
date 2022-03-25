/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] FractionalArray(int length, int deviation)
{
    double[] arrayGeneration = new double[length];
    double arrayGenerationOne = new double();
    double arrayGenerationTwo = new double();
    for (int i = 0; i < length; i++)
    {
        arrayGenerationOne = new Random().NextDouble();
        arrayGenerationTwo = new Random().Next(-deviation, deviation + 1);
        arrayGeneration[i] = arrayGenerationOne + arrayGenerationTwo;
        arrayGeneration[i] = Math.Round(arrayGeneration[i], 2);
    }
    return arrayGeneration;
}

double DifferenceMaxMin(double[] array)
{
    double difference = new double();
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        else
        {
            if (minNumber > array[i])
            {
                minNumber = array[i];
            }
        }
    }
    difference = maxNumber - minNumber;
    return difference;
}

void ArrayPrint(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

Console.WriteLine("Введите длину массива и значение диапазона чисел N (-N..N): ");

int lengthUser = Convert.ToInt32(Console.ReadLine());
int deviationUser = Convert.ToInt32(Console.ReadLine());

double[] arrayUser = FractionalArray(lengthUser, deviationUser);
double differenceElement = DifferenceMaxMin(arrayUser);

Console.Write("В массиве ");
ArrayPrint(arrayUser);
Console.Write($" разница между максимальным и минимальным элементами массива равна {differenceElement}");