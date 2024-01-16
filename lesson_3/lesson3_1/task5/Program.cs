// пример программы для ввода в ручную эементов массива из 10 чисел

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите элемент массива:");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i++;
}
foreach (int e in arr_int)
{
    Console.Write($"{e} ");
}

