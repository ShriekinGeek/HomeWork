﻿// ДЗ 1
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

// ДЗ 2
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Input a three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

int CutNumber(int number)
{
    number = number % 100 / 10;
    return number;
}

int result = CutNumber(number);
Console.WriteLine(result);
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Input a number ");
int Number = Convert.ToInt32(Console.ReadLine());

if(Number < 100) 
    Console.WriteLine("There is no third number!");

else
{
    int CutNumber = Number;
    while(CutNumber > 999)
    {
        CutNumber = CutNumber / 10;
    }
    int Result = CutNumber % 10;
    Console.WriteLine(Result);
}
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Input a number from 1 to 7 ");
int Day = Convert.ToInt32(Console.ReadLine());

bool IsHol(int Day)
{
    if(Day < 6)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool res = IsHol(Day);
Console.WriteLine(res);
*/


// ДЗ 3
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void PalinCheck(int Number)
{
    if(Number > 10000 && Number < 100000)
    {
        int FirstNum = Number / 10000;
        int FifthNum = Number % 10;
        int SecondNum = Number / 1000 % 10;
        int FourthNum = Number / 10 % 10;
        if(FirstNum == FifthNum && SecondNum == FourthNum)
            Console.WriteLine("Yes!");
        else
            Console.WriteLine("No!");
    }
    else
    {
        Console.WriteLine("Input a correct number!");
    }
} 

Console.Write("Input a five-digit number ");
int UserNum = Convert.ToInt32(Console.ReadLine());

PalinCheck(UserNum);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.Write("Input the first X coordinates ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second X coordinates ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first y coordinates ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second y coordinates ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the first z coordinates ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second z coordinates ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
double result = Math.Round(distance, 3);
Console.Write($"Distance between dots equal {result}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Write("Input a positive number ");

void Row(double number)
{
    int index = 1;
    while(index <= number)
    {
        double cube = Math.Pow(index, 3);
        Console.Write(cube + " ");
        index ++; 
    }
}

double CubeNum = Convert.ToDouble(Console.ReadLine());

Row(CubeNum);
*/
