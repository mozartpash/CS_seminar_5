// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)// Содаём массив и будем контролировать его рамер, мин. диапозон и макс. диапазон
{
    int[] result = new int[size];//создаём массив и в нём будет храниться число элиментов, какое мы решим через аргумент size
    for (int i = 0; i < size; i++)//пробежимся по последовательности массива
    {
        result[i] = new Random().Next(minValue, maxValue + 1);//заполняем массив рандомными данными, диапазон котролируем сами. +1 т.к. он отмимет 1        
    }
    return result;
}

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);// Сразу возвращаем данные, введённые пользаком
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }  
    Console.WriteLine();  
}

int arrSize = GetNum("Задайте длинну массива: ");
int arrMin = GetNum("Введите минимальное значение: ");
int arrMax = GetNum("Введите максимальное значение: ");
int[]arr = GetArray(arrSize,arrMin,arrMax);




void NegativeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    } 
    Console.WriteLine("Противоположные значения вашего массива: ");
    PrintArray(arr);   
}

PrintArray(arr);
NegativeArray(arr);