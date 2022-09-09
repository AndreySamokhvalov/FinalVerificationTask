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


