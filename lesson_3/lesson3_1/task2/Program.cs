
// Вывод на экран квадратов чисел от 1 до N

void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSquares(10);