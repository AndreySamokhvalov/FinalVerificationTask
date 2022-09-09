Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("FinalVerificationTask");
Console.ResetColor();
Console.WriteLine("Добро пожаловать!");

// метод для формирования массива из введенных с клавиатуры строк
string[] ReadData()
{
    Console.WriteLine("Задайте количество строк в массиве:");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте массив строк");
    Console.Clear();
    Console.WriteLine("Введите произвольные строки через Enter:");


    string[] inputArray = new string[size];

    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write((i + 1) + " строка " + ": ");
        inputArray[i] = Console.ReadLine();
        Console.Clear();
    }
    return inputArray;
}

// метод для модификации заданного массива согласно условиям задачи
string[] ModifiedArray(string[] inputArray)
{
    string[] outArray = new string[inputArray.Length];
    int j = 0;
    // по условию, длина отсортированной строки 
    // должна быть меньше или равна 3 символа
    int maxStringSize = 3;
    for (int i = 0; i < inputArray.Length; i++)
    {
        // Условие ограничивающее длинну строки в модифицированном массиве
        // и исключающее из него пустые строки
        if ((inputArray[i].Length <= maxStringSize) && (inputArray[i].Length != 0))
        {
            outArray[j] = inputArray[i];
            j++;
        }
    }
    // изменяем длинну модифицированного массива
    Array.Resize(ref outArray, j);
    return outArray;
}

// метод для печати одномерного массива строк
void PrintIntArray(string[] printArray)
{
    // проверка наличия элементов в массиве
    if (printArray.Length == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Элементы отсутвуют!");
        Console.WriteLine();
        Console.ResetColor();
    }
    else
    {
        int i = 0;
        Console.Write("[");
        while (i < printArray.Length - 1)
        {
            Console.Write('\u0022' + printArray[i] + '\u0022' + ", ");
            i++;
        }
        // убираем запятую после последнего элемента
        Console.WriteLine('\u0022' + printArray[i] + '\u0022' + "]");
        Console.WriteLine();
    }
}

string[] inputData = ReadData();
ModifiedArray(inputData);
Console.WriteLine("Заданный массив: ");
PrintIntArray(inputData);
Console.WriteLine("Отсортированный массив: ");
PrintIntArray(ModifiedArray(inputData));


