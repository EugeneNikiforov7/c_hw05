// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumOddPosition(int[] array)
{
    int res = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) res += array[i];
        }
    return res;
}

int[] MakeNewRandomArray(int size, int beginvalue, int endvalue)
{
    int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(beginvalue, endvalue + 1);
        }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number1 = GetInfo("Введите размерность массива: ");
int number2 = GetInfo("Введите начальное значение: ");
int number3 = GetInfo("Введите конечное значение: ");
int[] array = MakeNewRandomArray(number1, number2, number3);

Console.Write("[" + string.Join(", ", array) + "] -> ");

int sumodd = SumOddPosition(array);

Console.WriteLine(sumodd);