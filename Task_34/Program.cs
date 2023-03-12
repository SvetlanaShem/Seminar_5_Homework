Console.Clear();
int num = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int[] array = GetArray(num, 100, 999);
int evenCount = GetEvenCount(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> в массиве {evenCount} четных чисел");

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

int GetEvenCount(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}