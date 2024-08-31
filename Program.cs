// Задача: Написать программу, которая из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

public class Task01
{
    public static void Main()
    {
        // массивы строк для теста
        string[] str1 = { "Hello", "2", "world", ":-)" };
        string[] str2 = { "1234", "1567", "-2", "computer science" };
        string[] str3 = { "Ruusia", "Denmark", "Kazan" };

        Console.Write("Исходный массив: ");
        PrintStrinArray(str1);

        string[] newstr1 = NewStringArray(str1);
        Console.Write("Массив с элементами, длина которых <= 3: ");
        PrintStrinArray(newstr1);

        Console.Write("Исходный массив: ");
        PrintStrinArray(str2);

        string[] newstr2 = NewStringArray(str2);
        Console.Write("Массив с элементами, длина которых <= 3: ");
        PrintStrinArray(newstr2);

        Console.Write("Исходный массив: ");
        PrintStrinArray(str3);

        string[] newstr3 = NewStringArray(str3);
        Console.Write("Массив с элементами, длина которых <= 3: ");
        PrintStrinArray(newstr3);
    }

    public static void PrintStrinArray(string[] strprint)
    {
        Console.WriteLine("[\"" + string.Join("\", \"", strprint) + "\"]");
    }

    public static string[] NewStringArray(string[] inpstr)
    {
        int count3char = 0;

        foreach (string elemstr in inpstr)
        {
            if (elemstr.Length <= 3)
                count3char++;

        }

        string[] outstr = new string[count3char];

        for (int i = 0, j = 0; i < inpstr.Length; i++)
        {
            if (inpstr[i].Length <= 3)
            {
                outstr[j] = inpstr[i];
                j++;
            }
        }

        return outstr;
    }
}
