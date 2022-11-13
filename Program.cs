//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк, которые хотите ввести: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strs = CreateArray(n);
        string[] strsDouble = strs.Where(p => p.Length <=3).ToArray();
        WriteArray(strsDouble);
    }

    static string[] CreateArray(int n) {
        string[] array = new string[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите строку №{0}:\r\n    ", i + 1);
            array[i] = Console.ReadLine(); 
        }
        return array;
    }

    static void WriteArray(string[] array) {
        Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("{0} элемент массива : {1}", i + 1, array[i]); 
        }
    }
}