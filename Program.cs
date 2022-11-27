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


// ДЗ 4

// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponent(int A, int B)
{
    int result = 1;
    for(int i=1; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Input the number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The answer is {Exponent(A, B)}");
*/


// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int TotalSum(int Number)
{
    int CutNumber = Number;
    int Sum = 0;
    while(CutNumber >= 10)
    {
        Sum += CutNumber % 10;
        CutNumber /= 10;
    }
    Sum += CutNumber;
    return Sum;

}

Console.Write("Input not a single-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers in number {a} is {TotalSum(a)}");
*/


// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
Console.Write("Input numbers separated by comma: ");
string RawOfNumbers = Console.ReadLine();

RawOfNumbers += ",";

string RemovingSpaces (string Series)
{
    string SeriesNew = "";
    for (int i = 0; i < Series.Length; i++)
    {
    if (Series[i] != ' ')
        {
            SeriesNew += Series[i];
        }
    }
    return SeriesNew;
}

int[] ArrayOfNumbers(string RawNew)
{ 
    int[] arrayOfNumbers = new int[1];
    
    int j =0;
    
    for (int i = 0; i < RawNew.Length; i++)
    {
        string seriesNew1 = "";
        while (RawNew[i] != ',' && i < RawNew.Length)
        {
            seriesNew1 += RawNew[i];
            i++;
        }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < RawNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
    }
return arrayOfNumbers;
}


void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
Console.Write("]");
} 


string seriesNew = RemovingSpaces(RawOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
*/

// ДЗ 5
// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
Console.WriteLine("Input a massive size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine(count);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.WriteLine("Input a massive size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int a = 1; a < numbers.Length; a+=2)
    sum += numbers[a];

Console.WriteLine(sum);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-10,100);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.WriteLine("Input a massive size");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = 1000;
double max = 0;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine(max - min);

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/




