/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/* Решение 1
double InputNum(string message)
{
    Console.Write(message + " ");
    return Convert.ToDouble(Console.ReadLine());

}

double Exponentiation (double Number, double Degree)
{
    return Math.Pow(Number,Degree);
}

double Number = InputNum("Введите число (А) которое нужно возвести в степень: ");
double Degree = InputNum("Введите степень (В) в которую нужно возвести число: ");

Console.Write("Число А в Степение В равно: " + Exponentiation(Number,Degree));

*/

/* Тест 1
PS D:\Home_Works\CS_HW_4> dotnet run
Введите число (А) которое нужно возвести в степень:  3
Введите степень (В) в которую нужно возвести число:  5
Число А в Степение В равно: 243
PS D:\Home_Works\CS_HW_4> dotnet run
Введите число (А) которое нужно возвести в степень:  2
Введите степень (В) в которую нужно возвести число:  4
Число А в Степение В равно: 16
*/

/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/* Решение 2
int InputNum(string message)
{
    
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());

}

int SumOfNumbers (int Number)
{

    int result = 0;
    while (Number > 0)
    {
        result += Number % 10;
        Number = Number/10;
    }

    return result;

}

int Number = InputNum("Введите ваше число: ");
Console.Write("Сумма цифр в числе = " + SumOfNumbers(Number));
*/

/* Тест 2 
PS D:\Home_Works\CS_HW_4> dotnet run
Введите ваше число:  452
Сумма цифр в числе = 11
PS D:\Home_Works\CS_HW_4> dotnet run
Введите ваше число:  82
Сумма цифр в числе = 10
PS D:\Home_Works\CS_HW_4> dotnet run
Введите ваше число:  9012
Сумма цифр в числе = 12
*/

/* Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Разработать метод CreateArray(int size), генерирующий массив на основе данных, 
вводимых пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* Решение 3
int InputNum(string message)
{
    
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());

}

int[] CreateArray(int Length)
{

    int [] array = new int[Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNum("Введите " + i + " элемент массива");
    }

    return array;

}

void PrintArray(int[] array)
{
    Console.Write("[");

    for(int i=0; i < array.Length-1; i++)
    {
       Console.Write(array[i] + ","); 
    }

    Console.Write(array[array.Length-1] + "]");
}

int Length = InputNum("Введите длину массива ");
int[] array = CreateArray(Length);
PrintArray(array);
*/

/* Тест 3 
PS D:\Home_Works\CS_HW_4> dotnet run
Введите длину массива  5
Введите 0 элемент массива 1
Введите 1 элемент массива 2
Введите 2 элемент массива 5
Введите 3 элемент массива 7
Введите 4 элемент массива 19
[1,2,5,7,19]
PS D:\Home_Works\CS_HW_4> dotnet run
Введите длину массива  3
Введите 0 элемент массива 6
Введите 1 элемент массива 1
Введите 2 элемент массива 33
[6,1,33]
*/