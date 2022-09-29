// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо ввести на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + "\t"); 
    Console.Write("");
    }
}

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] InitialArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    InitialArray[i] = element;
}

string[] GeneratedArray = new string[size];
{
    int position = 0;
    for (int j = 0; j < size; j++)
    if (InitialArray[j].Length <= 3)
    {
        GeneratedArray[position] = InitialArray[j];
        position++;
    }
}

Console.WriteLine();
PrintArray(GeneratedArray);