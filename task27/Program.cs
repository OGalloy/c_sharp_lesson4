/*Задача 27: Напишите программу,
которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Программа нахождения суммы всех цифр введённого числа.");
Console.WriteLine("Пример: 452 -> 4 + 5 + 2 = 11.");
Console.Write("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int summary = addDigit(number);
Console.WriteLine("Результат: {0}", summary);

/*Функция нахождения суммы всех цифр числа*/
int addDigit(int number)
{   
    //переводим отрицательное число в положительное.
    if (number < 0) number *= -1;
    int sum = 0;
    //цикл подсчёта суммы всех цифр
    while (number >= 1)
    {
        int remainder = number % 10;
        sum += remainder;
        number /= 10;
    }
    return sum;
}
