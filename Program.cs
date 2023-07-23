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
