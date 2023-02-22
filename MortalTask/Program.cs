// Задача Финальная: Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

int n = 10;
Console.WriteLine($"В заданном массиве всего {n} элементов");

string[] array = new string[n];
array[0] = "dsvnk";
array[1] = "hjk";
array[2] = "hglhll";
array[3] = "hg6";
array[4] = "jlk4fj";
array[5] = "glhgl";
array[6] = "123";
array[7] = "679jgj";
array[8] = "hu";
array[9] = "P";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Внимание, ваш исходный массив:");
PrintArray(array);

string[] arrayLessThanThree(string[] array)
{
    int lengthOfNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lengthOfNewArray++;
    }

    string[] newArray = new string[lengthOfNewArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

Console.WriteLine();
Console.WriteLine($"Внимание, ваш новый массив коротышей:");
PrintArray(arrayLessThanThree(array));


