//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine();
Console.WriteLine("Исходные данные (массив) ");
string[] array1 = {"[" + "123", "23", "4568", "1", "11555", "44", "7", "753", "LS", "Moscow" + "]" };    // Задаем первоначальный массив
PrintArray1(array1);                                                                                   // Выводим на печать
int lenghtNew = 3;                                                                                 // Переменная - условие (равно или меньше 3 знаков)
int num1 = ArrayParametr(array1, lenghtNew);

void PrintArray1(string[] arr)

{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
}

int ArrayParametr(string[] arr2, int lenghtNew)

{
    int result = 0;

    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= lenghtNew) result++;
    }
    return result;
}