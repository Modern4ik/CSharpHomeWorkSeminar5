// Программа по поиску разницы между максимальным и минимальным элементом массива , состоящим из вещественных чисел.

Console.Clear();

int arrayLenght = GetArrayLenghtFromUser("Введите длину масива, не равную 0: ", "Ошибка ввода.Повторите попытку!");

double[] array = GetArrayByArrayLenght(arrayLenght);
Console.WriteLine(String.Join("|", array));

double minValue = GetMinValueByArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальный элемент в данном массиве -> {minValue}");

double maxValue = GetMaxValueByArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент в данном массиве -> {maxValue}");

double result = GetDifferenceByMinMaxValue(minValue, maxValue);

PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int GetArrayLenghtFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int lenght) && lenght > 0)
        {
            return lenght;
        }
        Console.WriteLine(errorMessage);
    }
}

double[] GetArrayByArrayLenght(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().NextDouble();
        int randomNumber = new Random().Next(100, 500);
        res[i] = res[i] * randomNumber;
    }
    return res;
}

double GetMinValueByArray(double[] arr)
{
    double min = arr[0];

    foreach (double el in arr)
    {
        if (el < min)
        {
            min = el;
        }
    }
    return min;
}

double GetMaxValueByArray(double[] arr)
{
    double max = arr[0];

    foreach (double el in arr)
    {
        if (el > max)
        {
            max = el;
        }
    }
    return max;
}

double GetDifferenceByMinMaxValue(double minNumb, double maxNumb)
{
    double difference = maxNumb - minNumb;
    return difference;
}

void PrintReport(double number)
{
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом в данном массиве равняется -> {number}");
}