// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1  [1, 2, 3, 6, 2] ->   [10, 11, 12, 13, 14] -> 5
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(0, 125);
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
int count = 0; 
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] >9 && arr[i] < 100) count++;
}  
Console.WriteLine(count);
