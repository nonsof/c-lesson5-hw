// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

float summ (int [] array)
{
    float summ = 0;
    int res;
    for (int i = 0; i < array.Length; i++)
    {
        res = i%2;
        if (res > 0)
        {
            summ += array[i];
        }
        else
        {
            summ += 0;
        }
    }
    return summ;
}

int len = GetLength();
int [] myA = array(len);
Console.WriteLine($"{String.Join(",", myA)}");
float result = summ(myA);
Console.WriteLine(result);