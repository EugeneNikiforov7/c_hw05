
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// форматирование вывода
// Console.WriteLine(number.ToString("0.00"));
// Console.WriteLine($"{number:0.00}");

void PrintArray(double[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length-1; i++)
    {
        Console.Write($"{array[i]:0.00}, ");
    }
    Console.Write($"{array[length-1]:0.00}] => ");
}

double GetMin(double[] array)
{
    double min = 99;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
    return min;
}

double GetMax(double[] array)
{
    double max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
    return max;
}

double[] MakeNewRandomArray(int size, double beginvalue, double endvalue)
{
    double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().NextDouble()*(endvalue - beginvalue) + beginvalue;
        }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetInfo("Введите размерность массива: ");
double[] array = MakeNewRandomArray(number, 0, 99);

//Console.Write($"[{string.Join(", ", array)}] -> ");

PrintArray(array);
double diff = GetMax(array) - GetMin(array);
Console.WriteLine($"{GetMax(array):0.00} - {GetMin(array):0.00} = {diff:0.00}");