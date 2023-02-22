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
array[9] = "j";

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine($"Внимание, ваш массив:");
PrintArray(array);

