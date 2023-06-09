// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


using System.ComponentModel;

int [] array (int Length)
{
    int [] array = new int [Length];
    for (int a = 0; a < Length; a++)
    {
        array[a] = new Random().Next();
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("write a lenght");
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

int maxi (int [] array)
{
    int maxi = 0;
    for (int i = 0;i < array.Length; i++)
    {
        if (i > maxi)
        {
            maxi = i;
        }
    }
    return maxi;
    
}

int mini (int [] array)
{
    int mini = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < mini)
        {
            mini = i;
        }
    }
    return mini;
    
}




int len = GetLength();
int [] myA = array(len);
Console.WriteLine($"{String.Join(",", myA)}");
int min = mini (myA);
int max = maxi (myA);
float multi = 0; 
Console.WriteLine($"минимальный индекс: {min}");
Console.WriteLine($"максимальный индекс: {max}");

while (min<max)
{
    string res = string.Empty;
    multi = myA[min]*myA[max];
    min++;
    max--;
    res = res + " " + multi ;
    Console.Write (res);
}



