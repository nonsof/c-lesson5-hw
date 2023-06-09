// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


 double [] array (int Length)
{
    double [] array = new double [Length];
    for (int a = 0; a < Length; a++)
    {
        array[a] = new Random().NextDouble()*100;
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("write a lenght");
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

string Doub (double [] array)
{
    string ary = String.Empty;
    double temp;
    for (int i = 0; i < array.Length; i++)
    {
        temp = Math.Round (array[i], 2);
        ary = ary + temp + ", "; 
    }
    return ary;
}

double minmax (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array [i];
            i++;
        }
    }    
    return max; 
}

double maxmin (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i]<min)
        {
            min = array [i];
            i++;
        }
    }
    return min;

}

void wow (double a, double b)
{
    double sub = a-b;
    Console.WriteLine($"as you wish, ur diff: {Math.Round (sub, 2)}");
    Console.WriteLine($"and also ur diff: {sub}");
}



int len = GetLength();
double [] myAr = array (len);
Console.WriteLine($"Ur massive: {String.Join(",", myAr)}");
string norm = Doub(myAr);
Console.WriteLine($"a little easier {norm}");
double min = maxmin(myAr);
double max = minmax (myAr);
Console.WriteLine($"min here: {Math.Round (min, 2)}");
Console.WriteLine($"max here: {Math.Round (max, 2)}");
wow(max, min);


yumm