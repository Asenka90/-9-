// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.WriteLine("***Задача 64:***");
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Натуральные числа в промежутке от M до N: ");
if (M > N)
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.WriteLine($" {i}");
Console.WriteLine("");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("***Задача 66:***");
Console.Write("Введи N: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N: ");
if (M > N)
    for (int i = N1; i <= M1; i++)
        sum += i;
else
    for (int i = M1; i <= N1; i++)
        Console.Write($" {i}");
Console.Write($" {sum}");
Console.WriteLine("");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("***Задача 68:***");
Console.WriteLine("Введи M");
UInt64 Number1 = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Введи N");
UInt64 Number2 = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("По функции Aккермана A(M,N): ");
UInt64 Ackerman(UInt64 M3, UInt64 N3)
{
if (M3 == 0) return N3 + 1;
if (M3 > 0 && N3 == 0) return Ackerman(M3 - 1, 1);
if (M3 > 0 && N3 > 0) return Ackerman(M3 - 1, Ackerman(M3, N3 - 1));
return 0;
}
Console.WriteLine(Ackerman(Number1, Number2));
