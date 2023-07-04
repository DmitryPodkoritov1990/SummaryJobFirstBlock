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
string[] newArrayStrings = new string[num1]; // создаем новый массив
NewArray(array1, newArrayStrings, lenghtNew);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Массив данных, состоящий из 3 или менее знаков ");
Console.WriteLine("[" + string.Join(", ", newArrayStrings) + "]");

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

// функция формирования нового массива строк
void NewArray(string[] firstArray, string[] secondArray, int lengthLimit)
{
    int temporary = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= lengthLimit)
        {
            secondArray[temporary] = firstArray[i];
            temporary++;
        }
    }
}
