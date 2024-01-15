// НП, Задайте массив, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: да/нет.

// int[] array = { 1, 3, 8, 19, 3 };

// int a = int.Parse(Console.ReadLine()!);

// for (int i = 0; i < array.length; i++)
// {
//     if (i == array[i])
//         Console.Write("YES");
//     else
//         Console.Write("NO");
// }

using System.ComponentModel;

int[] array = { 1, 3, 8, 19, 3 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;
foreach (int element in array)
{
    if (element == a)
    
        b = true;
    
}

{
    if (b)
        Console.WriteLine("ДА");
    else
        Console.WriteLine("НЕТ");
}
