// Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет             3; массив [6, 7, 19, 345, 3] -> да
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
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
bool Exist(int[] arr, int element)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element) return true;
    }
    return false;
}
int[] arr = RandArray(10);
PrintArray(arr);
int Number = Prompt("Введите число ");
if (Exist(arr, Number))
    Console.WriteLine("Да");
else Console.WriteLine("Нет");
