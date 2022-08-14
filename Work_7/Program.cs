//Task 1
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

int[,]array= CreateRandom2dArray(n,m, min, max);
Show2dArray(array);

