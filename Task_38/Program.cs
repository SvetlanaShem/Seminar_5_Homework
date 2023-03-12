Console.Clear();
int num = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите начальное значение массива: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное значение массива: ", "Ошибка ввода!");
double[] array = GetArray(num, min, max);
double maxInArray = GetMaxNumber(array);
double minInArray = GetMinNumber(array);
double result = maxInArray - minInArray;
Console.WriteLine($"[{String.Join(", ", array)}] -> разница между максимальным значением массива {maxInArray} и минимальным {minInArray} равна {result}");

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

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double GetMaxNumber(double[] arr)
{
    double maxNumber = arr[0];
    int i = 1;
    while(i<arr.Length)
    {
        if(maxNumber<arr[i]) maxNumber = arr[i];
        i++;
    }
    return maxNumber;
}

double GetMinNumber(double[] arr)
{
    double minNumber = arr[0];
    int i = 1;
    while(i<arr.Length)
    {
        if(minNumber>arr[i]) minNumber = arr[i];
        i++;
    }
    return minNumber;
}