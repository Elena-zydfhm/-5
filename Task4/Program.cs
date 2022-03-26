// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3       [6 7 3 6] -> 36 21
int[] Array = RandArray(9);
int[] Array2 = RandArray(Array.Length / 2);
PrintArray(Array);

for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++)
{
    Array2[i] = Array[i] * Array[j];
    j--;
}
PrintArray(Array2);

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 101);
    }
    return answer;
}

