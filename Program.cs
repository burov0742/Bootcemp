// Lesson 3

// Вывод таблицы умножения
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




// Lesson4

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

// Lesson 5 - сортировка пузырьком O(n^2). каждый раз цикл сравниевает попартно значения и переставляет их если необходимо. 
//После каждой перестановке цикл начинает проверку с начала массиваю

/*
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
1. [1, 3, 5, 0, 7, 9, 8]
2. [1, 3, 0, 5, 7, 9, 8]
3. [1, 0, 3, 5, 7, 9, 8]
4. [0, 1, 3, 5, 7, 9, 8]
5. [0, 1, 3, 5, 7, 8, 9]

*/

/*
Console.WriteLine("введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

for (int i =0; i < n; i++)
{
    Console.Write("введите знаяния элементов: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n-1; j++)
    {
        if (array[j] > array[j+1])
        {
            int temp = array[j];
            array[j] = array[j+1];
            array[j+1] = temp;
        }
    }
    Console.WriteLine(i + " [" + string.Join(", ", array) + "]");
}
*/

// Lesson 6 -  быстрая сортировка

/*
1. arr = {1,0,-6,2,5,3,2}
2. arr [6] == pivot - опорный элеиент
3. вызвать шаги 1 и 2 для подмассивов справа и слева от pivot 
*/

int [] arr = {0, -5, 2, 3, 5, 9, -1, 7};
int [] result = null;

int [] QuickSort (int [] inputArray, int minIndex, int maxIndex)
{
    int pivot = 0;
    QuickSort (inputArray, minIndex, pivot - 1);
    QuickSort (inputArray, pivot +1, maxIndex);
    return inputArray;
}

int GetPivotIndex (int [] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex -1;
    for (int i = minIndex; i < maxIndex - 1; i++);
    {
        if (inputArray[i] <= inputArray[maxIndex])
        {
            pivotIndex ++;
            Swap (inputArray, i, pivotIndex);
        }
    } 
    pivotIndex++;
    Swap
}

void Swap (int [] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray [leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}