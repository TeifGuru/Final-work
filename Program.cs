Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[length];
void firstArray(string[] stringArray) // Заполнение массива
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
    Console.WriteLine($"Ваш массив: [{string.Join(", ", stringArray)}]");
}
string[] finalArray(string[] stringArray) // Подсчет колличества искомых элементов массива и вывод нового массива
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            count++;
    }
    Console.WriteLine($" Искомых элементов мссива: {count}");

    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newArray[index] = stringArray[i];
            index++;
        }
    }
    Console.WriteLine($"Ваш новый массив: [{string.Join(", ", newArray)}]");
    return newArray;
}
firstArray(stringArray);
finalArray(stringArray);