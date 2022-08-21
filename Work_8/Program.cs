//Task 1
/*
int[,]CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int [,]newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j]= new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void OrderingLinesArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void Show2dArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
       for(int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i,j] + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,]array= CreateRandom2dArray(n,m,min, max);
OrderingLinesArray(array);
Show2dArray(array);
*/

//Task 2
/*
int[,] Create2DArray(int rows, int columns, int minEl, int maxEl)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(minEl, maxEl + 1);
    }
    return array;
}
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinSumLine(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
    }
    int indexMinSum = 0;
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        if(newArray[i] < newArray[indexMinSum]) indexMinSum = i;
    }
    return indexMinSum + 1;
}
Console.Write("Введите необходимое количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
while(rows == columns)
{
    Console.WriteLine("Введите прямоугольный двумерный массив: ");
    Console.Write("Введите необходимое количество строк в массиве: ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите необходимое количество столбцов в массиве: ");
    columns = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DArray(rows, columns, min, max);
Show2DArray(array);
int result = MinSumLine(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result} строка"); 
*/

//Task 3
/*
int[,] Create2DArray(int rows, int columns, int minEl, int maxEl)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++) array[i, j] = new Random().Next(minEl, maxEl + 1);
    }
    return array;
}
int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
    int multi = 0;
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++) 
        {
            multi = array1[i, j] * array2[i, j];
            newArray[i, j] = multi;
        }
    }
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array1 = Create2DArray(3, 3, -10, 10);
int[,] array2 = Create2DArray(3, 3, -10, 10);
if(array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
{
    Console.WriteLine("Ошибка, введите равное количество строк и столбцов в двух массивах");
}
else
{
    Console.WriteLine("Массив 1:");
    Show2dArray(array1);
    Console.WriteLine("Массив 2:");
    Show2dArray(array2);
    int[,] newArray = MultiplyMatrix(array1, array2);
    Console.WriteLine("Новый массив:");
    Show2dArray(newArray);
}
*/
//Task 4
int[,,] Create3DArray(int rows, int columns, int lines)
{
    int[,,] array = new int[rows, columns, lines];
    int t = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < lines; k++, t++) 
            {
                array[i, j, k] = 10 + t; 
            }
        }
    }
    
    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] array = Create3DArray(5, 5, 5);
if(array[array.GetLength(0) - 1, array.GetLength(1) - 1, array.GetLength(2) - 1] < 100)
{
    Show3dArray(array);
}
else Console.WriteLine("Уменьшите размер массива");
