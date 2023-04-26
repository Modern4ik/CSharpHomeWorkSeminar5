// Программа по поиску количества чётных чисел в случайно заданном массиве, состоящем из трёхзначных, положительных чисел.

Console.Clear();

int[] arrayConfig = GetArrayConfigFromUser("Введите кол-во элементов массива, не равное 0: ", "Введите минимальное значение интервала для элементов массива, которое является положительным и трёхзначным: ", "Введите максимальное значение интервала для элементов массива, которое является положительным и трёхзначным: ", "Ошибка ввода.Повторите попытку!");

int[] array = GetArrayByArrayConfig(arrayConfig);

int result = GetEvenNumbersCountByArray(array);

PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int[] GetArrayConfigFromUser(string message1, string message2, string message3, string errorMessage)
{
    int[] array = new int[3];

    while (true)
    {
        Console.Write(message1);
        if (int.TryParse(Console.ReadLine(), out array[0]) && array[0] > 0)
        {
            Console.Write(message2);
            if (int.TryParse(Console.ReadLine(), out array[1]) && array[1] > 0 && array[1] > 99 && array[1] < 1000)
            {
                Console.Write(message3);
                if (int.TryParse(Console.ReadLine(), out array[2]) && array[2] > 0 && array[2] > 99 && array[2] < 1000)
                {
                    return array;
                }
            }
        }
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayByArrayConfig(int[] arr)
{
    int size = arr[0];
    int minValue = arr[1];
    int maxValue = arr[2];
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine(String.Join(" ", res));
    return res;
}

int GetEvenNumbersCountByArray(int[] arr)
{
    int count = 0;

    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintReport(int number)
{
    Console.WriteLine($"Количество чётных чисел в данном масиве равняется -> {number}");
}