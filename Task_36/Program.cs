Console.Clear();
int num = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите начальное значение массива: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное значение массива: ", "Ошибка ввода!");
int[] array = GetArray(num, min, max);
int sum = GetUnevenSum(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> сумма чисел на нечетных позициях в массиве равна {sum}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetUnevenSum(int[] arr)
{
    int summa = 0;
    int i = 0;
    while (i < arr.Length)
    {
        summa = summa + arr[i];
        i = i + 2;
    }
    return summa;
}