// See Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]


string [] Array = {"hello", "2", "World", "123"};
int count = ArrayCheck (Array);

string [] resultArray = FillResultArray (Array, count);
int ArrayCheck (string[] array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        count++;
    }
    return count;

}

string[] FillResultArray (string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
PrintArray(resultArray);
