// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int GetLength()
// {
//     Console.WriteLine("write a lenght");
//     int lenght = Convert.ToInt32(Console.ReadLine());
//     return lenght;
// }

using System.Security.Cryptography.X509Certificates;

int [] array (int Length)
{
    int [] array = new int [Length];
    for (int a = 0; a < Length; a++)
    {
        array[a] = new Random().Next(1, 150);
    }
    return array;
}

int find (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 100 && 9 < array[i])
        {
            count += 1;
        }
    }
    return count;
}


int lenght = 10;
int [] arr = array(lenght);
Console.WriteLine(String.Join(",", arr));
int count = find (arr);
Console.WriteLine(count);
