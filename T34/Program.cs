// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 int [] array (int Length)
{
    int [] array = new int [Length];
    for (int a = 0; a < Length; a++)
    {
        array[a] = new Random().Next(100, 1000);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("write a lenght");
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

int exx (int [] array)
{
   int count = 0;
   int counte = 0;
   int res;
    for (int i = 0; i < array.Length; i++)
    {
        res = array[i]%2;
        if (res == 0)
        {
        count ++;
        }
        else
        {
            counte ++;
        }
    }
    return count;
    
}

int len = GetLength();
int [] myA = array(len);
Console.WriteLine($"{String.Join(",", myA)}");
int cou = exx(myA);
Console.WriteLine(cou);


