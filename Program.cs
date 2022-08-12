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

/*
public static void QuickSort (int [] imputArray, int minIndex, int maxIndex)
{
    static int GetPivotIndex (int [] inputArray, int maxIndex, int maxIndex)
    {
        int pivotIndex = minIndex - 1;
        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (inputArray[i] < inputArray[maxIndex])
            {
                pivotIndex++;
                Swap (ref inputArray[i], ref inputArray[pivotIndex]);
            }
        }
        pivotIndex++;
        Swap (ref inputArray[pivotIndex], ref inputArray[maxIndex]);
        return pivotIndex;
    }

    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex (inputArray, minIndex, maxIndex);
    QuickSort (inputArray, minIndex, pivot - 1);
    QuickSort (inputArray, pivot + 1), manIndex);
    return;
}

*/




// Lesson 7 - гонка сортировок.

// Lesson 8 - параллельное програмирование на примере умножения матриц

const int N = 1000; // размер матрицы
const int THREADS_NUMBER = 10;

int [,] serialMulRes = new int [N, N]; // результат выполнения умножения матриц в однопотоке
int [,] threadMulRes = new int [N, N]; // результат параллельного умножения матриц

int [,] firstMatrix = MatrixGeneration(N,N);
int [,] secondMatrix = MatrixGeneration (N, N);



SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrix (firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes,threadMulRes));

int [,] MatrixGeneration (int rows, int columns)
{
    Random _rand = new Random();
    int [,] res = new int [rows, columns];
    for (int i = 0; i < res.GetLength(0); i ++)
    {
        for (int j =0; j < res.GetLength(1); j++)
        {
            res [i,j] = _rand.Next(-100,100);
        }
    }

    return res;
}

void SerialMatrixMul (int [,] a, int [,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i,j] += a[i,k] * b[i,k];
            }
        }
    }
}

void PrepareParallelMatrix (int [,] a, int [,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    int eachTheadCalc = N / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for ( int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachTheadCalc;
        int endPos = (i + 1) * eachTheadCalc;
        // усли последний поток
        if ( i == THREADS_NUMBER -1 ) endPos = N;
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul (int [,] a, int [,] b,  int startPos, int endPos)
{
    
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i,j] += a[i,k] * b[i,k];
            }
        }
    }
}

bool EqualityMatrix (int [,] fmatrix, int [,] smatrix)
{
    bool res = true;

    for (int i =0; i < fmatrix.GetLength(0); i++)
    {
        for ( int j = 0; j < fmatrix.GetLength(1); j ++)
        {
            res = res && ( fmatrix[i,j] == smatrix[i,j]);
        }
    }

    return res;
}