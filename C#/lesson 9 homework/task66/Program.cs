// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите значение числа m");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите значение числа n");

int n = Convert.ToInt32(Console.ReadLine());

int sum = m;
while (n !=m)
{
    sum = sum + (m+1);
    m++; 
}

Console.WriteLine(sum);