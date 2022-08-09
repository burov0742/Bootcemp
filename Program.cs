﻿// Вывод таблицы умножения
/*
int n = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");

    }
    Console.WriteLine();
}
*/
//как уменьшить время работы программы? Добвить матрицу, т.к. для заполнения матрицы неолбходимо знать только половину таблицы;

/*

int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,n];
for (int i =0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix [i,j] = (i+1) * (j+1);
        matrix [j,i] = (i+1) * (j+1);

    }
    Console.WriteLine();
}
for (int i =1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");

    }
    Console.WriteLine();
}
*/

// Пузырьковая сортировка и сортировка выбором
/* 
сортировка выбором
[6, 15, 2, 9, -3]
min = 6
6 < 15, yes
6 < 2, no
min = 2
2 < 9, yes
2 < -3, no
min = -3
[-3, 6, 15, 2, 9]
Оставляем первое число и присваемаем min второе значение и провторяем цикл сравнения.

*/

/*
Console.WriteLine("введите количество элемнтов массива");
int n = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
int [] array = new int [n];
for (int i =0; i < n; i++)
{
    Console.Write("введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Сортировка
for (int i = 0; i < n; i++)
{
    int Minindex = i;
    for (int j = i+1; j < n; j++)
    {
        if ( array[j] < array[Minindex])
            Minindex = j;
    }
    int temp = array[Minindex];
    array[Minindex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
*/

// сортировка массива с типом string
/*

string [] array = new string [5];
for ( int i = 0; i < 5; i++)
    array[i] = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

for (int i = 0; i < 4; i++)
{
    int Minindex = i;
    for (int j = i+1; j < 5; j++)
    {
        if ( array[j].Length < array[Minindex].Length)
            Minindex = j;
    }
    string temp = array[Minindex];
    array[Minindex] = array[i];
    array[i] = temp;
}
Console.WriteLine("конечный массив: [" + string.Join(", ", array) + "]");

*/