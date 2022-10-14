// ДЗ 1
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
    Console.WriteLine("Max = " + n1 + " Min = " + n2);
else
    Console.WriteLine("Max = " + n2 + " Min = " + n1);
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2 > max)
    max = n2;
else
    max = n1;

if(n3 > max)
    max = n3;
else
    max = max;

Console.WriteLine("Max = " + max);
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
    Console.Write("Yes!");
else
    Console.Write("No!");
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input the positive number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= N)
{
    Console.Write(current + " ");
    current += 2;
}
*/