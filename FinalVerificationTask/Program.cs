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


