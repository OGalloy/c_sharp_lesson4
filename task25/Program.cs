/*Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Программа для возведения числа А в степень числа B.");
Console.WriteLine("Число B должно быть больше 0.");
Console.Write("Введите число А.");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B.");
uint numberB = Convert.ToUInt32(Console.ReadLine());
int result = PowTwoDigit(numberA, numberB);
Console.WriteLine("Результат: {0} в степени {1} равно {2}", numberA, numberB, result);



/*Функция возводит аргумент а в степень b.
У аргумента b беззнаковый тип,
 Так как указанно, что b натуральное число.*/  
int PowTwoDigit(int a, uint b)
{   
    int result = a;
    if (a == 0)
    {
        return 0;
    }
    else if (a == 1)
    {
        return 1;
    }
    else if (a == - 1)
    {
        return -1;
    }
    else
    {
        // цикл возведения в степень
        for (int i = 2; i <= b; i++)
        {
            result *= a;
        }
    }
    return result;
}