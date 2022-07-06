/*Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("Здравствуйте."); 
Console.WriteLine("Эта программа создаёт и выводит на экран целочисленный массив.");
Console.Write("Введите длинну массива: ");
uint actualArrayLength = Convert.ToUInt32(Console.ReadLine());
int[] actualArray = fillArray(actualArrayLength);
Console.WriteLine("Результат: {0},", arrayToString(actualArray));



//Функция заполнения массива указанной длинны.
int[] fillArray(uint arrayLength)
{   
    int[] array = new int[arrayLength];
    Console.WriteLine("Длина вашего массива из целых чисел будет равна {0}", arrayLength);
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write("Введите значения для элемента массива с индексом [{0}]: ", i);
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}
//Функция перевода массива в строку типа [1, 2, 3]
string arrayToString(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            output += Convert.ToString(array[i]) + "]";
        }
        else
        {
            output += Convert.ToString(array[i])+", ";
        }
        
    }
    return output;
}

