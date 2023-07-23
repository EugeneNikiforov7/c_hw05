// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int SumEvenNumber(int[] array)
{
    int res = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) res += array[i];
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

int number = GetInfo("Введите размерность массива: ");
int[] array = MakeNewRandomArray(number, -999, 999);

Console.Write("[" + string.Join(", ", array) + "] -> ");

int evennum = SumEvenNumber(array);

Console.WriteLine(evennum);