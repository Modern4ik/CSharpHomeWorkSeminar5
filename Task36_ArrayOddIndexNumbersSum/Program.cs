// Программа по поиску суммы элементов массива , стоящих на нечётных позициях(индексах).

Console.Clear();

int[] arrayConfig = GetArrayConfigFromUser("Введите длину масива, не равную 0: ", "Введите минимальный интервал для значений: ", "Введите максимальный интервал для значений: ", "Ошибка ввода.Повторите попытку!");

int[] array = GetArrayByArrayConfig(arrayConfig);
Console.WriteLine(String.Join(" ", array));

int result = GetOddIndexNumbersSumByArray(array);

PrintReport(result);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Methods

int[] GetArrayConfigFromUser(string message1, string message2, string message3, string errorMessage)
{
    int[] arr = new int[3];

    while(true)
    {
        Console.Write(message1);
        if (int.TryParse(Console.ReadLine(), out arr[0]) && arr[0] > 0)
        {
            Console.Write(message2);
            if (int.TryParse(Console.ReadLine(), out arr[1]))
            {
                Console.Write(message3);
                if (int.TryParse(Console.ReadLine(), out arr[2]))
                {
                    return arr;
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

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetOddIndexNumbersSumByArray(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

void PrintReport(int number)
{
    Console.WriteLine($"Сумма значений, стоящих на нечётных позиция(индексах) в данном массиве, равняется -> {number}");
}

#endregion