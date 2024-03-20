Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [length];
for (int i = 0; i < stringArray.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
}
Console.WriteLine($"Ваш массив: [{string.Join(",", stringArray)}]");