//Задача 1: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
    }
    return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}
int[] arr = RandArray(10);
PrintArray(arr);
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
}
PrintArray(arr);
